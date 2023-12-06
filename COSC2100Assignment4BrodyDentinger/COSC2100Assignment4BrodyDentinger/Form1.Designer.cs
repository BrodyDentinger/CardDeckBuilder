namespace COSC2100Assignment4BrodyDentinger
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            addCustomButton = new Button();
            rankTextBox = new TextBox();
            suitTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            drawTextBox = new TextBox();
            dealButton = new Button();
            dealtListView = new ListView();
            label4 = new Label();
            label5 = new Label();
            deckListView = new ListView();
            viewDeckButton = new Button();
            shuffleDeckButton = new Button();
            resetButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addCustomButton);
            groupBox1.Controls.Add(rankTextBox);
            groupBox1.Controls.Add(suitTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Card";
            // 
            // addCustomButton
            // 
            addCustomButton.Location = new Point(202, 40);
            addCustomButton.Name = "addCustomButton";
            addCustomButton.Size = new Size(105, 46);
            addCustomButton.TabIndex = 4;
            addCustomButton.Text = "&Add Custom";
            toolTip2.SetToolTip(addCustomButton, "Add custom card button");
            addCustomButton.UseVisualStyleBackColor = true;
            addCustomButton.Click += addCustomButton_Click;
            // 
            // rankTextBox
            // 
            rankTextBox.Location = new Point(71, 61);
            rankTextBox.Name = "rankTextBox";
            rankTextBox.Size = new Size(125, 27);
            rankTextBox.TabIndex = 3;
            toolTip2.SetToolTip(rankTextBox, "Enter card rank here");
            // 
            // suitTextBox
            // 
            suitTextBox.Location = new Point(71, 34);
            suitTextBox.Name = "suitTextBox";
            suitTextBox.Size = new Size(125, 27);
            suitTextBox.TabIndex = 1;
            toolTip2.SetToolTip(suitTextBox, "Enter card suit here");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Rank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Suit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 161);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "Draw";
            // 
            // drawTextBox
            // 
            drawTextBox.Location = new Point(83, 159);
            drawTextBox.Name = "drawTextBox";
            drawTextBox.Size = new Size(125, 27);
            drawTextBox.TabIndex = 2;
            toolTip2.SetToolTip(drawTextBox, "Enter draw amount here");
            // 
            // dealButton
            // 
            dealButton.Location = new Point(214, 157);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(94, 29);
            dealButton.TabIndex = 3;
            dealButton.Text = "&Deal";
            toolTip2.SetToolTip(dealButton, "Deal button to draw cards");
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButton_Click;
            // 
            // dealtListView
            // 
            dealtListView.Location = new Point(18, 222);
            dealtListView.Name = "dealtListView";
            dealtListView.Size = new Size(290, 178);
            dealtListView.TabIndex = 5;
            toolTip2.SetToolTip(dealtListView, "Dealt cards show here");
            dealtListView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 199);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Cards Dealt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 13);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 6;
            label5.Text = "Deck";
            // 
            // deckListView
            // 
            deckListView.Location = new Point(340, 47);
            deckListView.Name = "deckListView";
            deckListView.Size = new Size(305, 353);
            deckListView.TabIndex = 7;
            toolTip2.SetToolTip(deckListView, "Cards still in deck show here");
            deckListView.UseCompatibleStateImageBehavior = false;
            // 
            // viewDeckButton
            // 
            viewDeckButton.Location = new Point(651, 52);
            viewDeckButton.Name = "viewDeckButton";
            viewDeckButton.Size = new Size(94, 29);
            viewDeckButton.TabIndex = 8;
            viewDeckButton.Text = "&View Deck";
            toolTip2.SetToolTip(viewDeckButton, "View deck button");
            viewDeckButton.UseVisualStyleBackColor = true;
            viewDeckButton.Click += viewDeckButton_Click;
            // 
            // shuffleDeckButton
            // 
            shuffleDeckButton.Location = new Point(651, 105);
            shuffleDeckButton.Name = "shuffleDeckButton";
            shuffleDeckButton.Size = new Size(94, 29);
            shuffleDeckButton.TabIndex = 9;
            shuffleDeckButton.Text = "&Shuffle";
            toolTip2.SetToolTip(shuffleDeckButton, "Shuffles deck");
            shuffleDeckButton.UseVisualStyleBackColor = true;
            shuffleDeckButton.Click += shuffleDeckButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(651, 158);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 10;
            resetButton.Text = "&Reset";
            toolTip2.SetToolTip(resetButton, "Resets game");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(651, 211);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 11;
            exitButton.Text = "&Exit";
            toolTip2.SetToolTip(exitButton, "Exit button");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = viewDeckButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new Size(766, 425);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(shuffleDeckButton);
            Controls.Add(viewDeckButton);
            Controls.Add(deckListView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dealtListView);
            Controls.Add(dealButton);
            Controls.Add(drawTextBox);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deck Builder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button addCustomButton;
        private TextBox rankTextBox;
        private TextBox suitTextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox drawTextBox;
        private Button dealButton;
        private ListView dealtListView;
        private Label label4;
        private Label label5;
        private ListView deckListView;
        private Button viewDeckButton;
        private Button shuffleDeckButton;
        private Button resetButton;
        private Button exitButton;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}