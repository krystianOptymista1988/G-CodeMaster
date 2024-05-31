namespace G_CodeMaster
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lbBigestCircle = new Label();
            tbLargeCircle = new TextBox();
            label1 = new Label();
            tbSmallerCircle = new TextBox();
            pictureBox1 = new PictureBox();
            btnGenerateCode = new Button();
            btnDrawing = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            btnSaveFile = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbBigestCircle
            // 
            resources.ApplyResources(lbBigestCircle, "lbBigestCircle");
            lbBigestCircle.ForeColor = Color.Green;
            lbBigestCircle.Name = "lbBigestCircle";
            // 
            // tbLargeCircle
            // 
            tbLargeCircle.BackColor = SystemColors.InactiveCaptionText;
            resources.ApplyResources(tbLargeCircle, "tbLargeCircle");
            tbLargeCircle.ForeColor = Color.DarkGreen;
            tbLargeCircle.Name = "tbLargeCircle";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Green;
            label1.Name = "label1";
            // 
            // tbSmallerCircle
            // 
            tbSmallerCircle.BackColor = SystemColors.InfoText;
            resources.ApplyResources(tbSmallerCircle, "tbSmallerCircle");
            tbSmallerCircle.ForeColor = Color.DarkGreen;
            tbSmallerCircle.Name = "tbSmallerCircle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnGenerateCode
            // 
            btnGenerateCode.BackColor = SystemColors.Desktop;
            btnGenerateCode.FlatAppearance.BorderColor = Color.Green;
            resources.ApplyResources(btnGenerateCode, "btnGenerateCode");
            btnGenerateCode.ForeColor = Color.DarkGreen;
            btnGenerateCode.Name = "btnGenerateCode";
            btnGenerateCode.UseVisualStyleBackColor = false;
            btnGenerateCode.Click += btnGenerateCode_Click;
            // 
            // btnDrawing
            // 
            btnDrawing.BackColor = SystemColors.Desktop;
            btnDrawing.FlatAppearance.BorderColor = Color.Green;
            resources.ApplyResources(btnDrawing, "btnDrawing");
            btnDrawing.ForeColor = Color.DarkGreen;
            btnDrawing.Name = "btnDrawing";
            btnDrawing.UseVisualStyleBackColor = false;
            btnDrawing.Click += btnDrawing_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InfoText;
            button2.FlatAppearance.BorderColor = Color.Green;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.DarkGreen;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.BackColor = SystemColors.ActiveCaptionText;
            richTextBox1.ForeColor = Color.Green;
            richTextBox1.Name = "richTextBox1";
            // 
            // btnSaveFile
            // 
            resources.ApplyResources(btnSaveFile, "btnSaveFile");
            btnSaveFile.BackColor = Color.DarkGreen;
            btnSaveFile.ForeColor = SystemColors.ButtonHighlight;
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += button3_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Green;
            label2.Name = "label2";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label2);
            Controls.Add(btnSaveFile);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(btnDrawing);
            Controls.Add(btnGenerateCode);
            Controls.Add(pictureBox1);
            Controls.Add(tbSmallerCircle);
            Controls.Add(label1);
            Controls.Add(tbLargeCircle);
            Controls.Add(lbBigestCircle);
            Name = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBigestCircle;
        private TextBox tbLargeCircle;
        private Label label1;
        private TextBox tbSmallerCircle;
        private PictureBox pictureBox1;
        private Button btnGenerateCode;
        private Button btnDrawing;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button btnSaveFile;
        private Label label2;
    }
}
