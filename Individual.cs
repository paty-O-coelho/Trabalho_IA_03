using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_IA_03;


namespace Trabalho_IA_03.AGClass


{
    public class Individual
    {
        private int[] chromosome;           //Cromossomo de inteiros - Cada gene representa uma cidade
        private double fitness;             //Valor de aptidão do ind.
        public int indexOfVector = 0;       //Posicao dos individuos

        //Contrutor
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

        //Avaliar o ind
        public void Evaluate()
        {
            CalcFitness();
        }

        public int[] getCromosome()
        {
            return this.chromosome;
        }

        //CALCULAR O FITNES DO INDIVIDUO

        public void CalcFitness()
        {
            double totalDist = 0.0;

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if (i < (ConfigurationGA.sizeChromosome - 1))
                {
                    totalDist += TablePoints.getDist(getGene(i), getGene(i + 1));
                }
                else
                {
                    totalDist += TablePoints.getDist(getGene(i), getGene(0));
                }
            }

            setFitness(totalDist);
        }

        public void setGene(int position, int gene)
        {
            this.chromosome[position] = gene;
        }

        public int getGene(int position)
        {
            return this.chromosome[position];

        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }


         //#PARTE IMPORTANTE#
        //Swap/ crossover-> troca de genes 
        public void mutate(int pointOne, int pointTwo)
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
                result += (getGene(i) + 1).ToString() + " -> ";
            }

            result += "Distancia: " + getFitness();

            return result;
        }

    }
}
