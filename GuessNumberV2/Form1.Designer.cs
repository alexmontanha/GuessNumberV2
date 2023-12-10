namespace GuessNumberV2
{
    partial class Form1
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
            label1 = new Label();
            lblMessageTextBox = new Label();
            textBoxInput = new TextBox();
            btnAction = new Button();
            lblGameMessage = new Label();
            lblPlayerName = new Label();
            lblPoints = new Label();
            lblLastGuess = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "Guess The Number";
            // 
            // lblMessageTextBox
            // 
            lblMessageTextBox.AutoSize = true;
            lblMessageTextBox.Location = new Point(276, 112);
            lblMessageTextBox.Name = "lblMessageTextBox";
            lblMessageTextBox.Size = new Size(38, 15);
            lblMessageTextBox.TabIndex = 1;
            lblMessageTextBox.Text = "label2";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(276, 130);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(215, 23);
            textBoxInput.TabIndex = 2;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(509, 130);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(75, 23);
            btnAction.TabIndex = 3;
            btnAction.Text = "button1";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // lblGameMessage
            // 
            lblGameMessage.AutoSize = true;
            lblGameMessage.Location = new Point(280, 172);
            lblGameMessage.Name = "lblGameMessage";
            lblGameMessage.Size = new Size(0, 15);
            lblGameMessage.TabIndex = 4;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(279, 79);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(39, 15);
            lblPlayerName.TabIndex = 5;
            lblPlayerName.Text = "Player";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(280, 187);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(0, 15);
            lblPoints.TabIndex = 6;
            // 
            // lblLastGuess
            // 
            lblLastGuess.AutoSize = true;
            lblLastGuess.Location = new Point(599, 133);
            lblLastGuess.Name = "lblLastGuess";
            lblLastGuess.Size = new Size(0, 15);
            lblLastGuess.TabIndex = 7;
            // 
            // Form1
            // 
            AcceptButton = btnAction;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLastGuess);
            Controls.Add(lblPoints);
            Controls.Add(lblPlayerName);
            Controls.Add(lblGameMessage);
            Controls.Add(btnAction);
            Controls.Add(textBoxInput);
            Controls.Add(lblMessageTextBox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess The Number V 2.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMessageTextBox;
        private TextBox textBoxInput;
        private Button btnAction;
        private Label lblGameMessage;
        private Label lblPlayerName;
        private Label lblPoints;
        private Label lblLastGuess;
    }
}
