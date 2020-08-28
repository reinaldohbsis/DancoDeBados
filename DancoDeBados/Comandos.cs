using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancoDeBados
{
    public class Comandos
    {
        public static void Adicionar(string nome,string email,string telefone)
        {
            var agenda = new Agenda()
            {
                Email = email,
                Nome = nome,
                Telefone = telefone

            };

            using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
            {
                db.GetCollection<Agenda>().Insert(agenda);
            }
        }

        public static void Apagar()
        {

        }

        public static void Consultar()
        {
            //using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
            //{
            //    var agendas = db.GetCollection<Agenda>().FindAll().ToList();

            //    grid_um.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    grid_um.DataSource = agendas;

            //}
        }

        //public static void Carregar(int id, string iD, string nome, string email, string telefone)
        //{
        //    using (var db = new LiteDatabase("Filename=criandoUsandoDB"))
        //    {
        //        agenda = db.GetCollection<Agenda>().FindById(id);
        //    }

        //    txt_id.Text = agenda.Id.ToString();
        //    txt_nome.Text = agenda.Nome;
        //    txt_email.Text = agenda.Email;
        //    txt_telefone.Text = agenda.Telefone;
        //}
    }
}
