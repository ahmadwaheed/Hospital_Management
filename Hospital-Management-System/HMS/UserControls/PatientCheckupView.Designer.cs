namespace HMS.UserControls
{
    partial class PatientCheckupView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderedPanel1 = new UIControls.BorderedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorPanel = new UIControls.BorderedPanel();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.borderedPanel1.SuspendLayout();
            this.DoctorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.borderedPanel1.BorderBottom = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderBottomWidth = 0;
            this.borderedPanel1.BorderLeft = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderLeftWidth = 0;
            this.borderedPanel1.BorderRight = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderRightWidth = 0;
            this.borderedPanel1.BorderTop = System.Drawing.Color.Empty;
            this.borderedPanel1.BorderTopWidth = 0;
            this.borderedPanel1.Controls.Add(this.label1);
            this.borderedPanel1.Location = new System.Drawing.Point(30, 51);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Size = new System.Drawing.Size(99, 30);
            this.borderedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lato", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "01 Jun 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorPanel
            // 
            this.DoctorPanel.AutoSize = true;
            this.DoctorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(183)))));
            this.DoctorPanel.BorderBottom = System.Drawing.Color.Empty;
            this.DoctorPanel.BorderBottomWidth = 0;
            this.DoctorPanel.BorderLeft = System.Drawing.Color.Empty;
            this.DoctorPanel.BorderLeftWidth = 0;
            this.DoctorPanel.BorderRight = System.Drawing.Color.Empty;
            this.DoctorPanel.BorderRightWidth = 0;
            this.DoctorPanel.BorderTop = System.Drawing.Color.Empty;
            this.DoctorPanel.BorderTopWidth = 0;
            this.DoctorPanel.Controls.Add(this.DoctorLabel);
            this.DoctorPanel.Location = new System.Drawing.Point(135, 51);
            this.DoctorPanel.Name = "DoctorPanel";
            this.DoctorPanel.Size = new System.Drawing.Size(100, 30);
            this.DoctorPanel.TabIndex = 0;
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorLabel.Font = new System.Drawing.Font("Lato", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorLabel.ForeColor = System.Drawing.Color.White;
            this.DoctorLabel.Location = new System.Drawing.Point(0, 0);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(100, 30);
            this.DoctorLabel.TabIndex = 0;
            this.DoctorLabel.Text = "Doctor: Lorem Ipsum";
            this.DoctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCheckupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DoctorPanel);
            this.Controls.Add(this.borderedPanel1);
            this.Name = "PatientCheckupView";
            this.Size = new System.Drawing.Size(554, 495);
            this.borderedPanel1.ResumeLayout(false);
            this.DoctorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIControls.BorderedPanel borderedPanel1;
        private System.Windows.Forms.Label label1;
        private UIControls.BorderedPanel DoctorPanel;
        private System.Windows.Forms.Label DoctorLabel;

    }
}
