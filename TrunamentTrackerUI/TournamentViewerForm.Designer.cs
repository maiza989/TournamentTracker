namespace TrunamentTrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(214, 50);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(211, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(157, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<name>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(12, 82);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 38);
            comboBox1.TabIndex = 3;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 633);
            Controls.Add(comboBox1);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox comboBox1;
    }
}
