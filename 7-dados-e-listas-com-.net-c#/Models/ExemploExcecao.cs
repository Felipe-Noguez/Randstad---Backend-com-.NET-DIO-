using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_dados_e_listas_com_.net_c_.Models
{
    public class ExemploExcecao
    {
        public void metodo1()
        {
            try
            {
                metodo2();
            }
            catch (Exception ex)
            {
                // Captura a exceção e exibe uma mensagem personalizada
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {
                // Bloco finally é executado sempre, independentemente de uma exceção ter sido lançada ou não
                Console.WriteLine("Execução finalizada.");
            }
        }

        public void metodo2()
        {
            metodo3();
        }
        public void metodo3()
        {
            metodo4();
        }
        public void metodo4()
        {
            throw new Exception("Exceção lançada no método 4");
        }
    }
}