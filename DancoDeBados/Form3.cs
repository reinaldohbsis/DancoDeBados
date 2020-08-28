using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancoDeBados
{
    public partial class Form3 : Form
    {
        protected readonly int Id;
        protected Agenda agenda;

        public Form3(int id)
        {
            this.Id = id;
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
            {
                agenda = db.GetCollection<Agenda>().FindById(this.Id);
            }

            txt_id.Text = agenda.Id.ToString();
            txt_nome.Text = agenda.Nome;
            txt_email.Text = agenda.Email;
            txt_telefone.Text = agenda.Telefone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            agenda.Nome = txt_nome.Text;
            agenda.Telefone = txt_telefone.Text;
            agenda.Email = txt_email.Text;

            using (var db = new LiteDatabase("Filename = criandoUsandoDB"))
            {
                db.GetCollection<Agenda>().Update(agenda);
            }

            this.Close();
        }
    }
}
