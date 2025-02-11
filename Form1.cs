namespace L1 {
    public partial class Form1 : Form {
        private static float xStart = 0;
        private static float yStart = 0;
        private static int quarter = 0;
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void CenterToQuarter() {
            switch (quarter) {
                case 0:
                    xStart = (this.ClientSize.Width / 2);
                    yStart = (this.ClientSize.Height / 2);
                    break;
                case 1:
                    xStart = (this.ClientSize.Width / 4) * 3;
                    yStart = (this.ClientSize.Height / 4);
                    break;
                case 2:
                    xStart = (this.ClientSize.Width / 4);
                    yStart = (this.ClientSize.Height / 4);
                    break;
                case 3:
                    xStart = (this.ClientSize.Width / 4);
                    yStart = (this.ClientSize.Height / 4) * 3;
                    break;
                case 4:
                    xStart = (this.ClientSize.Width / 4) * 3;
                    yStart = (this.ClientSize.Height / 4) * 3;
                    break;
                default:
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e) {
            Color blue = Color.FromArgb(255, 0, 0, 255);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen bluePen = new Pen(blue) { Width = 3 };
            Pen blackPen = new Pen(black) { Width = 1 };
            e.Graphics.DrawLine(blackPen, (this.ClientSize.Width / 2), 0, (this.ClientSize.Width / 2), this.ClientSize.Height);
            e.Graphics.DrawLine(blackPen, 0, (this.ClientSize.Height / 2), this.ClientSize.Width, (this.ClientSize.Height / 2));

            float scaleX = (float)numericUpDown2.Value;
            float scaleY = (float)numericUpDown2.Value;
            
            int d1 = 100;
            int d2 = 150;
            float p1x = 0;
            float p2x = 0 + d2 / 2;
            float p3x = 0;
            float p4x = 0 - d2 / 2;
            float p1y = 0 + d1 / 2;
            float p2y = 0;
            float p3y = 0 - d1 / 2;
            float p4y = 0;

            double angle = (double)numericUpDown1.Value;
            double radianAngle = (angle * Math.PI) / 180;
            
            CenterToQuarter();
            
            PointF[] TransformedRhombus = [
                new PointF(((float)(Math.Cos(radianAngle) * p1x - Math.Sin(radianAngle) * p1y) * scaleX) + xStart, ((float)(Math.Sin(radianAngle) * p1x + Math.Cos(radianAngle) * p1y) * scaleY) + yStart), //vert
                new PointF(((float)(Math.Cos(radianAngle) * p2x - Math.Sin(radianAngle) * p2y) * scaleX) + xStart, ((float)(Math.Sin(radianAngle) * p2x + Math.Cos(radianAngle) * p2y) * scaleY) + yStart), //hor
                new PointF(((float)(Math.Cos(radianAngle) * p3x - Math.Sin(radianAngle) * p3y) * scaleX) + xStart, ((float)(Math.Sin(radianAngle) * p3x + Math.Cos(radianAngle) * p3y) * scaleY) + yStart), //vert
                new PointF(((float)(Math.Cos(radianAngle) * p4x - Math.Sin(radianAngle) * p4y) * scaleX) + xStart, ((float)(Math.Sin(radianAngle) * p4x + Math.Cos(radianAngle) * p4y) * scaleY) + yStart) //hor
            ];
            e.Graphics.DrawPolygon(bluePen, TransformedRhombus);
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            this.Invalidate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            this.Invalidate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
            this.Invalidate();
        }

        private void quart1Btn_Click(object sender, EventArgs e) {
            quarter = 1;
            this.Invalidate();
        }
        private void quart2Btn_Click(object sender, EventArgs e) {
            quarter = 2;
            this.Invalidate();
        }
        private void quart3Btn_Click(object sender, EventArgs e) {
            quarter = 3;
            this.Invalidate();
        }
        private void quart4Btn_Click(object sender, EventArgs e) {
            quarter = 4;
            this.Invalidate();
        }

        private void centerBtn_Click(object sender, EventArgs e) {
            quarter = 0;
            this.Invalidate();
        }
    }
}
