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
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteTourneyButton = new System.Windows.Forms.Button();
            this.updateTourneyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewTourney
            // 
            this.addNewTourney.Location = new System.Drawing.Point(12, 12);
            this.addNewTourney.Name = "addNewTourney";
            this.addNewTourney.Size = new System.Drawing.Size(99, 49);
            this.addNewTourney.TabIndex = 0;
            this.addNewTourney.Text = "Додати Турнір";
            this.addNewTourney.UseVisualStyleBackColor = true;
            this.addNewTourney.Click += new System.EventHandler(this.addNewTourney_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 389);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 49);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Вихід";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(670, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // deleteTourneyButton
            // 
            this.deleteTourneyButton.Location = new System.Drawing.Point(13, 83);
            this.deleteTourneyButton.Name = "deleteTourneyButton";
            this.deleteTourneyButton.Size = new System.Drawing.Size(99, 49);
            this.deleteTourneyButton.TabIndex = 3;
            this.deleteTourneyButton.Text = "Видалити Турнір";
            this.deleteTourneyButton.UseVisualStyleBackColor = true;
            this.deleteTourneyButton.Click += new System.EventHandler(this.deleteTourneyButton_Click);
            // 
            // updateTourneyButton
            // 
            this.updateTourneyButton.Location = new System.Drawing.Point(12, 155);
            this.updateTourneyButton.Name = "updateTourneyButton";
            this.updateTourneyButton.Size = new System.Drawing.Size(99, 49);
            this.updateTourneyButton.TabIndex = 4;
            this.updateTourneyButton.Text = "Оновити Турнір";
            this.updateTourneyButton.UseVisualStyleBackColor = true;
            this.updateTourneyButton.Click += new System.EventHandler(this.updateTourneyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Переглянути Турнір";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TourneysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateTourneyButton);
            this.Controls.Add(this.deleteTourneyButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNewTourney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TourneysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Турніри";
            this.Load += new System.EventHandler(this.TourneysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewTourney;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteTourneyButton;
        private System.Windows.Forms.Button updateTourneyButton;
        private System.Windows.Forms.Button button1;
    }
}