namespace TrunamentTrackerUI
{
    partial class CreateTeamForm
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
            tournamentTeamNameLabel = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberDropdown = new ComboBox();
            teamMemberLabel = new Label();
            addMemberToTeamButton = new Button();
            createNewMemberGroupBox = new GroupBox();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            cellphoneTextBox = new TextBox();
            cellphoneLabel = new Label();
            createNewMemberButton = new Button();
            teamMembersListBox = new ListBox();
            teamMembersDeleteSelectedButton = new Button();
            createTeamButton = new Button();
            createNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentTeamNameLabel
            // 
            tournamentTeamNameLabel.Font = new Font("Segoe UI", 15.75F);
            tournamentTeamNameLabel.Location = new Point(39, 93);
            tournamentTeamNameLabel.Name = "tournamentTeamNameLabel";
            tournamentTeamNameLabel.Size = new Size(314, 35);
            tournamentTeamNameLabel.TabIndex = 9;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 15.75F);
            teamNameLabel.Location = new Point(39, 60);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(124, 30);
            teamNameLabel.TabIndex = 8;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.Location = new Point(12, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(170, 37);
            createTeamLabel.TabIndex = 7;
            createTeamLabel.Text = " Create Team";
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.Font = new Font("Segoe UI", 15.75F);
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(39, 182);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(314, 38);
            selectTeamMemberDropdown.TabIndex = 11;
            // 
            // teamMemberLabel
            // 
            teamMemberLabel.AutoSize = true;
            teamMemberLabel.Font = new Font("Segoe UI", 15.75F);
            teamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            teamMemberLabel.Location = new Point(39, 149);
            teamMemberLabel.Name = "teamMemberLabel";
            teamMemberLabel.Size = new Size(207, 30);
            teamMemberLabel.TabIndex = 10;
            teamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberToTeamButton
            // 
            addMemberToTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberToTeamButton.FlatAppearance.CheckedBackColor = Color.Silver;
            addMemberToTeamButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            addMemberToTeamButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addMemberToTeamButton.FlatStyle = FlatStyle.Flat;
            addMemberToTeamButton.Location = new Point(108, 226);
            addMemberToTeamButton.Name = "addMemberToTeamButton";
            addMemberToTeamButton.Size = new Size(165, 40);
            addMemberToTeamButton.TabIndex = 12;
            addMemberToTeamButton.Text = " Add Member";
            addMemberToTeamButton.UseVisualStyleBackColor = true;
            // 
            // createNewMemberGroupBox
            // 
            createNewMemberGroupBox.Controls.Add(createNewMemberButton);
            createNewMemberGroupBox.Controls.Add(cellphoneTextBox);
            createNewMemberGroupBox.Controls.Add(cellphoneLabel);
            createNewMemberGroupBox.Controls.Add(emailTextBox);
            createNewMemberGroupBox.Controls.Add(emailLabel);
            createNewMemberGroupBox.Controls.Add(lastNameTextBox);
            createNewMemberGroupBox.Controls.Add(lastNameLabel);
            createNewMemberGroupBox.Controls.Add(firstNameTextBox);
            createNewMemberGroupBox.Controls.Add(firstNameLabel);
            createNewMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            createNewMemberGroupBox.Location = new Point(39, 272);
            createNewMemberGroupBox.Name = "createNewMemberGroupBox";
            createNewMemberGroupBox.Size = new Size(314, 251);
            createNewMemberGroupBox.TabIndex = 13;
            createNewMemberGroupBox.TabStop = false;
            createNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(21, 34);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 30);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 15.75F);
            firstNameTextBox.Location = new Point(140, 36);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(145, 35);
            firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 15.75F);
            lastNameTextBox.Location = new Point(140, 77);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(145, 35);
            lastNameTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(21, 75);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 30);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 15.75F);
            emailTextBox.Location = new Point(140, 118);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(145, 35);
            emailTextBox.TabIndex = 14;
            emailTextBox.TextChanged += textBox3_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(27, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            emailLabel.Click += emailLabel_Click;
            // 
            // cellphoneTextBox
            // 
            cellphoneTextBox.Font = new Font("Segoe UI", 15.75F);
            cellphoneTextBox.Location = new Point(140, 158);
            cellphoneTextBox.Name = "cellphoneTextBox";
            cellphoneTextBox.Size = new Size(145, 35);
            cellphoneTextBox.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new Point(21, 159);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(124, 30);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone #";
            cellphoneLabel.Click += label3_Click;
            // 
            // createNewMemberButton
            // 
            createNewMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createNewMemberButton.FlatAppearance.CheckedBackColor = Color.Silver;
            createNewMemberButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createNewMemberButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            createNewMemberButton.FlatStyle = FlatStyle.Flat;
            createNewMemberButton.Location = new Point(69, 205);
            createNewMemberButton.Name = "createNewMemberButton";
            createNewMemberButton.Size = new Size(165, 40);
            createNewMemberButton.TabIndex = 17;
            createNewMemberButton.Text = " Add Member";
            createNewMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 15.75F);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(395, 93);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(418, 424);
            teamMembersListBox.TabIndex = 14;
            // 
            // teamMembersDeleteSelectedButton
            // 
            teamMembersDeleteSelectedButton.Font = new Font("Segoe UI", 15.75F);
            teamMembersDeleteSelectedButton.Location = new Point(626, 49);
            teamMembersDeleteSelectedButton.Name = "teamMembersDeleteSelectedButton";
            teamMembersDeleteSelectedButton.Size = new Size(187, 38);
            teamMembersDeleteSelectedButton.TabIndex = 15;
            teamMembersDeleteSelectedButton.Text = "Delete Seletecd";
            teamMembersDeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.CheckedBackColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 15.75F);
            createTeamButton.Location = new Point(255, 559);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(281, 70);
            createTeamButton.TabIndex = 17;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 641);
            Controls.Add(createTeamButton);
            Controls.Add(teamMembersDeleteSelectedButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createNewMemberGroupBox);
            Controls.Add(addMemberToTeamButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(teamMemberLabel);
            Controls.Add(tournamentTeamNameLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Team Creation";
            createNewMemberGroupBox.ResumeLayout(false);
            createNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tournamentTeamNameLabel;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private ComboBox selectTeamMemberDropdown;
        private Label teamMemberLabel;
        private Button addMemberToTeamButton;
        private GroupBox createNewMemberGroupBox;
        private Label firstNameLabel;
        private TextBox cellphoneTextBox;
        private Label cellphoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Button createNewMemberButton;
        private ListBox teamMembersListBox;
        private Button teamMembersDeleteSelectedButton;
        private Button createTeamButton;
    }
}