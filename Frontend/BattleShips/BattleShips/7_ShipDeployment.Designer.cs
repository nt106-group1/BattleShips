namespace BattleShips
{
    partial class ShipDeployment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipDeployment));
            pBoxShip1 = new PictureBox();
            pBoxShip2 = new PictureBox();
            pBoxShip3 = new PictureBox();
            pBoxShip4 = new PictureBox();
            pBoxShip5 = new PictureBox();
            pBoxDesk = new PictureBox();
            btnBackMenu = new Button();
            btnRolate = new Button();
            btnReady = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxShip1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDesk).BeginInit();
            SuspendLayout();
            // 
            // pBoxShip1
            // 
            pBoxShip1.BackgroundImage = (Image)resources.GetObject("pBoxShip1.BackgroundImage");
            pBoxShip1.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxShip1.Location = new Point(57, 34);
            pBoxShip1.Name = "pBoxShip1";
            pBoxShip1.Size = new Size(100, 50);
            pBoxShip1.TabIndex = 0;
            pBoxShip1.TabStop = false;
            // 
            // pBoxShip2
            // 
            pBoxShip2.BackgroundImage = (Image)resources.GetObject("pBoxShip2.BackgroundImage");
            pBoxShip2.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxShip2.Location = new Point(57, 90);
            pBoxShip2.Name = "pBoxShip2";
            pBoxShip2.Size = new Size(150, 50);
            pBoxShip2.TabIndex = 1;
            pBoxShip2.TabStop = false;
            // 
            // pBoxShip3
            // 
            pBoxShip3.BackgroundImage = (Image)resources.GetObject("pBoxShip3.BackgroundImage");
            pBoxShip3.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxShip3.Location = new Point(57, 146);
            pBoxShip3.Name = "pBoxShip3";
            pBoxShip3.Size = new Size(150, 50);
            pBoxShip3.TabIndex = 2;
            pBoxShip3.TabStop = false;
            // 
            // pBoxShip4
            // 
            pBoxShip4.BackgroundImage = (Image)resources.GetObject("pBoxShip4.BackgroundImage");
            pBoxShip4.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxShip4.Location = new Point(57, 202);
            pBoxShip4.Name = "pBoxShip4";
            pBoxShip4.Size = new Size(200, 50);
            pBoxShip4.TabIndex = 3;
            pBoxShip4.TabStop = false;
            // 
            // pBoxShip5
            // 
            pBoxShip5.BackgroundImage = (Image)resources.GetObject("pBoxShip5.BackgroundImage");
            pBoxShip5.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxShip5.Location = new Point(57, 258);
            pBoxShip5.Name = "pBoxShip5";
            pBoxShip5.Size = new Size(250, 50);
            pBoxShip5.TabIndex = 4;
            pBoxShip5.TabStop = false;
            // 
            // pBoxDesk
            // 
            pBoxDesk.BackgroundImage = (Image)resources.GetObject("pBoxDesk.BackgroundImage");
            pBoxDesk.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxDesk.Location = new Point(388, 12);
            pBoxDesk.Name = "pBoxDesk";
            pBoxDesk.Size = new Size(400, 400);
            pBoxDesk.TabIndex = 5;
            pBoxDesk.TabStop = false;
            // 
            // btnBackMenu
            // 
            btnBackMenu.BackColor = Color.Transparent;
            btnBackMenu.BackgroundImage = (Image)resources.GetObject("btnBackMenu.BackgroundImage");
            btnBackMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackMenu.FlatAppearance.BorderSize = 0;
            btnBackMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBackMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBackMenu.FlatStyle = FlatStyle.Flat;
            btnBackMenu.Location = new Point(0, 0);
            btnBackMenu.Name = "btnBackMenu";
            btnBackMenu.Size = new Size(31, 28);
            btnBackMenu.TabIndex = 9;
            btnBackMenu.UseVisualStyleBackColor = false;
            btnBackMenu.Click += btnBackMenu_Click;
            // 
            // btnRolate
            // 
            btnRolate.BackColor = Color.Transparent;
            btnRolate.BackgroundImage = Properties.Resources.Rotate;
            btnRolate.BackgroundImageLayout = ImageLayout.Zoom;
            btnRolate.FlatAppearance.BorderSize = 0;
            btnRolate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRolate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRolate.FlatStyle = FlatStyle.Flat;
            btnRolate.Location = new Point(76, 320);
            btnRolate.Name = "btnRolate";
            btnRolate.Size = new Size(69, 65);
            btnRolate.TabIndex = 1;
            btnRolate.UseVisualStyleBackColor = false;
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.Transparent;
            btnReady.FlatAppearance.BorderSize = 0;
            btnReady.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReady.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReady.FlatStyle = FlatStyle.Flat;
            btnReady.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReady.Location = new Point(213, 322);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(94, 58);
            btnReady.TabIndex = 8;
            btnReady.Text = "Ready";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnReady_Click;
            // 
            // ShipDeployment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReady);
            Controls.Add(btnRolate);
            Controls.Add(btnBackMenu);
            Controls.Add(pBoxDesk);
            Controls.Add(pBoxShip5);
            Controls.Add(pBoxShip4);
            Controls.Add(pBoxShip3);
            Controls.Add(pBoxShip2);
            Controls.Add(pBoxShip1);
            Name = "ShipDeployment";
            Text = "Place your ships!";
            ((System.ComponentModel.ISupportInitialize)pBoxShip1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShip5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDesk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBoxShip1;
        private PictureBox pBoxShip2;
        private PictureBox pBoxShip3;
        private PictureBox pBoxShip4;
        private PictureBox pBoxShip5;
        private PictureBox pBoxDesk;
        private Button btnBackMenu;
        private Button btnRolate;
        private Button btnReady;
    }
}