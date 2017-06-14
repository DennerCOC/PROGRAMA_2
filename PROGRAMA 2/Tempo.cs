using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROGRAMA_2
{
    public partial class Tempo : Form
    {
        public Tempo()
        {
            InitializeComponent();
        }
        private void Tempo_Load(object sender, EventArgs e)
        {
            //Adicionar 2 minutos ao DateTimerPicker para facilitar os testes
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(2);
        }
        private void btnIniciarContagem_Click_1(object sender, EventArgs e)
        {
            //Usuário deve escolher uma data maior que agora
            if (dateTimePicker1.Value > DateTime.Now)
            {
                Contagem contagemForm = new Contagem(dateTimePicker1.Value);
                contagemForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Escolha uma data maior que agora", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
