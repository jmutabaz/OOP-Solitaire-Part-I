using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CalculationGame : Form
    {
        private int _ticks; 

        public CalculationGame()
        {
            InitializeComponent();
            timer1.Start(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = "Game Time:" + " " + _ticks.ToString();

            if (_ticks == 2000)
            {
                this.Text = "Game Over";
                Application.Exit(); 
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Calculation Solitaire"; 
        }

        private void Rules_Game_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play Calculation Solitaire" + "\n" +
                            "Rules:" + "\n" +
                            "1) Don't lose" + "\n" +
                            "2) Dont be afraid to stack" + "\n" +
                            "..........."); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void CalculationGame_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }
    }
}
