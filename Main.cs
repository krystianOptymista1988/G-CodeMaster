namespace G_CodeMaster
{
    using System.Drawing;
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        private bool isDrawing;
        private int startX, startY;
        private Bitmap drawingBitmap;
        private Bitmap drawingBitmap2;
        private Graphics drawingGraphics;
        private StringBuilder gcode;
        private string gcode2;
        private Point? startPoint = null;
        private Point? endPoint = null;

        public Main()
        {
            InitializeComponent();
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            drawingBitmap2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap2);
            drawingGraphics.Clear(Color.Black);
            pictureBox1.Image = drawingBitmap2;

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;

            gcode = new StringBuilder();
            gcode.AppendLine("; Generated G-Code");
            gcode.AppendLine("G21 ; U¿ycie jednostek metrycznych");
            gcode.AppendLine("G90 ; Pozycjonowanie bezwzglêdne");
            gcode.AppendLine("G1 F1000 ; Ustawienie prêdkoœci ciêcia");
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startX = e.X;
                startY = e.Y;
                gcode.AppendLine($"G0 X{startX} Y{startY}");
                gcode.AppendLine("M3 S1000 ; W³¹czenie lasera");
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                drawingGraphics.DrawLine(Pens.DarkGreen, startX, startY, e.X, e.Y);
                startX = e.X;
                startY = e.Y;
                pictureBox1.Invalidate(); 
                gcode.AppendLine($"G1 X{startX} Y{startY}");
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                gcode.AppendLine("M5 ; Wy³¹czenie lasera");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            richTextBox1.Text = null;
            tbLargeCircle.Text = null;
            tbSmallerCircle.Text = null;
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLargeCircle.Text) && !string.IsNullOrWhiteSpace(tbSmallerCircle.Text))
            {
                float largeCircle = float.Parse(tbLargeCircle.Text);
                float smallerCircle = float.Parse(tbSmallerCircle.Text);

                gcode = new StringBuilder();

                drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                drawingGraphics = Graphics.FromImage(drawingBitmap);
                drawingGraphics.Clear(Color.Black);

                gcode.AppendLine(GenerateGCode(largeCircle, smallerCircle));
                float centerX = pictureBox1.Width / 2;
                float centerY = pictureBox1.Height / 2;
                float maxRadius = Math.Min(centerX, centerY);
                float largerRadius = largeCircle / 2 * maxRadius / Math.Max(largeCircle, smallerCircle);
                float smallerRadius = smallerCircle / 2 * maxRadius / Math.Max(largeCircle, smallerCircle);

                drawingGraphics.DrawEllipse(Pens.Red, centerX - largerRadius, centerY - largerRadius, 2 * largerRadius, 2 * largerRadius);
                drawingGraphics.DrawEllipse(Pens.Blue, centerX - smallerRadius, centerY - smallerRadius, 2 * smallerRadius, 2 * smallerRadius);
                pictureBox1.Image = drawingBitmap;
               richTextBox1.Text = gcode.ToString();
            }
            else
            {
                richTextBox1.Text = gcode.ToString();
            }
        }

        private string GenerateGCode(float largerDiameter, float smallerDiameter)
        {
            float centerX = 0;
            float centerY = 0;

            float largerRadius = largerDiameter / 2;
            float smallerRadius = smallerDiameter / 2;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("G21 ; U¿ycie jednostek metrycznych");
            sb.AppendLine("G90 ; Pozycjonowanie bezwzglêdne");
            sb.AppendLine("G1 F1000 ; Ustawienie prêdkoœci ciêcia");

            sb.AppendLine($"G0 X{centerX + largerRadius} Y{centerY}");
            sb.AppendLine("M3 S1000 ; W³¹czenie lasera");
            sb.AppendLine($"G2 X{centerX + largerRadius} Y{centerY} I{-largerRadius} J0");
            sb.AppendLine("M5 ; Wy³¹czenie lasera");

            sb.AppendLine($"G0 X{centerX + smallerRadius} Y{centerY}");
            sb.AppendLine("M3 S1000 ; W³¹czenie lasera");
            sb.AppendLine($"G2 X{centerX + smallerRadius} Y{centerY} I{-smallerRadius} J0");
            sb.AppendLine("M5 ; Wy³¹czenie lasera");

            sb.AppendLine("G0 X0 Y0 ; Powrót do punktu startowego");

            return sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "G-Code Files (*.nc)|*.nc|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "nc";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filePath, gcode.ToString());
                MessageBox.Show("G-Code zosta³ zapisany.", "Zapisywanie G-Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
