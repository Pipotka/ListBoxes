namespace ListBoxes
{
    partial class ListBoxes
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
            LeftListBox = new ListBox();
            RightListBox = new ListBox();
            ButtonMoveToTheRight = new Button();
            ButtonMoveAllToTheRight = new Button();
            ButtonMoveAllToTheLeft = new Button();
            ButtonMoveToTheLeft = new Button();
            SuspendLayout();
            // 
            // LeftListBox
            // 
            LeftListBox.AllowDrop = true;
            LeftListBox.FormattingEnabled = true;
            LeftListBox.ItemHeight = 15;
            LeftListBox.Items.AddRange(new object[] { "A", "B", "C", "D", "F", "G", "E" });
            LeftListBox.Location = new Point(12, 25);
            LeftListBox.Name = "LeftListBox";
            LeftListBox.Size = new Size(139, 184);
            LeftListBox.TabIndex = 0;
            LeftListBox.DragDrop += listBoxLeft_DragDrop;
            LeftListBox.DragEnter += listBoxLeft_DragEnter;
            LeftListBox.MouseDown += listBoxLeft_MouseDown;
            // 
            // RightListBox
            // 
            RightListBox.AllowDrop = true;
            RightListBox.FormattingEnabled = true;
            RightListBox.ItemHeight = 15;
            RightListBox.Items.AddRange(new object[] { "Q", "S", "X", "Z", "P", "O" });
            RightListBox.Location = new Point(233, 25);
            RightListBox.Name = "RightListBox";
            RightListBox.Size = new Size(139, 184);
            RightListBox.TabIndex = 1;
            RightListBox.DragDrop += listBoxRight_DragDrop;
            RightListBox.DragEnter += listBoxRight_DragEnter;
            RightListBox.MouseDown += listBoxRight_MouseDown;
            // 
            // ButtonMoveToTheRight
            // 
            ButtonMoveToTheRight.Location = new Point(173, 40);
            ButtonMoveToTheRight.Name = "ButtonMoveToTheRight";
            ButtonMoveToTheRight.Size = new Size(38, 25);
            ButtonMoveToTheRight.TabIndex = 2;
            ButtonMoveToTheRight.Text = ">";
            ButtonMoveToTheRight.UseVisualStyleBackColor = true;
            ButtonMoveToTheRight.Click += this.ButtonMoveToTheRight_Click;
            // 
            // ButtonMoveAllToTheRight
            // 
            ButtonMoveAllToTheRight.Location = new Point(173, 83);
            ButtonMoveAllToTheRight.Name = "ButtonMoveAllToTheRight";
            ButtonMoveAllToTheRight.Size = new Size(38, 25);
            ButtonMoveAllToTheRight.TabIndex = 3;
            ButtonMoveAllToTheRight.Text = ">>";
            ButtonMoveAllToTheRight.UseVisualStyleBackColor = true;
            ButtonMoveAllToTheRight.Click += this.ButtonMoveAllToTheRight_Click;
            // 
            // ButtonMoveAllToTheLeft
            // 
            ButtonMoveAllToTheLeft.Location = new Point(173, 125);
            ButtonMoveAllToTheLeft.Name = "ButtonMoveAllToTheLeft";
            ButtonMoveAllToTheLeft.Size = new Size(38, 25);
            ButtonMoveAllToTheLeft.TabIndex = 4;
            ButtonMoveAllToTheLeft.Text = "<<";
            ButtonMoveAllToTheLeft.UseVisualStyleBackColor = true;
            ButtonMoveAllToTheLeft.Click += this.ButtonMoveAllToTheLeft_Click;
            // 
            // ButtonMoveToTheLeft
            // 
            ButtonMoveToTheLeft.Location = new Point(173, 166);
            ButtonMoveToTheLeft.Name = "ButtonMoveToTheLeft";
            ButtonMoveToTheLeft.Size = new Size(38, 25);
            ButtonMoveToTheLeft.TabIndex = 5;
            ButtonMoveToTheLeft.Text = "<";
            ButtonMoveToTheLeft.UseVisualStyleBackColor = true;
            ButtonMoveToTheLeft.Click += this.ButtonMoveToTheLeft_Click;
            // 
            // ListBoxes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 226);
            Controls.Add(ButtonMoveToTheLeft);
            Controls.Add(ButtonMoveAllToTheLeft);
            Controls.Add(ButtonMoveAllToTheRight);
            Controls.Add(ButtonMoveToTheRight);
            Controls.Add(RightListBox);
            Controls.Add(LeftListBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ListBoxes";
            Text = "Window";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LeftListBox;
        private ListBox RightListBox;
        private Button ButtonMoveToTheRight;
        private Button ButtonMoveAllToTheRight;
        private Button ButtonMoveAllToTheLeft;
        private Button ButtonMoveToTheLeft;
    }
}
