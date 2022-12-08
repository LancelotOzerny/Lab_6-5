using System;
using System.Drawing;
using System.Windows.Forms;

namespace VP_LAB_6
{
    public partial class MyElement : UserControl
    {
        private Timer timer = new Timer();
        private Pen borderPen = new Pen(Brushes.Black, 2);
        private Pen linePen = new Pen(Brushes.Black, 2);
        private int mRadius;
        private Point mCenter;

        // Угол поворота
        int angle;

        /// <summary>
        /// Свойство, которое позволяет получить или изменить угол поворота
        /// </summary>
        public int Value
        {
            get => angle;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                if (value > 300)
                {
                    value = 300;
                }

                angle = value;
            }
        }

        public MyElement()
        {
            InitializeComponent();

            timer.Interval = 30;
            timer.Tick += Update;
            timer.Start();
        }
        
        /// <summary>
        /// Перерисовка компонента
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Холст для рисования
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //Рисование круга
            g.DrawEllipse(borderPen, new Rectangle(mCenter.X - mRadius, mCenter.Y -
            mRadius, mRadius * 2, mRadius * 2));

            //Рисование Засечек
            for (double angle = 0; angle < 2 * Math.PI; angle += Math.PI / 18.0f)
            {
                double a = angle - Math.PI / 2;
                g.DrawLine(borderPen, (float)(mRadius * Math.Cos(a)) + mCenter.X,
                (float)(mRadius * Math.Sin(a)) + mCenter.Y,
                (float)((mRadius - 5) * Math.Cos(a)) + mCenter.X,
                (float)((mRadius - 5) * Math.Sin(a)) + mCenter.Y);
            }

            // Угол тумблера
            float sa = -(float)(Math.PI * angle / 180) ;

            // Тумблер
            g.DrawLine(linePen,
            (float)(-(20) * Math.Cos(sa)) + mCenter.X,
            (float)(-(20) * Math.Sin(sa)) + mCenter.Y,
            (float)((mRadius - 10) * Math.Cos(sa)) + mCenter.X,
            (float)((mRadius - 10) * Math.Sin(sa)) + mCenter.Y);
        }

        /// <summary>
        /// Изменение размера окна (элемента)
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //Определение координат центра
            mCenter.X = ClientRectangle.Width / 2;
            mCenter.Y = ClientRectangle.Height / 2;

            //Определение радиуcа
            if (mCenter.X > mCenter.Y)
                mRadius = mCenter.Y;
            else
                mRadius = mCenter.X;

            mRadius -= 3;
        }

        /// <summary>
        /// Логика работы компонента
        /// </summary>
        private void Update(object sender, EventArgs e)
        {
            Invalidate();
            
            // Убрать мерцание
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );
        }
    }
}