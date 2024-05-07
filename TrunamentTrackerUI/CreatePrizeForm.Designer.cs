namespace TrunamentTrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberTextBox = new TextBox();
            prizePlaceNumberLabel = new Label();
            placeNameTextBox = new TextBox();
            prizePlaceNameLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageTextBox = new TextBox();
            pricePercentageLabel = new Label();
            label4 = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(158, 37);
            createPrizeLabel.TabIndex = 8;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.Font = new Font("Segoe UI", 15.75F);
            placeNumberTextBox.Location = new Point(218, 74);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(188, 35);
            placeNumberTextBox.TabIndex = 12;
            // 
            // prizePlaceNumberLabel
            // 
            prizePlaceNumberLabel.AutoSize = true;
            prizePlaceNumberLabel.Location = new Point(26, 77);
            prizePlaceNumberLabel.Name = "prizePlaceNumberLabel";
            prizePlaceNumberLabel.Size = new Size(144, 30);
            prizePlaceNumberLabel.TabIndex = 11;
            prizePlaceNumberLabel.Text = "Place Number";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Font = new Font("Segoe UI", 15.75F);
            placeNameTextBox.Location = new Point(218, 126);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(188, 35);
            placeNameTextBox.TabIndex = 14;
            // 
            // prizePlaceNameLabel
            // 
            prizePlaceNameLabel.AutoSize = true;
            prizePlaceNameLabel.Location = new Point(26, 129);
            prizePlaceNameLabel.Name = "prizePlaceNameLabel";
            prizePlaceNameLabel.Size = new Size(124, 30);
            prizePlaceNameLabel.TabIndex = 13;
            prizePlaceNameLabel.Text = "Place Name";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Font = new Font("Segoe UI", 15.75F);
            prizeAmountTextBox.Location = new Point(218, 178);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(188, 35);
            prizeAmountTextBox.TabIndex = 16;
            prizeAmountTextBox.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Location = new Point(26, 181);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(139, 30);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Font = new Font("Segoe UI", 15.75F);
            prizePercentageTextBox.Location = new Point(218, 281);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(188, 35);
            prizePercentageTextBox.TabIndex = 18;
            prizePercentageTextBox.Text = "0";
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Location = new Point(26, 284);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(167, 30);
            pricePercentageLabel.TabIndex = 17;
            pricePercentageLabel.Text = "Prize Percentage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 234);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 19;
            label4.Text = "- Or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 15.75F);
            createPrizeButton.Location = new Point(70, 342);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(281, 70);
            createPrizeButton.TabIndex = 20;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 424);
            Controls.Add(createPrizeButton);
            Controls.Add(label4);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(pricePercentageLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(prizePlaceNameLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(prizePlaceNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Prize Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberTextBox;
        private Label prizePlaceNumberLabel;
        private TextBox placeNameTextBox;
        private Label prizePlaceNameLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private TextBox prizePercentageTextBox;
        private Label pricePercentageLabel;
        private Label label4;
        private Button createPrizeButton;
    }
}