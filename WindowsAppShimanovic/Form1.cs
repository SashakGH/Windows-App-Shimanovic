using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppShimanovic
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonChangeText_Click(object sender, EventArgs e)
        {
            button1.Text = "Новый текст кнопки";
        }
        private void buttonChangeRandomColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            Box.Select(6, 6);
            Box.ForeColor = randomColor;
        }
    }
}
