using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IA_03.AGClass
{
    public class GeneticAlgorithm
    {
        private double rateCrossover;         //taxa de cruzamento
        private double rateMutation;         //taxa de mutação

        public delegate Individual[] Crossover(Individual father1, Individual father2);
        public Crossover crossover;

        public delegate Individual Selection(Population pop);
        public Selection selection;


        public GeneticAlgorithm()
        {
            //Parametros iniciais
            this.crossover = CrossoverPMX;
            this.selection = Tournament;

            this.rateCrossover = ConfigurationGA.rateCrossover;
            this.rateMutation = ConfigurationGA.rateMutation;





        }


        //executando o AG
        public Population executeGA (Population pop)
        {

            /*Criar pop: vem por parametro
            avaliar a pop
            Eletismo
            seleção dos pais
            cruzamento dos pais
            mutação
            avaliação fitnes
            inserir nova pop*/


            return null;
        }


        //cruzamento

        public Individual [] CrossoverPMX (Individual father1, Individual father2)
        {


            Individual[] newInd = new Individual[2] ;
            int [] parent1 = new int[ConfigurationGA.sizeChromosome];
            int[]  parent2 = new int[ConfigurationGA.sizeChromosome];

            int[] offspring1Vector = new int[ConfigurationGA.sizeChromosome];
            int[] offspring2Vector = new int[ConfigurationGA.sizeChromosome];

            int[] replacement1 = new int[ConfigurationGA.sizeChromosome];
            int[] replacement2 = new int[ConfigurationGA.sizeChromosome];

            //seleção dos pontos para cruzamento
            int firstPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
            int secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

            if (firstPoint == secondPoint)
            {
                secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

            }
            if (firstPoint > secondPoint)
            {
                int temp = secondPoint;
                secondPoint = firstPoint;
                firstPoint = temp;

            }

            Console.WriteLine(" p1 " + firstPoint + "p2 " + secondPoint);


            newInd[0] = new Individual ();
            newInd[1] = new Individual ();

            //transferir os geneses para um parente
            for (int i=0; i < ConfigurationGA.sizeChromosome; i++)
            {
                parent1[i] = offspring1Vector[i] = father1.getGene(i);
                parent2[i] = offspring2Vector[i] = father2.getGene(i);

            }
            // popular o replasamento em valores abaixo de 0
            for (int i=0; i< ConfigurationGA.sizeChromosome; i++)
            {
                replacement1[i] = replacement2[i]= -1;

            }
            //passo do cruzamento

            for (int i = firstPoint; i <= secondPoint; i ++)
            {
                offspring1Vector[i] = parent2[i];
                offspring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];


            }

            //troca de geneses repetido

            for (int i=0; i < ConfigurationGA.sizeChromosome; i ++)
            {

                if ((i <= firstPoint) && (i <= secondPoint))
                    continue;


                //troca
                int n1 = parent1[i];
                int m1 = replacement1[n1];


                int n2 = parent2[i];
                int m2 = replacement1[n1]; //talvez esteja errado aqui


                while (m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];


                }

                while (m2 != -1)
                {
                    n2 = m2;
                    m1 = replacement2[m2];

                }

                offspring1Vector[i] = n1;
                offspring2Vector[i] = n2;


            }
              for (int i =0; i < ConfigurationGA.sizeChromosome; i++)
            {
                newInd[0].setGene(i, offspring1Vector[i]);
                newInd[1].setGene(i, offspring2Vector[i]);

            }
            newInd[0].CalcFitness();
            newInd[1].CalcFitness();

            return newInd;

        }

        public Individual Mutation(Individual ind)
        {
            return null;

        }
        //mutar cada individuo da poupulação

        public Population MutationThePopulation (Population pop)
        {
            return null;
        }

        //mutar cada gene em releção a população

        public Population MutationGenesesOfPopulation (Population pop)
        {
            return null;
        }

        //seleção por torneio
        public Individual Tournament(Population pop)
        {
            return null;
        }

    }
}
