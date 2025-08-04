using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_tuplas_operador_ternario_e_descontrucao_de_um_objeto_c_.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            { 
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());

            } catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
                return (false, Array.Empty<string>(), 0);
            }
            // var tuplas = linhas.Select(linha =>
            // {
            //     var partes = linha.Split(';');
            //     return (Id: int.Parse(partes[0]), Nome: partes[1], Sobrenome: partes[2]);
            // }).ToList();
        }
    }
}