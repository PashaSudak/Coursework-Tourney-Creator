namespace Tourney_Creator
{
    partial class MainForm
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
            this.changePassButton = new System.Windows.Forms.Button();
            this.teamsButton = new System.Windows.Forms.Button();
            this.tourneysButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.diagramsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(12, 162);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(99, 44);
            this.changePassButton.TabIndex = 3;
            this.changePassButton.Text = "Змінити пароль";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.Location = new System.Drawing.Point(12, 12);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(99, 44);
            this.teamsButton.TabIndex = 0;
            this.teamsButton.Text = "Команди";
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // tourneysButton
            // 
            this.tourneysButton.Location = new System.Drawing.Point(12, 62);
            this.tourneysButton.Name = "tourneysButton";
            this.tourneysButton.Size = new System.Drawing.Size(99, 44);
            this.tourneysButton.TabIndex = 1;
            this.tourneysButton.Text = "Турніри";
            this.tourneysButton.UseVisualStyleBackColor = true;
            this.tourneysButton.Click += new System.EventHandler(this.tourneysButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 44);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diagramsButton
            // 
            this.diagramsButton.Location = new System.Drawing.Point(12, 112);
            this.diagramsButton.Name = "diagramsButton";
            this.diagramsButton.Size = new System.Drawing.Size(99, 44);
            this.diagramsButton.TabIndex = 2;
            this.diagramsButton.Text = "Діаграма";
            this.diagramsButton.UseVisualStyleBackColor = true;
            this.diagramsButton.Click += new System.EventHandler(this.diagramsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tourney_Creator.Properties.Resources.cybersport;
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.diagramsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tourneysButton);
            this.Controls.Add(this.teamsButton);
            this.Controls.Add(this.changePassButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Button tourneysButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button diagramsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}