using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Pilha
    {
        int tamanho;
        int topo;
        object[] vetor;

        Pilha(int tam)
        {
            topo = -1; //controla a posição do elemento que ocupa o topo da pilha, iniciado em -1 para indicar que a pilha inicialmente está vazia
            tamanho = tam;//define o tamanho do vetor
            vetor = new object[tam];//contêiner de dados
        }

        public bool PilhaVazia()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        public bool PilhaCheia()
        {
            if (topo == tamanho - 1)
                return true;
            else
                return false;
        }

        public void Empilhar(object elemento)
        {
            if (!PilhaCheia())
            {
                topo++;//incrementa antes, é importante, porque o valor inicial de topo é -1, e a posição inicial de um vetor é 0
                vetor[topo] = elemento;//elemento inserido no topo da pilha (FIFO)
            }
            else
            {
                Console.WriteLine("Pilha Cheia!");
            }
        }

        public object Desempilhar()
        {
            object valorDesempilhado = null;
            if (PilhaVazia())
            {
                Console.WriteLine("Pilha Vazia");
            }
            else
            {
                valorDesempilhado = vetor[topo];
                topo--;
            }

            return valorDesempilhado;//retorna valor removido
        }

        public object elementoTopo()
        {
            if (PilhaVazia())
            {
                Console.WriteLine("Pilha Vazia");
            }
            else
                return vetor[topo];
            return null;
        }

        public void MostrarPilha()
        {
            int i;
            string mensagem = "";
            if (!PilhaVazia())
            {
                for (i = topo; i >= 0; i--)
                {
                    mensagem = mensagem + vetor[i] + " | ";
                }
            }
            else
            {
                mensagem = "Pilha Vazia";
            }
            Console.WriteLine(mensagem);
        }


    }
}
