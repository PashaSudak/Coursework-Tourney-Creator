namespace Tourney_Creator
{
    partial class GetTourneyIdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTourneyName = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(53, 116);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введіть id Турніру";
            // 
            // textBoxTourneyName
            // 
            this.textBoxTourneyName.Location = new System.Drawing.Point(82, 68);
            this.textBoxTourneyName.Name = "textBoxTourneyName";
            this.textBoxTourneyName.Size = new System.Drawing.Size(166, 20);
            this.textBoxTourneyName.TabIndex = 17;
            this.textBoxTourneyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTourneyName_KeyPress);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(183, 116);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(93, 39);
            this.nextButton.TabIndex = 20;
            this.nextButton.Text = "Далі";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // GetTourneyIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 193);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textBoxTourneyName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetTourneyIdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення турніру";
            this.Load += new System.EventHandler(this.GetTourneyIdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTourneyName;
        private System.Windows.Forms.Button nextButton;
    }
}