using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            if(textBox_Login.Text == "Тетяна" && textBox_Password.Text == "123")
            {
                MessageBox.Show("Привіт, Тетяна");
                label_OK.BackColor = Color.Green;
            }
            else if(textBox_Login.Text == "" || textBox_Login.Text == "Введіть логін")
            {
                MessageBox.Show("Введіть логін");
                label_OK.BackColor = Color.Red;
            }
            else if (textBox_Password.Text == "" || textBox_Password.Text == "Введіть пароль")
            {
                MessageBox.Show("Введіть пароль");
                label_OK.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Лонін або пароль введений неправильно");
                label_OK.BackColor = Color.Red;
                textBox_Login.Text = "";
                textBox_Password.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
