namespace Tourney_Creator
{
    partial class UpdateTourneyForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.team1Button = new System.Windows.Forms.Button();
            this.team2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(27, 90);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(152, 90);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(93, 39);
            this.nextButton.TabIndex = 22;
            this.nextButton.Text = "Далі";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Виберіть переможця";
            // 
            // team1Button
            // 
            this.team1Button.Location = new System.Drawing.Point(27, 87);
            this.team1Button.Name = "team1Button";
            this.team1Button.Size = new System.Drawing.Size(93, 42);
            this.team1Button.TabIndex = 24;
            this.team1Button.Text = "button1";
            this.team1Button.UseVisualStyleBackColor = true;
            this.team1Button.Click += new System.EventHandler(this.team1Button_Click);
            // 
            // team2Button
            // 
            this.team2Button.Location = new System.Drawing.Point(152, 87);
            this.team2Button.Name = "team2Button";
            this.team2Button.Size = new System.Drawing.Size(93, 42);
            this.team2Button.TabIndex = 25;
            this.team2Button.Text = "button2";
            this.team2Button.UseVisualStyleBackColor = true;
            this.team2Button.Click += new System.EventHandler(this.team2Button_Click);
            // 
            // UpdateTourneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(275, 154);
            this.Controls.Add(this.team2Button);
            this.Controls.Add(this.team1Button);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTourneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення переможця";
            this.Load += new System.EventHandler(this.UpdateTourneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button team1Button;
        private System.Windows.Forms.Button team2Button;
    }
}