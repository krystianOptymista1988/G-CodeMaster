namespace G_CodeMaster
{
    using System.Drawing;
    using System;
    using System.Text;

    public partial class Main : Form
    {
        private bool isDrawing;
        private int startX, startY;
        private Bitmap drawingBitmap;
        private Bitmap drawingBitmap2;
        private Graphics drawingGraphics;
        private string gcode;
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
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (startPoint == null)
            {
                startPoint = new Point(e.X, e.Y);
            }
            else if (endPoint == null)
            {
                endPoint = new Point(e.X, e.Y);
                drawingGraphics.DrawLine(Pens.Black, startPoint.Value, endPoint.Value);
                pictureBox1.Invalidate(); // Aktualizacja obrazu
                startPoint = null;
                endPoint = null;
            }
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startX = e.X;
                startY = e.Y;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {

                drawingGraphics.DrawLine(Pens.DarkGreen, startX, startY, e.X, e.Y);
                startX = e.X;
                startY = e.Y;
                pictureBox1.Invalidate(); // Aktualizacja obrazu
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
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


                drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                drawingGraphics = Graphics.FromImage(drawingBitmap);
                drawingGraphics.Clear(Color.Black);

                gcode = GenerateGCode(largeCircle, smallerCircle);
                float centerX = pictureBox1.Width / 2;
                float centerY = pictureBox1.Height / 2;
                float maxRadius = Math.Min(centerX, centerY);
                float largerRadius = largeCircle / 2 * maxRadius / Math.Max(largeCircle, smallerCircle);
                float smallerRadius = smallerCircle / 2 * maxRadius / Math.Max(largeCircle, smallerCircle);

                drawingGraphics.DrawEllipse(Pens.Red, centerX - largerRadius, centerY - largerRadius, 2 * largerRadius, 2 * largerRadius);
                drawingGraphics.DrawEllipse(Pens.Blue, centerX - smallerRadius, centerY - smallerRadius, 2 * smallerRadius, 2 * smallerRadius);
                pictureBox1.Image = drawingBitmap;
            }
            else if (pictureBox1.Image == drawingBitmap2)
            {

                BitmapAsGCode(drawingBitmap2);
            }

            richTextBox1.Text = gcode;
        }


        private void BitmapAsGCode(Bitmap bitmap)
        {

            gcode = "; Generated G-Code\n";
            gcode += "G21 ; U¿ycie jednostek metrycznych\n";
            gcode += "G90 ; Pozycjonowanie bezwzglêdne\n";
            gcode += "G1 F1000 ; Ustawienie prêdkoœci ciêcia\n";
            
            
            int counter = 0;
            int yy = 0;
            int xx = 0;

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (pixelColor.ToArgb() == Color.DarkGreen.ToArgb())
                    {
                        float scaledX = (float)x / bitmap.Width * pictureBox1.Width;
                        float scaledY = (float)y / bitmap.Height * pictureBox1.Height;
                        if (xx + 50 < x || xx - 50 > x || yy +50 < y || yy - 50 > y)
                        {

                            gcode += $"G1 X{scaledX} Y{scaledY} \n";
                            xx = x;
                            yy = y;
                        }
                        counter++;
                        if(counter==1)
                        {
                            gcode += "M3 S1000 ; W³¹czenie lasera\n";

                        }
                      
                    }
                }
            }
            gcode += "M5 ; Wy³¹czenie lasera\n";
            gcode += "G0 X0 Y0 ; Powrót do punktu startowego\n";
            gcode += "; End of G-Code";
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
                System.IO.File.WriteAllText(filePath, gcode);
                MessageBox.Show("G-Code zosta³ zapisany.", "Zapisywanie G-Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        static string GenerateGCode(float largerDiameter, float smallerDiameter)
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
    }
}