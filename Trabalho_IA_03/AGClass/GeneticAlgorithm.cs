using System;
using System.Collections;


namespace Trabalho_IA_03.AGClass
{
    public class GeneticAlgorithm
    {
        /// <summary>
        /// taxa de cruzamento
        /// </summary>
        private double rateCrossover;
        /// <summary>
        /// taxa de mutação
        /// </summary>
        private double rateMutation;

        public delegate Individual[] Crossover(Individual father1, Individual father2);
        public Crossover crossover;

        public delegate Individual Selection(Population pop);
        public Selection selection;

        /// <summary>
        /// Contrutor com os parâmetros iniciais
        /// </summary>
        public GeneticAlgorithm()
        {
            this.crossover = CrossoverPMX;
            this.selection = Tournament;

            this.rateCrossover = ConfigurationGA.rateCrossover;
            this.rateMutation = ConfigurationGA.rateMutation;
        }

        /// <summary>
        /// Executando o AG
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>
        public Population ExecuteGA(Population pop)
        {
            /*Criar pop: vem por parametro
          
            avaliar a pop
            Eletismo
            seleção dos pais
            cruzamento dos pais
            mutação
            avaliação fitnes
            inserir nova pop*/

            Population newPopulation = new Population();
            list<Individual> popTemp = new list<Individual> ();
            
            //atribuir individos a pop temp
            
            for (int i =0; i < ConfigurationGA.sizePopulation; i++)
            {
                //AJEITAR O ADD
               // poptemp.Add(pop.GetPopulation()[i]);
            }

            // Eletismo
            //VAI FICAR VAIZA, NAO VOU USAR

           


            for (int i = 0; i < ConfigurationGA.sizePopulation/2; i++)
            {

                //seleção dos pais
                Individual father1 = selection(pop);
                Individual father2 = selection(pop);

                //cruzamento dos pais
                double sorte = ConfigurationGA.random.NextDouble();

                if (sorte <= rateCrossover)
                {
                    Individual[] children = crossover(father1, father2);

                    
                    if (ConfigurationGA.mutationType == ConfigurationGA.Mutation. NewIndividual)
                    {
                        //Mutação                 
                        children[0] = Mutation(children[0]);
                        children[1] = Mutation(children[1]);

                    }
                    //Rearanjar os filhos no vetor

                    children[0].indexOfVector = father1.indexOfVector;
                    children[1].indexOfVector = father2.indexOfVector;



                    /*ta dando erro
                    popTemp[father1.indexOfVector] = children[0];
                    popTemp[father2.indexOfVector] = children[1];

                    */

                } 
                else
                {
                  //   popTemp[father1.indexOfVector] = father1;
                  // popTemp[father2.indexOfVector] = father2;

                }



            }


            //apagar os novos mebros
            //inserir os novos membros


            for (int i=0; i <ConfigurationGA.sizePopulation; i++)
            {
                //TA DANDO ERRO AQUI
                //newPopulation.SetIndividuals(i, popTemp[i]);
            }

            popTemp = null;

            //aplicação da mutação na pop
            if (ConfigurationGA.mutationType == ConfigurationGA.Mutation.Inpopulation)
            {
                newPopulation = MutationThePopulation(newPopulation);

            }

            ///CAMPO RESEVADO PARA INSERIRI O ALGORITMO DO ELETISMO
            ///


            return null;
        }

        /// <summary>
        /// Cruzamento
        /// </summary>
        /// <param name="father1"></param>
        /// <param name="father2"></param>
        /// <returns></returns>
        public Individual[] CrossoverPMX(Individual father1, Individual father2)
        {
            Individual[] newInd = new Individual[2];
            int[] parent1 = new int[ConfigurationGA.sizeChromosome];
            int[] parent2 = new int[ConfigurationGA.sizeChromosome];

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

            Console.WriteLine(" p1 " + firstPoint + " p2 " + secondPoint);

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            //transferir os geneses para um parente
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                parent1[i] = offspring1Vector[i] = father1.GetGene(i);
                parent2[i] = offspring2Vector[i] = father2.GetGene(i);

            }
            // popular o replasamento em valores abaixo de 0
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                replacement1[i] = replacement2[i] = -1;

            }
            //passo do cruzamento

