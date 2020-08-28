using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancoDeBados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
            {
                var agendas = db.GetCollection<Agenda>().FindAll().ToList();

                grid_um.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid_um.DataSource = agendas;
                
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(grid_um.SelectedRows[0].Cells[0].Value.ToString(), out id);

            Form3 form3 = new Form3(id);
            form3.ShowDialog(); 
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(grid_um.SelectedRows[0].Cells[0].Value.ToString(), out id);

            if (id > 0)
            {
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new LiteDatabase("Filename = criandoUsandoDB"))
                    {
                        db.GetCollection<Agenda>().Delete(id);
                    }
                }
            }
        }
    }
}
