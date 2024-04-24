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
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            TeamOneNameLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValueTextBox = new TextBox();
            teamTwoScoreValueTextBox = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            ScoreButton = new Button();
            versusLabel = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 20.25F);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(164, 37);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 20.25F);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(182, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(119, 37);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<name>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 15.75F);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(18, 58);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(73, 30);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 15.75F);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(118, 57);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(209, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 15.75F);
            unplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckBox.Location = new Point(118, 101);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(165, 34);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Segoe UI", 15.75F);
            matchupListBox.ForeColor = SystemColors.InfoText;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(18, 155);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(309, 362);
            matchupListBox.TabIndex = 5;
            // 
            // TeamOneNameLabel
            // 
            TeamOneNameLabel.AutoSize = true;
            TeamOneNameLabel.Font = new Font("Segoe UI", 15.75F);
            TeamOneNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamOneNameLabel.Location = new Point(417, 214);
            TeamOneNameLabel.Name = "TeamOneNameLabel";
            TeamOneNameLabel.Size = new Size(135, 30);
            TeamOneNameLabel.TabIndex = 6;
            TeamOneNameLabel.Text = "<Team One>";
            TeamOneNameLabel.Click += TeamOneNameLabel_Click;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 15.75F);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(417, 251);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(64, 30);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValueTextBox
            // 
            teamOneScoreValueTextBox.Font = new Font("Segoe UI", 15.75F);
            teamOneScoreValueTextBox.Location = new Point(505, 254);
            teamOneScoreValueTextBox.Name = "teamOneScoreValueTextBox";
            teamOneScoreValueTextBox.Size = new Size(100, 35);
            teamOneScoreValueTextBox.TabIndex = 8;
            // 
            // teamTwoScoreValueTextBox
            // 
            teamTwoScoreValueTextBox.Font = new Font("Segoe UI", 15.75F);
            teamTwoScoreValueTextBox.Location = new Point(505, 415);
            teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            teamTwoScoreValueTextBox.Size = new Size(100, 35);
            teamTwoScoreValueTextBox.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 15.75F);
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(417, 412);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(64, 30);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Font = new Font("Segoe UI", 15.75F);
            teamTwoNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoNameLabel.Location = new Point(417, 375);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(133, 30);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "<Team Two>";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI", 15.75F);
            ScoreButton.ForeColor = SystemColors.MenuHighlight;
            ScoreButton.Location = new Point(626, 305);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(134, 60);
            ScoreButton.TabIndex = 12;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 15.75F);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(469, 317);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(53, 30);
            versusLabel.TabIndex = 13;
            versusLabel.Text = "-VS-";
            versusLabel.Click += versusLabel_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(793, 546);
            Controls.Add(versusLabel);
            Controls.Add(ScoreButton);
            Controls.Add(teamTwoScoreValueTextBox);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreValueTextBox);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(TeamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
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
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label TeamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValueTextBox;
        private TextBox teamTwoScoreValueTextBox;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Button ScoreButton;
        private Label versusLabel;
    }
}
