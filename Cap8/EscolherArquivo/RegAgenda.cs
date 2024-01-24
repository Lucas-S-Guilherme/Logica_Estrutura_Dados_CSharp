using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolherArquivo
{
    public class RegAgenda
    {
        
            private string _nome;
            private string end;
            private string tel;

            public RegAgenda(string nome, string end, string tel)
            {
                _nome = nome;
                this.end = end;
                this.tel = tel;
            }

            public string MostrarNome()
            {
                return _nome;
            }

            public string MostrarEndereco()
            {
                return end;
            }

            public string MostrarTelefone()
            {
                return tel;
            }
        
    }
}
