using System.Collections.Generic;

namespace Trabalho_IA_03.AGClass
{
    public class Individual
    {
        /// <summary>
        /// Cromossomo de inteiros - Cada gene representa uma cidade
        /// </summary>
        private int[] chromosome;
        /// <summary>
        /// Valor de aptidão do ind.
        /// </summary>
        private double fitness;
        /// <summary>
        /// Posicao dos individuos
        /// </summary>
        public int indexOfVector = 0;

        /// <summary>
        /// Construtor
        /// </summary>
        public Individual()
        {
            this.chromosome = new int[ConfigurationGA.sizeChromosome];
            List<int> genes = Utils.RandomNubers(0, ConfigurationGA.sizeChromosome);

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                this.chromosome[i] = genes[i];
            }

            //Calculo do fitness
            CalcFitness();

        }

        /// <summary>
        /// Avaliar o ind
        /// </summary>
        public void Evaluate()
        {
            CalcFitness();
        }

        public int[] GetCromosome()
        {
            return this.chromosome;
        }

        /// <summary>
        /// Calcular o fitness do indivíduo.
        /// </summary>
        public void CalcFitness()
        {
            double totalDist = 0.0;

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if (i < (ConfigurationGA.sizeChromosome - 1))
                {
                    totalDist += TablePoints.GetDist(GetGene(i), GetGene(i + 1));
                }
                else
                {
                    totalDist += TablePoints.GetDist(GetGene(i), GetGene(0));
                }
            }

            SetFitness(totalDist);
        }

        public void SetGene(int position, int gene)
        {
            this.chromosome[position] = gene;
        }

        public int GetGene(int position)
        {
            return this.chromosome[position];

        }

        public void SetFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double GetFitness()
        {
            return this.fitness;
        }

        /// <summary>
        /// #PARTE IMPORTANTE#
        /// Swap/ crossover-> troca de genes
        /// </summary>
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>
        public void Mutate(int pointOne, int pointTwo)
        {
            if (pointOne < ConfigurationGA.sizeChromosome
               && pointTwo < ConfigurationGA.sizeChromosome
               && pointOne != pointTwo)
            {
                int temp = chromosome[pointOne];
                chromosome[pointOne] = chromosome[pointTwo];
                chromosome[pointTwo] = temp;
            }
        }

        public override string ToString()
        {
            base.ToString();

            string result = string.Empty;
            result += "Rota:    ";

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                result += (GetGene(i) + 1).ToString() + " -> ";
            }

            result += "Distancia: " + GetFitness();

            return result;
        }
    }
}
