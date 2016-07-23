namespace DropshadowBorderlessWinForm
{
    partial class FormShadow
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
            this.LabelExit = new System.Windows.Forms.Label();
            this.PanelExit = new System.Windows.Forms.PictureBox();
            this.PanelMove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMove)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.BackColor = System.Drawing.Color.Red;
            this.LabelExit.ForeColor = System.Drawing.Color.White;
            this.LabelExit.Location = new System.Drawing.Point(278, 6);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(14, 13);
            this.LabelExit.TabIndex = 5;
            this.LabelExit.Text = "X";
            this.LabelExit.Click += new System.EventHandler(this.LabelExit_Click);
            // 
            // PanelExit
            // 
            this.PanelExit.BackColor = System.Drawing.Color.Red;
            this.PanelExit.Location = new System.Drawing.Point(270, 0);
            this.PanelExit.Name = "PanelExit";
            this.PanelExit.Size = new System.Drawing.Size(30, 25);
            this.PanelExit.TabIndex = 4;
            this.PanelExit.TabStop = false;
            this.PanelExit.Click += new System.EventHandler(this.PanelExit_Click);
            // 
            // PanelMove
            // 
            this.PanelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelMove.Location = new System.Drawing.Point(0, 0);
            this.PanelMove.Name = "PanelMove";
            this.PanelMove.Size = new System.Drawing.Size(300, 25);
            this.PanelMove.TabIndex = 3;
            this.PanelMove.TabStop = false;
            this.PanelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseDown);
            this.PanelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseMove);
            this.PanelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseUp);
            // 
            // FormShadow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.PanelExit);
            this.Controls.Add(this.PanelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShadow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Shadow";
            ((System.ComponentModel.ISupportInitialize)(this.PanelExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelExit;
        internal System.Windows.Forms.PictureBox PanelExit;
        internal System.Windows.Forms.PictureBox PanelMove;
    }
}

