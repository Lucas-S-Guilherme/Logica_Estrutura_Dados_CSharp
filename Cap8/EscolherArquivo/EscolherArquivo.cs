using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolherArquivo
{
    public class EscolherArquivo
    {
        public static string ObterCaminho()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*"; // Filtre os tipos de arquivos conforme necessário

            DialogResult result = openFileDialog.ShowDialog();

            string caminhoDoArquivo = "Nenhum arquivo selecionado.";

            if (result == DialogResult.OK)
            {
                caminhoDoArquivo = openFileDialog.FileName;

                return caminhoDoArquivo;
            }
            else
            {
                return caminhoDoArquivo;
            }

            

        }
    }
}
