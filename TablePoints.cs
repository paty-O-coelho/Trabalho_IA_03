using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_IA_03.AGClass;


namespace Trabalho_IA_03.AGClass
{
    public static class TablePoints
    {
        private static ArrayList X = new ArrayList();
        private static ArrayList Y = new ArrayList();
        private static double[,] tableDist; //tabela com distancias entre os pontos
        public static int pointCount = 0; //quantidade de pontos que inseri na tablea


        //adicionar um ponto
        public static void  addPoint(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            pointCount++;
            generateTable();

            
        }

        //gerar a tabela com os valores de distancia entre os dois pontos
        public static void generateTable()
        {
            tableDist = new double[pointCount, pointCount];

            for (int i = 0; i < pointCount; i++)//para X
            {
                for (int j = 0; j < pointCount; j++)//para y
                {
                    //Calculo de distancia entre dois pontos
                    tableDist[i, j] = Math.Sqrt(Math.Pow(int.Parse(X[i].ToString())
                                                          - int.Parse(X[j].ToString()), 2)
                                                          + Math.Pow(int.Parse(Y[i].ToString())
                                                          - int.Parse(Y[j].ToString()), 2));
                }
            }
            //Atualizar o tamanho do cromossomo
            //teste

            ConfigurationGA.sizeChromosome = pointCount;
            
        }

        //retornar a tabela de distancia


        public static double [,] getTableDist()
        {
            return tableDist;
        }


        //retornar a distancia entre dois pontos
        public static double getDist (int pointOne, int pointTwo)
        {
            return tableDist[pointOne, pointTwo];
        }


        //retornar quantidade de pontos na classe
        public static int Count()
        {
            return pointCount;
        }

        //Printar valores na tela
        public static string print()
        {
            string data =  string.Empty;

            for (int i=0; i< pointCount; i++)
            {
                for (int j=0; j<pointCount; j++)
                {
                    data += string.Format("{0:0.#}", double.Parse(tableDist[i, j].ToString())) + "                  ";
                }
                data += Environment.NewLine; //Barra N

            }
            data += Environment.NewLine + "--------------------------------------------------------" + Environment.NewLine;

            return data;

        } 


        //retirnar as coordenadas dentro do vetor
        /*AQUI ONDE DEVO MUDAR, POIS ESTOU PEGANDO AS COORDENADAS DOS CLICKS
         DEVO, OU CRIAR UM ARRAY COM OS SEUS VALORES OU IMPORTAR UM ARQUIVO */

        public static int [] getCoordinates (int point)
        {

            //aqui eu criei um array para pegar os clcicks de X e Y
            int[] arrayCoordinates = new int[2];

            arrayCoordinates[0] = int.Parse(X[point].ToString());
            arrayCoordinates[1] = int.Parse(Y[point].ToString());

            return arrayCoordinates; 
        }


        //limpar dados da tabela
        public static void clear()
        {
            X.Clear();
            Y.Clear();
            pointCount = 0;
            tableDist = null;

        }





    }


   
}
