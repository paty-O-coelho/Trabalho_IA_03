using System.IO;
using System.Text;

namespace Trabalho_IA_03.AGClass
{
    public static class GeradorDeCoordenadas
    {
        /// <summary>
        /// Gera as coordenadas a partir de um arquivo.
        /// </summary>
        public static void GerarCoordenadas()
        {
            var arquivo = "coordenadas.dat";

            using (var fluxoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo, Encoding.UTF8))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    ConverterStringParaCoordenadas(linha);
                }
            }
        }

        /// <summary>
        /// Converte linha do arquivo em coordenadas x e y.
        /// </summary>
        /// <param name="linha">Linha atual do arquivo.</param>
        private static void ConverterStringParaCoordenadas(string linha)
        {
            var campos = linha.Split(',');

            var x = int.Parse(campos[0]);
            var y = int.Parse(campos[1]);

            TablePoints.AddPoint(x, y);
        }
    }
}
