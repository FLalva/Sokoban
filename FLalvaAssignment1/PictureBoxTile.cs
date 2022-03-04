/*FLalvaAssignment1.sln
  PictureBoxTile Class

  Revision History
    Fatima Lalva, 2019.09.17: Created */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLalvaAssignment1
{
    enum TileCategory
    {
        None,
        Hero,
        Wall,
        Box,
        Destination
    }

    /// <summary>
    /// Class for inheritence of picture box
    /// to make it easier to gather info for each tile
    /// </summary>
    class PictureBoxTile : PictureBox
    {
        int row;
        int col;
        public TileCategory Category { get; set; }
        
        const int PICTUREBOX_SIZE = 50;

        public PictureBoxTile(int row, int col)
        {
            this.row = row;
            this.col = col;
            Category = TileCategory.None;

            this.Size = new Size(PICTUREBOX_SIZE, PICTUREBOX_SIZE);

            int x = (row * PICTUREBOX_SIZE);
            int y = (col * PICTUREBOX_SIZE);

            this.Location = new Point(x, y);
        }

        /// <summary>
        /// Method to retreive each individual tile's info
        /// to store into txt file
        /// </summary>
        /// <returns></returns>
        public string GetTileInfo()
        {
            return $"{row},{col},{(int)Category}";
        }

        /// <summary>
        /// Method to return row
        /// </summary>
        /// <returns></returns>
        public int GetRow()
        {
            return row;
        }

        /// <summary>
        /// method to return column
        /// </summary>
        /// <returns></returns>
        public int GetCol()
        {
            return col;
        }
    }
}
