using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IA_03.AGClass
{
    public class Population
    {
        public Individual[] population;


        //construtor -- inserir os individuos dentro do meu array (popular)
        public Population()
        {
            this.population = new Individual[ConfigurationGA.sizePopulation];
            
            for (int i =0; i <ConfigurationGA.sizePopulation; i++)
            {
                this.population[i] = new Individual();
                this.population[i].indexOfVector = i;


            }
            //avaliar o fitnes
            calculateFitness();
        }

        public void calculateFitness()
        {
            for (int i=0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness();



            }
        }
        public void Evaluate()

        {
            refreshIndexIndividual();
            calculateFitness();
        }

        public void refreshIndexIndividual()
        {
            for (int i=0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].indexOfVector = i;
            }
        }


        //retornar um array de idivi
        public Individual [] getPopulation ()
        {
            return this.population;

        }


        public void setIndividuals(int position, Individual individual )
        {
            this.population[position] = individual;
        }

        public double getAveragePopulation()
        {
            double sum = 0;
             foreach (Individual ind in this.population)
            {
                sum += ind.getFitness();
            }
            return (sum/ConfigurationGA.sizePopulation);
        }


        //metodo para ordenar os individuos, do pior para o melhor
      
        public void OrdenPopulation()
        {
            Individual aux;
            int i, j;

            for (i=0; i< ConfigurationGA.sizePopulation; i++)
            {
                for (j=0; j< ConfigurationGA.sizePopulation; j++)
                {
                    if (population[i].getFitness () < population[j].getFitness ())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }



        } 

        //RETORNAR O MELHOR INDIVIDUO
        public Individual getBest()
        {
            OrdenPopulation();
            return population[0];

        }
        //retornar o pior individuo
        public Individual getBad()
        {
            OrdenPopulation();
            return population[ConfigurationGA.sizePopulation -1];
        }


        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;

            for (int i=0; i<ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() + "\n" ;
            }
            return result;
        }

    }
}