            for (int i = firstPoint; i <= secondPoint; i++)
            {
                offspring1Vector[i] = parent2[i];
                offspring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            //troca de geneses repetido
            ///CONSERTAR ESSA PARTE PARA QUE ELE POSSA PEGAR OS PONTOS DE CORTE CERTOS


            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if ((i <= firstPoint) && (i <= secondPoint))
                    continue;

                //troca
                int n1 = parent1[i];
                int m1 = replacement1[n1];


                int n2 = parent2[i];
                int m2 = replacement1[n1]; //talvez esteja errado aqui

                if (m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];
                }

                if (m2 != -1)
                {
                    n2 = m2;
                    m1 = replacement2[m2];
                }

                offspring1Vector[i] = n1;
                offspring2Vector[i] = n2;
            }
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                newInd[0].SetGene(i, offspring1Vector[i]);
                newInd[1].SetGene(i, offspring2Vector[i]);

            }
            newInd[0].CalcFitness();
            newInd[1].CalcFitness();

            return newInd;
        }

        public Individual Mutation(Individual ind)
        {
            //Verifica se vai mutar
            if (ConfigurationGA.random.NextDouble() <= rateMutation)
            {

                //pontos de swap
                int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
                int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

                Console.WriteLine("P1 " + genePosition1 + " P2 "+ genePosition2);


                if (genePosition1 == genePosition2)
                {
                     if (genePosition2 <= ConfigurationGA.sizeChromosome - 2)
                      {
                        genePosition2++;

                       }

                  }
                ind.Mutate(genePosition1, genePosition2);
                return ind;
             
 
              }


            return null;
        }

        /// <summary>
        /// Mutar cada individuo da poupulação.
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>
        public Population MutationThePopulation(Population pop)
        {

            for (int i=0; i < ConfigurationGA.sizeChromosome; i++)
            {

                //Verifica se vai mutar
                if (ConfigurationGA.random.NextDouble() <= rateMutation)
                {

                    //pontos de swap
                    int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
                    int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);


                    if (genePosition1 == genePosition2)
                    {
                        if (genePosition2 <= ConfigurationGA.sizeChromosome - 2)
                        {
                            genePosition2++;

                        }
                        else
                        {
                            genePosition2 -= 2;
                        }
                    }

                    pop.GetPopulation()[i].Mutate(genePosition1, genePosition2);
                    
                }

                }





            return pop;
        }

        /// <summary>
        /// Mutar cada gene em releção a população.
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>


        /*public Population MutationGenesesOfPopulation(Population pop)
        {
            return null;
        }

    */

        /// <summary>
        /// Seleção por torneio.
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>
        public Individual Tournament(Population pop)
        {

            Individual[] competitors = new Individual[ConfigurationGA.numbOfCompetitors];
            Individual aux = new Individual ();
            aux.SetFitness(float.PositiveInfinity);


            //seleção de competidores
            for (int i=0; i <ConfigurationGA.numbOfCompetitors; i ++)
            {

                competitors[i] = new Individual();
                competitors[i] = pop.GetPopulation()[ConfigurationGA.random.Next(0, ConfigurationGA.sizePopulation - 1)];

                Console.WriteLine(competitors[i]);


            }
                
            //escolher um vencedor


            for (int i= 0; i <ConfigurationGA.numbOfCompetitors; i ++)
            {

                if (competitors[i].GetFitness() < aux.GetFitness() )
                {
                    aux = competitors[i];
                    aux.CalcFitness();


                }
            }


            return aux;
        }
    }
}
