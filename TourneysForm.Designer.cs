namespace Tourney_Creator
{
    partial class TourneysForm
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
            this.addNewTourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewTourney
            // 
            this.addNewTourney.Location = new System.Drawing.Point(12, 12);
            this.addNewTourney.Name = "addNewTourney";
            this.addNewTourney.Size = new System.Drawing.Size(93, 45);
            this.addNewTourney.TabIndex = 0;
            this.addNewTourney.Text = "Додати Турнір";
            this.addNewTourney.UseVisualStyleBackColor = true;
            this.addNewTourney.Click += new System.EventHandler(this.addNewTourney_Click);
            // 
            // TourneysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewTourney);
            this.Name = "TourneysForm";
            this.Text = "TourneysForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewTourney;
    }
}