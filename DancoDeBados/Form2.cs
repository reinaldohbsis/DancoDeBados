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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //var agenda = new Agenda()
            //{
            //    Email = txt_email.Text,
            //    Nome = txt_nome.Text,
            //    Telefone = txt_telefone.Text

            //};

            //using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
            //{
            //    db.GetCollection<Agenda>().Insert(agenda);
            //}

            Comandos.Adicionar(txt_nome.Text, txt_email.Text, txt_telefone.Text);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
