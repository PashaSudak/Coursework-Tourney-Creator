namespace Tourney_Creator
{
    partial class DeleteTeamForm
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
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(33, 102);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(158, 102);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(93, 39);
            this.deleteTeamButton.TabIndex = 14;
            this.deleteTeamButton.Text = "Видалити";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(62, 54);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(166, 20);
            this.textBoxTeamName.TabIndex = 13;
            this.textBoxTeamName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTeamName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введіть id команди";
            // 
            // DeleteTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 167);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTeamForm";
            this.Text = "DeleteTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label1;
    }
}