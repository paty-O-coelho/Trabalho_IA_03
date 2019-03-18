using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_IA_03.AGClass;

namespace Trabalho_IA_03.AGClass
{
    
    public static class ConfigurationGA

    {
        public static int sizeChromosome = 0;           //tamanho do cromossomos
        public static int sizePopulation = 100;         //tamanho da poupulaçao   
        public static Random random = new Random((int)DateTime.Now.Ticks);
        public static bool eletism = false;           //definir se ira usar eletismo
        public static double rateCrossover = 0.8;    //quantidade de individos para elitismo
        public static double rateMutation = 0.01;    //taxa de mutação
        public static int numbOfCompetitors = 3;      // numeros de competidores para torneio

        public static Mutation mutationType = Mutation.NewIndividual;

        public enum Mutation
        {
            NewIndividual,
            Inpopulation,
            InGenesPopulacao
        }


    }
}
