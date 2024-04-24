using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeatrVseDela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Theater(object sender, EventArgs e)
        {
            TheaterWindow theaterWindow = new TheaterWindow();
            theaterWindow.Show();
        }

        private void button_Repertuar(object sender, EventArgs e)
        {
            ReperuarWindows reperuarWindows = new ReperuarWindows();
            reperuarWindows.Show();
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {
            
        }

        private void button_Exit(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void button_instruction(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа познакомит вас с Театрами Коми и их репертуаром." +
                "Наведеите курсор на кнопку, чтобы узнать, что она делает.", "Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
