using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Local de informações: http://theclub.com.br/Restrito/Revistas/201208/ling1208.aspx

namespace Classes_eObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto
            Socio soc = new Socio();

            //Inserindo atributos
            soc.Nome = "Amaury Huerb";
            soc.Rg = "xxxxxxx-x";
            soc.Cpf = "620.780.xxx-xx";
            soc.Nascimento = DateTime.Parse("28/01/1989");
            soc.Telefone = "(92) 98856-30xx";
            soc.Endereco = "Rua Dr. Mxxxxx nº:350";

            //Invocando métodos
            soc.Cadastrar();
            if (soc.ConfirmarCadastro(1))
                MessageBox.Show("Cadastro Confirmado!");
            if (soc.ValidarSocio(1))
                MessageBox.Show("Socio Validado!");
            soc.Alterar();
        }
    }
}
