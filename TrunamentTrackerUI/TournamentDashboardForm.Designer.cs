namespace TrunamentTrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadTournamentLabel = new Label();
            loadTournamentDropDown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentDashboardLabel.Location = new Point(132, 23);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(353, 45);
            tournamentDashboardLabel.TabIndex = 9;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentLabel
            // 
            loadTournamentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadTournamentLabel.AutoSize = true;
            loadTournamentLabel.Font = new Font("Segoe UI", 15.75F);
            loadTournamentLabel.Location = new Point(179, 104);
            loadTournamentLabel.Name = "loadTournamentLabel";
            loadTournamentLabel.Size = new Size(252, 30);
            loadTournamentLabel.TabIndex = 10;
            loadTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentDropDown
            // 
            loadTournamentDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadTournamentDropDown.Font = new Font("Segoe UI", 15.75F);
            loadTournamentDropDown.FormattingEnabled = true;
            loadTournamentDropDown.Location = new Point(122, 137);
            loadTournamentDropDown.Name = "loadTournamentDropDown";
            loadTournamentDropDown.Size = new Size(372, 38);
            loadTournamentDropDown.TabIndex = 12;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI", 15.75F);
            loadTournamentButton.Location = new Point(200, 181);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(204, 40);
            loadTournamentButton.TabIndex = 13;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 15.75F);
            createTournamentButton.Location = new Point(179, 280);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(252, 70);
            createTournamentButton.TabIndex = 21;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(636, 369);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadTournamentDropDown);
            Controls.Add(loadTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label loadTournamentLabel;
        private ComboBox loadTournamentDropDown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}