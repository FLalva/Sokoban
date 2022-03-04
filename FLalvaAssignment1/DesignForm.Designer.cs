namespace FLalvaAssignment1
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGenerate = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNone = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnHero = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelGenerate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelGenerate
            // 
            this.panelGenerate.Controls.Add(this.btnGenerate);
            this.panelGenerate.Controls.Add(this.txtCol);
            this.panelGenerate.Controls.Add(this.txtRow);
            this.panelGenerate.Controls.Add(this.label2);
            this.panelGenerate.Controls.Add(this.label1);
            this.panelGenerate.Location = new System.Drawing.Point(12, 47);
            this.panelGenerate.Name = "panelGenerate";
            this.panelGenerate.Size = new System.Drawing.Size(789, 69);
            this.panelGenerate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(572, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(419, 22);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 26);
            this.txtCol.TabIndex = 1;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(108, 19);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 26);
            this.txtRow.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows: ";
            // 
            // panelBoard
            // 
            this.panelBoard.AutoScroll = true;
            this.panelBoard.Location = new System.Drawing.Point(282, 169);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(768, 554);
            this.panelBoard.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ToolBox";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "none.PNG");
            this.imageList1.Images.SetKeyName(1, "hero.PNG");
            this.imageList1.Images.SetKeyName(2, "wall.PNG");
            this.imageList1.Images.SetKeyName(3, "box.PNG");
            this.imageList1.Images.SetKeyName(4, "destination.PNG");
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList1;
            this.btnNone.Location = new System.Drawing.Point(28, 169);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(165, 69);
            this.btnNone.TabIndex = 8;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnWall
            // 
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 2;
            this.btnWall.ImageList = this.imageList1;
            this.btnWall.Location = new System.Drawing.Point(28, 342);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(168, 69);
            this.btnWall.TabIndex = 7;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnBox
            // 
            this.btnBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBox.ImageIndex = 3;
            this.btnBox.ImageList = this.imageList1;
            this.btnBox.Location = new System.Drawing.Point(28, 427);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(168, 69);
            this.btnBox.TabIndex = 6;
            this.btnBox.Text = "Box";
            this.btnBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestination.ImageIndex = 4;
            this.btnDestination.ImageList = this.imageList1;
            this.btnDestination.Location = new System.Drawing.Point(28, 515);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(168, 69);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "Destination";
            this.btnDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnHero
            // 
            this.btnHero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHero.ImageIndex = 1;
            this.btnHero.ImageList = this.imageList1;
            this.btnHero.Location = new System.Drawing.Point(28, 252);
            this.btnHero.Name = "btnHero";
            this.btnHero.Size = new System.Drawing.Size(168, 69);
            this.btnHero.TabIndex = 4;
            this.btnHero.Text = "Hero";
            this.btnHero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHero.UseVisualStyleBackColor = true;
            this.btnHero.Click += new System.EventHandler(this.btnHero_Click);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 779);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnHero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.panelGenerate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGenerate.ResumeLayout(false);
            this.panelGenerate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelGenerate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHero;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
    }
}