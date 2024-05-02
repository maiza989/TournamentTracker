namespace TrunamentTrackerUI
{
    partial class TournamentCreatorForm
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
            createTournamentLabel = new Label();
            TournamentNameLabel = new Label();
            tournamentPrizeListBox = new Label();
            tournamentPlayerListBox = new Label();
            entryFeeLabel = new Label();
            entryFeeTextBox = new TextBox();
            tournamentNameTextBox = new TextBox();
            selectTeamLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            prizesListBox = new ListBox();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            PlayersListDeleteSelectedButton = new Button();
            prizesListDeleteSelectedButton = new Button();
            selectTeamDropDown = new ComboBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentLabel.Location = new Point(11, 6);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(242, 37);
            createTournamentLabel.TabIndex = 0;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 15.75F);
            TournamentNameLabel.Location = new Point(38, 90);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(182, 30);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "Tournament name";
            // 
            // tournamentPrizeListBox
            // 
            tournamentPrizeListBox.AutoSize = true;
            tournamentPrizeListBox.Font = new Font("Segoe UI", 15.75F);
            tournamentPrizeListBox.Location = new Point(398, 286);
            tournamentPrizeListBox.Name = "tournamentPrizeListBox";
            tournamentPrizeListBox.Size = new Size(73, 30);
            tournamentPrizeListBox.TabIndex = 2;
            tournamentPrizeListBox.Text = " Prizes";
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.AutoSize = true;
            tournamentPlayerListBox.Font = new Font("Segoe UI", 15.75F);
            tournamentPlayerListBox.Location = new Point(398, 36);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(156, 30);
            tournamentPlayerListBox.TabIndex = 3;
            tournamentPlayerListBox.Text = "Teams / Players";
          //  tournamentPlayerListBox.Click += tournamentPlayerListBox_Click;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 15.75F);
            entryFeeLabel.Location = new Point(38, 201);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(104, 30);
            entryFeeLabel.TabIndex = 4;
            entryFeeLabel.Text = " Entry Fee";
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.Font = new Font("Segoe UI", 15.75F);
            entryFeeTextBox.Location = new Point(148, 198);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(152, 35);
            entryFeeTextBox.TabIndex = 5;
            entryFeeTextBox.Text = "0";
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Font = new Font("Segoe UI", 15.75F);
            tournamentNameTextBox.Location = new Point(38, 130);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(262, 35);
            tournamentNameTextBox.TabIndex = 6;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 15.75F);
            selectTeamLabel.Location = new Point(38, 265);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(123, 30);
            selectTeamLabel.TabIndex = 7;
            selectTeamLabel.Text = "Select Team";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.Font = new Font("Segoe UI", 15.75F);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(398, 69);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(418, 214);
            tournamentPlayersListBox.TabIndex = 8;
            // 
            // prizesListBox
            // 
            prizesListBox.Font = new Font("Segoe UI", 15.75F);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(398, 319);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(418, 214);
            prizesListBox.TabIndex = 9;
            // 
            // addTeamButton
            // 
            addTeamButton.Font = new Font("Segoe UI", 15.75F);
            addTeamButton.Location = new Point(82, 350);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(152, 47);
            addTeamButton.TabIndex = 10;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 15.75F);
            createPrizeButton.Location = new Point(82, 418);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(152, 47);
            createPrizeButton.TabIndex = 11;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PlayersListDeleteSelectedButton
            // 
            PlayersListDeleteSelectedButton.Font = new Font("Segoe UI", 15.75F);
            PlayersListDeleteSelectedButton.Location = new Point(822, 70);
            PlayersListDeleteSelectedButton.Name = "PlayersListDeleteSelectedButton";
            PlayersListDeleteSelectedButton.Size = new Size(190, 97);
            PlayersListDeleteSelectedButton.TabIndex = 12;
            PlayersListDeleteSelectedButton.Text = " Delete Seletecd";
            PlayersListDeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // prizesListDeleteSelectedButton
            // 
            prizesListDeleteSelectedButton.Font = new Font("Segoe UI", 15.75F);
            prizesListDeleteSelectedButton.Location = new Point(822, 338);
            prizesListDeleteSelectedButton.Name = "prizesListDeleteSelectedButton";
            prizesListDeleteSelectedButton.Size = new Size(190, 97);
            prizesListDeleteSelectedButton.TabIndex = 13;
            prizesListDeleteSelectedButton.Text = "Delete Selected";
            prizesListDeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.Font = new Font("Segoe UI", 15.75F);
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(38, 299);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(262, 38);
            selectTeamDropDown.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 15.75F);
            linkLabel1.Location = new Point(172, 265);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 30);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Team";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(318, 551);
            button1.Name = "button1";
            button1.Size = new Size(281, 70);
            button1.TabIndex = 16;
            button1.Text = "Create Prize";
            button1.UseVisualStyleBackColor = true;
            // 
            // TournamentCreatorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 633);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(selectTeamDropDown);
            Controls.Add(prizesListDeleteSelectedButton);
            Controls.Add(PlayersListDeleteSelectedButton);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(tournamentPrizeListBox);
            Controls.Add(TournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(7);
            Name = "TournamentCreatorForm";
            Text = "Tournament Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label TournamentNameLabel;
        private Label tournamentPrizeListBox;
        private Label tournamentPlayerListBox;
        private Label entryFeeLabel;
        private TextBox entryFeeTextBox;
        private TextBox tournamentNameTextBox;
        private Label selectTeamLabel;
        private ListBox tournamentPlayersListBox;
        private ListBox prizesListBox;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Button PlayersListDeleteSelectedButton;
        private Button prizesListDeleteSelectedButton;
        private ComboBox selectTeamDropDown;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}