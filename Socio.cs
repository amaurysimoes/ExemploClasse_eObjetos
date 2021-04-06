using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;//Adicionado para interagir com o form
using System.Threading.Tasks;

//Definida como Classe pública
namespace Classes_eObjetos
{
    public class Socio
    {
        //Construtor da classe
        public Socio()
        {
            //Vai enviar uma MessageBox lá para o form
            MessageBox.Show("Objesto Criado com sucesso!");
        }
        //Destrutor da classe
        ~Socio()
        {
        }
        //Atributos/Propriedades Privadas Encapsuladas
        private string nome;
        private string cpf;
        private string rg;
        private DateTime nascimento;
        private string telefone;
        private string endereco;

        //Atributos/Propriedades Públicas Encapsuladas
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public DateTime Nascimento
        //Não será public string porque DateTime já é recurso pré-definido
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        //Métodos públicos
        public void Cadastrar()
        {
            MessageBox.Show(string.Format("Cadastrando sócio...\r\nNome: {0}, - Rg: {1}, Cpf:{2}", nome, rg, cpf));
        }

        public void Confirmar()
        {
            var lblConfirma = "Finalizado operação";
        }
        
        public bool ConfirmarCadastro(int tipo)
        {
            if (tipo == 1)
                return true;
            else
                return true;
        }
        public bool ValidarSocio(int tipo)
        {
            if (tipo == 1)
                return true;
            else
                return true;
        }
        public void Alterar()
        {
            MessageBox.Show("Alterando sócio...");
        }
    }
}
