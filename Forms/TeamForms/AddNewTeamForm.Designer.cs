namespace Tourney_Creator
{
    partial class AddNewTeamForm
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
            this.addNewTeamButton = new System.Windows.Forms.Button();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(34, 98);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addNewTeamButton
            // 
            this.addNewTeamButton.Location = new System.Drawing.Point(159, 98);
            this.addNewTeamButton.Name = "addNewTeamButton";
            this.addNewTeamButton.Size = new System.Drawing.Size(93, 39);
            this.addNewTeamButton.TabIndex = 10;
            this.addNewTeamButton.Text = "Додати";
            this.addNewTeamButton.UseVisualStyleBackColor = true;
            this.addNewTeamButton.Click += new System.EventHandler(this.addNewTeamButton_Click);
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(63, 50);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(166, 20);
            this.textBoxTeamName.TabIndex = 8;
            this.textBoxTeamName.TextChanged += new System.EventHandler(this.textBoxTeamName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть назву команди";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNewTeamButton);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення команди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addNewTeamButton;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label1;
    }
}