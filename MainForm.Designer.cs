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
            this.SuspendLayout();
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(12, 12);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(99, 44);
            this.changePassButton.TabIndex = 0;
            this.changePassButton.Text = "Змінити пароль";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.Location = new System.Drawing.Point(12, 75);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(99, 44);
            this.teamsButton.TabIndex = 1;
            this.teamsButton.Text = "Команди";
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // tourneysButton
            // 
            this.tourneysButton.Location = new System.Drawing.Point(12, 143);
            this.tourneysButton.Name = "tourneysButton";
            this.tourneysButton.Size = new System.Drawing.Size(99, 44);
            this.tourneysButton.TabIndex = 2;
            this.tourneysButton.Text = "Турніри";
            this.tourneysButton.UseVisualStyleBackColor = true;
            this.tourneysButton.Click += new System.EventHandler(this.tourneysButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tourneysButton);
            this.Controls.Add(this.teamsButton);
            this.Controls.Add(this.changePassButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Button tourneysButton;
        private System.Windows.Forms.Button exitButton;
    }
}