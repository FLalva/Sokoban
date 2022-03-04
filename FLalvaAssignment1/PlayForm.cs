using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FLalvaAssignment1
{
    public partial class PlayForm : Form
    {
        public int moves = 0;
        public int pushes = 0;
        bool onDestinationTile = false;

        static PictureBoxTile[,] tileArray;


        public PlayForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMoves.Text = "0";
            txtPushes.Text = "0";
            moves = 0;
            pushes = 0;

            List<string> records = new List<string>();

            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Game File (*.FLgame)|*.FLgame";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = dialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            while (reader.EndOfStream == false)
                            {
                                string line = reader.ReadLine();

                                records.Add(line);
                            }
                        }

                        string[] rowCol = records[0].Split(',');
                        int row = int.Parse(rowCol[0]);
                        int col = int.Parse(rowCol[1]);

                        tileArray = new PictureBoxTile[row,col];

                        //remove the row and col from list
                        records.RemoveAt(0);

                        //split the rest and instantiate into tile class
                        int recordCounter = 0;
                        int recordMax = records.Count;

                            for (int i = 0; i < tileArray.GetLength(0); i++)
                            {
                                for (int j = 0; j < tileArray.GetLength(1); j++)
                                {
                                    string[] split = records[recordCounter].Split(',');

                                    PictureBoxTile tile = new PictureBoxTile(int.Parse(split[0]), int.Parse(split[1]));
                                    tile.BorderStyle = BorderStyle.Fixed3D;

                                    switch (int.Parse(split[2]))
                                    {
                                        case 0:
                                            tile.Category = TileCategory.None;
                                            tileArray[i, j] = tile;
                                            break;
                                        case 1:
                                            tile.Category = TileCategory.Hero;
                                            tile.Image = Properties.Resources.hero;
                                            tile.SizeMode = PictureBoxSizeMode.StretchImage;
                                            tileArray[i, j] = tile;
                                            break;
                                        case 2:
                                            tile.Category = TileCategory.Wall;
                                            tile.Image = Properties.Resources.wall;
                                            tile.SizeMode = PictureBoxSizeMode.StretchImage;
                                            tileArray[i, j] = tile;
                                            break;
                                        case 3:
                                            tile.Category = TileCategory.Box;
                                            tile.Image = Properties.Resources.box;
                                            tile.SizeMode = PictureBoxSizeMode.StretchImage;
                                            tileArray[i, j] = tile;
                                            break;
                                        case 4:
                                            tile.Category = TileCategory.Destination;
                                            tile.Image = Properties.Resources.destination;
                                            tile.SizeMode = PictureBoxSizeMode.StretchImage;
                                            tileArray[i, j] = tile;
                                            break;
                                        default:
                                            break;
                                    }

                                    pnlBoard.Controls.Add(tile);

                                    if (recordCounter < recordMax)
                                    {
                                        recordCounter++;
                                    }
                                }
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private PictureBoxTile GetTile(int row, int col)
        {
            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    int r = tileArray[i, j].GetRow();
                    int c = tileArray[i, j].GetCol();

                    if (r == row && c == col)
                    {
                        return tileArray[i, j];
                    }
                }
            }

            return null;
        }

        private PictureBoxTile FindHero()
        {
            PictureBoxTile hero = null;
            int heroCount = 0;
            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    if (tileArray[i,j].Category == TileCategory.Hero)
                    {
                        heroCount++;

                        if (heroCount > 1)
                        {
                            MessageBox.Show("There can only be one hero, load another level");
                            pnlBoard.Controls.Clear();
                            return null;
                        }

                        hero = tileArray[i, j];
                    }
                }
            }
            return hero;
        }

        /// <summary>
        /// Method to move the hero for each keyboard button
        /// </summary>
        private void MoveHero(string direction)
        {
            try
            {
                PictureBoxTile hero = FindHero();

                if (hero == null)
                {
                    MessageBox.Show("There has to be at least one Hero, load another level");
                    pnlBoard.Controls.Clear();
                    return;
                }

                int r = hero.GetRow();
                int c = hero.GetCol();

                PictureBoxTile nextTile = null;
                PictureBoxTile nextNextTile = null;

                switch (direction)
                {
                    case "up":
                        nextTile = GetTile(r, c - 1);
                        nextNextTile = GetTile(r, c - 2);
                        break;

                    case "right":
                        nextTile = GetTile(r + 1, c);
                        nextNextTile = GetTile(r + 2, c);
                        break;

                    case "down":
                        nextTile = GetTile(r, c + 1);
                        nextNextTile = GetTile(r, c + 2);
                        break;

                    case "left":
                        nextTile = GetTile(r - 1, c);
                        nextNextTile = GetTile(r - 2, c);
                        break;

                    default:
                        break;
                }

                if (nextTile.Category == TileCategory.None)
                {
                    nextTile.Image = Properties.Resources.hero;
                    nextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                    nextTile.Category = TileCategory.Hero;

                    if (onDestinationTile)
                    {
                        hero.Image = Properties.Resources.destination;
                        hero.Category = TileCategory.Destination;
                        hero.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        hero.Image = null;
                        hero.Category = TileCategory.None;
                        hero.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    //change in array using switch
                    switch (direction)
                    {
                        case "up":
                            tileArray[r, c] = hero;
                            tileArray[r, c - 1] = nextTile;
                            break;

                        case "right":
                            tileArray[r, c] = hero;
                            tileArray[r + 1, c] = nextTile;
                            break;

                        case "down":
                            tileArray[r, c] = hero;
                            tileArray[r, c + 1] = nextTile;
                            break;

                        case "left":
                            tileArray[r, c] = hero;
                            tileArray[r - 1, c] = nextTile;
                            break;

                        default:
                            break;
                    }

                    onDestinationTile = false;

                    moves++;
                }
                else if (nextTile.Category == TileCategory.Box)
                {
                    if (nextNextTile.Category == TileCategory.None)
                    {
                        //set the second tile (box)
                        nextNextTile.Image = Properties.Resources.box;
                        nextNextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                        nextNextTile.Category = TileCategory.Box;

                        //set hero
                        nextTile.Image = Properties.Resources.hero;
                        nextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                        nextTile.Category = TileCategory.Hero;

                        //set last tile 
                        if (onDestinationTile)
                        {
                            hero.Image = Properties.Resources.destination;
                            hero.Category = TileCategory.Destination;
                            hero.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            hero.Image = null;
                            hero.Category = TileCategory.None;
                            hero.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        //set array
                        switch (direction)
                        {
                            case "up":
                                tileArray[r, c] = hero;
                                tileArray[r, c - 1] = nextTile;
                                tileArray[r, c - 2] = nextNextTile;
                                break;

                            case "right":
                                tileArray[r, c] = hero;
                                tileArray[r + 1, c] = nextTile;
                                tileArray[r + 2, c] = nextNextTile;
                                break;

                            case "down":
                                tileArray[r, c] = hero;
                                tileArray[r, c + 1] = nextTile;
                                tileArray[r, c + 2] = nextNextTile;
                                break;

                            case "left":
                                tileArray[r, c] = hero;
                                tileArray[r - 1, c] = nextTile;
                                tileArray[r - 2, c] = nextNextTile;
                                break;

                            default:
                                break;
                        }

                        moves++;
                        pushes++;
                        onDestinationTile = false;
                    }
                    else if (nextNextTile.Category == TileCategory.Destination)
                    {
                        //set the second tile (box)
                        nextNextTile.Image = Properties.Resources.completedBox;
                        nextNextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                        nextNextTile.Category = TileCategory.Box;

                        //set hero
                        nextTile.Image = Properties.Resources.hero;
                        nextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                        nextTile.Category = TileCategory.Hero;
                        
                        //set last tile (was it a destination tile?)
                        if (onDestinationTile)
                        {
                            hero.Image = Properties.Resources.destination;
                            hero.Category = TileCategory.Destination;
                            hero.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            hero.Image = null;
                            hero.Category = TileCategory.None;
                            hero.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        //set array
                        switch (direction)
                        {
                            case "up":
                                tileArray[r, c] = hero;
                                tileArray[r, c - 1] = nextTile;
                                tileArray[r, c - 2] = nextNextTile;
                                break;

                            case "right":
                                tileArray[r, c] = hero;
                                tileArray[r + 1, c] = nextTile;
                                tileArray[r + 2, c] = nextNextTile;
                                break;

                            case "down":
                                tileArray[r, c] = hero;
                                tileArray[r, c + 1] = nextTile;
                                tileArray[r, c + 2] = nextNextTile;
                                break;

                            case "left":
                                tileArray[r, c] = hero;
                                tileArray[r - 1, c] = nextTile;
                                tileArray[r - 2, c] = nextNextTile;
                                break;

                            default:
                                break;
                        }

                        moves++;
                        pushes++;
                        onDestinationTile = false;
                    }
                }
                else if (nextTile.Category == TileCategory.Destination)
                {
                    nextTile.Image = Properties.Resources.hero;
                    nextTile.SizeMode = PictureBoxSizeMode.StretchImage;
                    nextTile.Category = TileCategory.Hero;

                    if (onDestinationTile)
                    {
                        hero.Image = Properties.Resources.destination;
                        hero.Category = TileCategory.Destination;
                        hero.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        hero.Image = null;
                        hero.Category = TileCategory.None;
                        hero.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    //change in array using switch
                    switch (direction)
                    {
                        case "up":
                            tileArray[r, c] = hero;
                            tileArray[r, c - 1] = nextTile;
                            break;

                        case "right":
                            tileArray[r, c] = hero;
                            tileArray[r + 1, c] = nextTile;
                            break;

                        case "down":
                            tileArray[r, c] = hero;
                            tileArray[r, c + 1] = nextTile;
                            break;

                        case "left":
                            tileArray[r, c] = hero;
                            tileArray[r - 1, c] = nextTile;
                            break;

                        default:
                            break;
                    }

                    moves++;

                    onDestinationTile = true;
                }

                txtMoves.Text = moves.ToString();
                txtPushes.Text = pushes.ToString();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveHero("up");
            CheckGameComplete();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveHero("right");
            CheckGameComplete();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveHero("down");
            CheckGameComplete();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveHero("left");
            CheckGameComplete();
        }

        /// <summary>
        /// Method to check if the game has been completed
        /// </summary>
        private void CheckGameComplete()
        {
            int destinationCount = 0;
            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    if (tileArray[i ,j].Category == TileCategory.Destination)
                    {
                        destinationCount++;
                    }
                }
            }

            if (destinationCount == 0)
            {
                MessageBox.Show($"Level Completed \nMoves: {moves} \nPushes: {pushes}", "Sokoban");
                pnlBoard.Controls.Clear();
                moves = 0;
                pushes = 0;
                txtMoves.Text = moves.ToString();
                txtPushes.Text = pushes.ToString();
            }
        }
    }
}
