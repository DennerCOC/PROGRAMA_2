using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA_2
{
    public partial class Pomodori : Form
    {
        public Pomodori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tempo TempoForm = new Tempo();
            TempoForm.ShowDialog();
        }
    }
}
