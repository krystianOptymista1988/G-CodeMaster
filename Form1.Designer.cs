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
            lbBigestCircle.AutoSize = true;
            lbBigestCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbBigestCircle.ForeColor = Color.Green;
            lbBigestCircle.Location = new Point(38, 53);
            lbBigestCircle.Name = "lbBigestCircle";
            lbBigestCircle.Size = new Size(321, 25);
            lbBigestCircle.TabIndex = 0;
            lbBigestCircle.Text = "Podaj średnicę większego koła [mm]";
            // 
            // tbLargeCircle
            // 
            tbLargeCircle.BackColor = SystemColors.InactiveCaptionText;
            tbLargeCircle.ForeColor = Color.DarkGreen;
            tbLargeCircle.Location = new Point(365, 53);
            tbLargeCircle.Name = "tbLargeCircle";
            tbLargeCircle.Size = new Size(166, 31);
            tbLargeCircle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(604, 56);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 2;
            label1.Text = "Podaj średnicę mniejszego koła [mm]";
            // 
            // tbSmallerCircle
            // 
            tbSmallerCircle.BackColor = SystemColors.InfoText;
            tbSmallerCircle.ForeColor = Color.DarkGreen;
            tbSmallerCircle.Location = new Point(939, 53);
            tbSmallerCircle.Name = "tbSmallerCircle";
            tbSmallerCircle.Size = new Size(166, 31);
            tbSmallerCircle.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(54, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1244, 741);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnGenerateCode
            // 
            btnGenerateCode.BackColor = SystemColors.Desktop;
            btnGenerateCode.FlatAppearance.BorderColor = Color.Green;
            btnGenerateCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateCode.ForeColor = Color.DarkGreen;
            btnGenerateCode.Image = (Image)resources.GetObject("btnGenerateCode.Image");
            btnGenerateCode.Location = new Point(244, 131);
            btnGenerateCode.Name = "btnGenerateCode";
            btnGenerateCode.Size = new Size(228, 47);
            btnGenerateCode.TabIndex = 5;
            btnGenerateCode.Text = "Generuj G-CODE";
            btnGenerateCode.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGenerateCode.UseVisualStyleBackColor = false;
            btnGenerateCode.Click += btnGenerateCode_Click;
            // 
            // btnDrawing
            // 
            btnDrawing.BackColor = SystemColors.Desktop;
            btnDrawing.FlatAppearance.BorderColor = Color.Green;
            btnDrawing.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDrawing.ForeColor = Color.DarkGreen;
            btnDrawing.Image = (Image)resources.GetObject("btnDrawing.Image");
            btnDrawing.Location = new Point(852, 131);
            btnDrawing.Name = "btnDrawing";
            btnDrawing.Size = new Size(228, 47);
            btnDrawing.TabIndex = 6;
            btnDrawing.Text = "Rysuj własny wzór";
            btnDrawing.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDrawing.UseVisualStyleBackColor = false;
            btnDrawing.Click += btnDrawing_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InfoText;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.DarkGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(544, 131);
            button2.Name = "button2";
            button2.Size = new Size(228, 47);
            button2.TabIndex = 7;
            button2.Text = "Wyczyść Tablice";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.ActiveCaptionText;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.ForeColor = Color.Green;
            richTextBox1.Location = new Point(1377, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(590, 817);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = AnchorStyles.Bottom;
            btnSaveFile.BackColor = Color.DarkGreen;
            btnSaveFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveFile.ForeColor = SystemColors.ButtonHighlight;
            btnSaveFile.Image = (Image)resources.GetObject("btnSaveFile.Image");
            btnSaveFile.Location = new Point(1730, 904);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(187, 47);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.Text = "Zapisz w pliku";
            btnSaveFile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(1562, 27);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 10;
            label2.Text = "WYGENEROWANY G-CODE";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2016, 989);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "G-Code Master";
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
