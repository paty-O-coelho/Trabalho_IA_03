using System;

namespace Trabalho_IA_03.AGClass
{
    public static class ConfigurationGA
    {
        /// <summary>
        /// Tamanho do cromossomos
        /// </summary>
        public static int sizeChromosome = 0;
        /// <summary>
        /// Tamanho da poupulaçao
        /// </summary>
        public static int sizePopulation = 100;
        /// <summary>
        /// 
        /// </summary>
        public static Random random = new Random((int)DateTime.Now.Ticks);
        /// <summary>
        /// Definir se irá usar eletismo
        /// </summary>
        public static bool eletism = false;
        /// <summary>
        /// Quantidade de individos para elitismo
        /// </summary>
        public static double rateCrossover = 0.8;
        /// <summary>
        /// Taxa de mutação
        /// </summary>
        public static double rateMutation = 0.01;
        /// <summary>
        /// Números de competidores para torneio
        /// </summary>
        public static int numbOfCompetitors = 3;
        /// <summary>
        /// 
        /// </summary>
        public static Mutation mutationType = Mutation.NewIndividual;

        public enum Mutation
        {
            NewIndividual,
            Inpopulation,
            InGenesPopulacao
        }
    }
}
