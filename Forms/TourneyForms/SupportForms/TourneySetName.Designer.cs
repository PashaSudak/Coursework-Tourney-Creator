namespace Tourney_Creator
{
    partial class TourneySetName
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
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.textBoxTourneyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(46, 113);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(171, 113);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(93, 39);
            this.deleteTeamButton.TabIndex = 18;
            this.deleteTeamButton.Text = "Далі";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // textBoxTourneyName
            // 
            this.textBoxTourneyName.Location = new System.Drawing.Point(75, 65);
            this.textBoxTourneyName.Name = "textBoxTourneyName";
            this.textBoxTourneyName.Size = new System.Drawing.Size(166, 20);
            this.textBoxTourneyName.TabIndex = 17;
            this.textBoxTourneyName.TextChanged += new System.EventHandler(this.textBoxTourneyName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введіть назву турніру";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TourneySetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(311, 188);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.textBoxTourneyName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TourneySetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення назви";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.TextBox textBoxTourneyName;
        private System.Windows.Forms.Label label1;
    }
}