namespace HMS
{
    partial class formLogin
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
            this.borderedPanel1 = new UIControls.BorderedPanel();
            this.notificationBox1 = new UIControls.AlertBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextbox2 = new UIControls.MetroTextbox();
            this.metroTextbox1 = new UIControls.MetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new UIControls.CircularPictureBox();
            this.borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.BackColor = System.Drawing.Color.White;
            this.borderedPanel1.BorderBottom = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderBottomWidth = 0;
            this.borderedPanel1.BorderLeft = System.Drawing.Color.Silver;
            this.borderedPanel1.BorderLeftWidth = 2;
            this.borderedPanel1.BorderRight = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderRightWidth = 2;
            this.borderedPanel1.BorderTop = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderTopWidth = 0;
            this.borderedPanel1.Controls.Add(this.notificationBox1);
            this.borderedPanel1.Controls.Add(this.button3);
            this.borderedPanel1.Controls.Add(this.pictureBox3);
            this.borderedPanel1.Controls.Add(this.pictureBox2);
            this.borderedPanel1.Controls.Add(this.label2);
            this.borderedPanel1.Controls.Add(this.label3);
            this.borderedPanel1.Controls.Add(this.label1);
            this.borderedPanel1.Controls.Add(this.metroTextbox2);
            this.borderedPanel1.Controls.Add(this.metroTextbox1);
            this.borderedPanel1.Controls.Add(this.circularPictureBox1);
            this.borderedPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderedPanel1.Location = new System.Drawing.Point(354, 0);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Size = new System.Drawing.Size(280, 361);
            this.borderedPanel1.TabIndex = 0;
            // 
            // notificationBox1
            // 
            this.notificationBox1.BorderCurve = 1;
            this.notificationBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.notificationBox1.Image = null;
            this.notificationBox1.Location = new System.Drawing.Point(28, 290);
            this.notificationBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.notificationBox1.Name = "notificationBox1";
            this.notificationBox1.NotificationText = "Error";
            this.notificationBox1.NotificationType = UIControls.AlertBox.Type.Error;
            this.notificationBox1.RoundCorners = true;
            this.notificationBox1.ShowCloseButton = true;
            this.notificationBox1.Size = new System.Drawing.Size(219, 40);
            this.notificationBox1.TabIndex = 3;
            this.notificationBox1.Text = "Invalid Username & Password!";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lato", 9.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(76, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Login";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.pictureBox3.Image = global::HMS.Properties.Resources.Key_white;
            this.pictureBox3.Location = new System.Drawing.Point(28, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.pictureBox2.Image = global::HMS.Properties.Resources.User_white;
            this.pictureBox2.Location = new System.Drawing.Point(28, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(16, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "© Copyright 2019 | Hospital Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hospital Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(115, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Login";
            // 
            // metroTextbox2
            // 
            this.metroTextbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.metroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.metroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.metroTextbox2.BorderThickness = 1;
            this.metroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroTextbox2.Font = new System.Drawing.Font("Lato", 9.75F);
            this.metroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroTextbox2.isPassword = true;
            this.metroTextbox2.Location = new System.Drawing.Point(65, 194);
            this.metroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextbox2.Name = "metroTextbox2";
            this.metroTextbox2.Size = new System.Drawing.Size(182, 34);
            this.metroTextbox2.TabIndex = 1;
            this.metroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroTextbox1
            // 
            this.metroTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.metroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.metroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.metroTextbox1.BorderThickness = 1;
            this.metroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroTextbox1.Font = new System.Drawing.Font("Lato", 9.75F);
            this.metroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroTextbox1.isPassword = false;
            this.metroTextbox1.Location = new System.Drawing.Point(65, 153);
            this.metroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextbox1.Name = "metroTextbox1";
            this.metroTextbox1.Size = new System.Drawing.Size(182, 34);
            this.metroTextbox1.TabIndex = 0;
            this.metroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HMS.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderColor = System.Drawing.Color.Empty;
            this.circularPictureBox1.BorderWidth = 0;
            this.circularPictureBox1.Image = global::HMS.Properties.Resources.logo_PNG;
            this.circularPictureBox1.Location = new System.Drawing.Point(110, 17);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.borderedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Hospital Management System";
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIControls.BorderedPanel borderedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIControls.MetroTextbox metroTextbox1;
        private UIControls.MetroTextbox metroTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private UIControls.AlertBox notificationBox1;
        private System.Windows.Forms.Label label3;
        private UIControls.CircularPictureBox circularPictureBox1;

    }
}

