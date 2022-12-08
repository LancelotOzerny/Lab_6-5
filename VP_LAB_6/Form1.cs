using System;
using System.Windows.Forms;

namespace VP_LAB_6
{
    public partial class Form1 : Form
    {
        // Таймер
        Timer timer;
        
        // Угол увеличивается, уменьшается или стоит на месте
        enum ValueState { Minus = -1, Stay = 0, Plus = 1 };
        ValueState state;

        /// <summary>
        /// Конструктор формы - инициализация компонентов
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();

            timer.Interval = 1;
            timer.Tick += Update;
            timer.Start();
        }

        /// <summary>
        /// Нажатие на кнопки мыыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Нажатие на ЛКМ
            if (e.Button == MouseButtons.Left)
            {
                state = ValueState.Minus;
            }

            // Нажатие на ПКМ
            if (e.Button == MouseButtons.Right)
            {
                state = ValueState.Plus;
            }
        }

        /// <summary>
        /// Отжатие клавиши мыши
        /// </summary>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            state = ValueState.Stay;
        }

        /// <summary>
        /// Логика самой программы которая вызывается каждый тик таймера
        /// </summary>
        private void Update(object sender, EventArgs e)
        {
            if (state == ValueState.Minus)
            {
                myElement1.Value--;
            }

            if (state == ValueState.Plus)
            {
                myElement1.Value++;
            }

            label_AngleValue.Text = myElement1.Value.ToString();
        }
    }
}
