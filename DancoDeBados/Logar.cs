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
    public partial class Logar : Form
    {
        public Logar()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            //var usuario = new Usuario()
            //{
            //    Login = txt_login.Text,
            //    Senhar = txt_senha.Text                
            //};
            
            using (var db = new LiteDatabase("Filename=UsuarioDB"))
            {
                var usuario = db.GetCollection<Usuario>().FindAll();
                var logar = usuario.Where(x => x.Login == txt_login.Text).FirstOrDefault();

                if (logar == null)
                {
                    MessageBox.Show("Usuário não encontrado");
                }
                else 
                {
                    var senha = usuario.Where(x => x.Senhar == txt_senha.Text).FirstOrDefault();
                    if (senha != null)   
                    {
                        
                        new Form1().ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                Login = txt_login.Text,
                Senhar = txt_senha.Text
            };

            using (var db = new LiteDatabase("Filename=UsuarioDB"))
            {
                db.GetCollection<Usuario>().Insert(usuario);
            }

            txt_login.Text = "";
            txt_senha.Text = "";

        }
    }
}
