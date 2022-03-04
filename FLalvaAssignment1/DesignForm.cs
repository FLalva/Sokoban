/*FLalvaAssignment1.sln
  Design Form Code

  Revision History
    Fatima Lalva, 2019.09.17: Created */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLalvaAssignment1
{
    public partial class DesignForm : Form
    {
        private bool noneClicked = false;
        private bool heroClicked = false;
        private bool wallClicked = false;
        private bool boxClicked = false;
        private bool destinationClicked = false;

        int rowCount;
        int colCount;

        public DesignForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Game File (*.FLgame)|*.FLgame";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine($"{rowCount},{colCount}");

                    foreach (PictureBoxTile pictureBox in panelBoard.Controls)
                    {
                        writer.WriteLine(pictureBox.GetTileInfo());
                    }
                }

                //if file saved successfully:
                MessageBox.Show("File saved sucessfully", "DESIGN SAVED");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRow.Text, out rowCount))
            {
                MessageBox.Show("Input has to be an integer", "ERROR");
                txtRow.Clear();
                txtRow.Focus();
            }
            else if (!int.TryParse(txtCol.Text, out colCount))
            {
                MessageBox.Show("Input has to be an integer", "ERROR");
                txtCol.Clear();
                txtCol.Focus();
            }
            else
            {
                panelBoard.Controls.Clear();
                saveToolStripMenuItem.Enabled = true;

                noneClicked = false;
                heroClicked = false;
                wallClicked = false;
                boxClicked = false;
                destinationClicked = false;

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        PictureBoxTile pictureBoxTile = new PictureBoxTile(row, col);
                        pictureBoxTile.Click += PictureBoxTile_Click;
                        pictureBoxTile.BorderStyle = BorderStyle.Fixed3D;
                        //Display on screen
                        panelBoard.Controls.Add(pictureBoxTile);
                    }
                }
            }
        }

        private void PictureBoxTile_Click(object sender, EventArgs e)
        {
            PictureBoxTile pictureBoxTile = sender as PictureBoxTile;

            if (heroClicked)
            {
                pictureBoxTile.Image = Properties.Resources.hero;
                pictureBoxTile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTile.Category = TileCategory.Hero;
            }
            else if (wallClicked)
            {
                pictureBoxTile.Image = Properties.Resources.wall;
                pictureBoxTile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTile.Category = TileCategory.Wall;
            }
            else if (noneClicked)
            {
                pictureBoxTile.Image = null;
                pictureBoxTile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTile.Category = TileCategory.None;
            }
            else if (boxClicked)
            {
                pictureBoxTile.Image = Properties.Resources.box;
                pictureBoxTile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTile.Category = TileCategory.Box;
            }
            else if (destinationClicked)
            {
                pictureBoxTile.Image = Properties.Resources.destination;
                pictureBoxTile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTile.Category = TileCategory.Destination;
            }
        }

        private void btnHero_Click(object sender, EventArgs e)
        {
            noneClicked = false;
            heroClicked = true;
            wallClicked = false;
            boxClicked = false;
            destinationClicked = false;
        }
        

        private void btnWall_Click(object sender, EventArgs e)
        {
            noneClicked = false;
            heroClicked = false;
            wallClicked = true;
            boxClicked = false;
            destinationClicked = false;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            noneClicked = true;
            heroClicked = false;
            wallClicked = false;
            boxClicked = false;
            destinationClicked = false;
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            noneClicked = false;
            heroClicked = false;
            wallClicked = false;
            boxClicked = true;
            destinationClicked = false;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            noneClicked = false;
            heroClicked = false;
            wallClicked = false;
            boxClicked = false;
            destinationClicked = true;
        }
    }
}
