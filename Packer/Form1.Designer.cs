namespace Packer
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
            redBox = new PictureBox();
            greenBox = new PictureBox();
            blueBox = new PictureBox();
            alphaBox = new PictureBox();
            packedBox = new PictureBox();
            saveButton = new Button();
            clearButton = new Button();
            quitButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alphaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packedBox).BeginInit();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.BackgroundImage = Properties.Resources.red;
            redBox.BackgroundImageLayout = ImageLayout.Zoom;
            redBox.BorderStyle = BorderStyle.FixedSingle;
            redBox.Location = new Point(12, 12);
            redBox.Name = "redBox";
            redBox.Size = new Size(128, 128);
            redBox.SizeMode = PictureBoxSizeMode.Zoom;
            redBox.TabIndex = 0;
            redBox.TabStop = false;
            redBox.DragDrop += redBox_DragDrop;
            redBox.DragEnter += redBox_DragEnter;
            // 
            // greenBox
            // 
            greenBox.BackgroundImage = Properties.Resources.green;
            greenBox.BackgroundImageLayout = ImageLayout.Zoom;
            greenBox.BorderStyle = BorderStyle.FixedSingle;
            greenBox.Location = new Point(12, 146);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(128, 128);
            greenBox.SizeMode = PictureBoxSizeMode.Zoom;
            greenBox.TabIndex = 1;
            greenBox.TabStop = false;
            greenBox.DragDrop += greenBox_DragDrop;
            greenBox.DragEnter += greenBox_DragEnter;
            // 
            // blueBox
            // 
            blueBox.BackgroundImage = Properties.Resources.blue;
            blueBox.BackgroundImageLayout = ImageLayout.Zoom;
            blueBox.BorderStyle = BorderStyle.FixedSingle;
            blueBox.Location = new Point(12, 280);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(128, 128);
            blueBox.SizeMode = PictureBoxSizeMode.Zoom;
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            blueBox.DragDrop += blueBox_DragDrop;
            blueBox.DragEnter += blueBox_DragEnter;
            // 
            // alphaBox
            // 
            alphaBox.BackgroundImage = Properties.Resources.alpha;
            alphaBox.BackgroundImageLayout = ImageLayout.Zoom;
            alphaBox.BorderStyle = BorderStyle.FixedSingle;
            alphaBox.Location = new Point(12, 414);
            alphaBox.Name = "alphaBox";
            alphaBox.Size = new Size(128, 128);
            alphaBox.SizeMode = PictureBoxSizeMode.Zoom;
            alphaBox.TabIndex = 3;
            alphaBox.TabStop = false;
            alphaBox.DragDrop += alphaBox_DragDrop;
            alphaBox.DragEnter += alphaBox_DragEnter;
            // 
            // packedBox
            // 
            packedBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            packedBox.BackgroundImage = Properties.Resources.checkerboard;
            packedBox.BackgroundImageLayout = ImageLayout.Zoom;
            packedBox.BorderStyle = BorderStyle.FixedSingle;
            packedBox.Location = new Point(146, 12);
            packedBox.Name = "packedBox";
            packedBox.Size = new Size(530, 530);
            packedBox.SizeMode = PictureBoxSizeMode.Zoom;
            packedBox.TabIndex = 2;
            packedBox.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(520, 548);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save As...";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 548);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(601, 548);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 6;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(688, 583);
            Controls.Add(quitButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(redBox);
            Controls.Add(packedBox);
            Controls.Add(blueBox);
            Controls.Add(alphaBox);
            Controls.Add(greenBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Packer";
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)alphaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)packedBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox redBox;
        private PictureBox greenBox;
        private PictureBox blueBox;
        private PictureBox alphaBox;
        private PictureBox packedBox;
        private Button saveButton;
        private Button clearButton;
        private Button quitButton;
        private SaveFileDialog saveFileDialog1;
    }
}