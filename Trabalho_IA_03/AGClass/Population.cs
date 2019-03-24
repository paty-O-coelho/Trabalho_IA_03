namespace Trabalho_IA_03.AGClass
{
    public class Population
    {
        public Individual[] population;

        /// <summary>
        /// construtor -- inserir os individuos dentro do meu array (popular)
        /// </summary>
        public Population()
        {
            this.population = new Individual[ConfigurationGA.sizePopulation];

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                this.population[i] = new Individual();
                this.population[i].indexOfVector = i;


            }
            //avaliar o fitnes
            CalculateFitness();
        }

        public void CalculateFitness()
        {
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness();
            }
        }

        public void Evaluate()
        {
            RefreshIndexIndividual();
            CalculateFitness();
        }

        public void RefreshIndexIndividual()
        {
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].indexOfVector = i;
            }
        }

        /// <summary>
        /// retornar um array de idivi
        /// </summary>
        /// <returns></returns>
        public Individual[] GetPopulation()
        {
            return this.population;
        }


        public void SetIndividuals(int position, Individual individual)
        {
            this.population[position] = individual;
        }

        public double GetAveragePopulation()
        {
            double sum = 0;
            foreach (Individual ind in this.population)
            {
                sum += ind.GetFitness();
            }
            return (sum / ConfigurationGA.sizePopulation);
        }

        /// <summary>
        /// metodo para ordenar os individuos, do pior para o melhor
        /// </summary>
        public void OrdenPopulation()
        {
            Individual aux;
            int i, j;

            for (i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                for (j = 0; j < ConfigurationGA.sizePopulation; j++)
                {
                    if (population[i].GetFitness() < population[j].GetFitness())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }
        }

        /// <summary>
        /// RETORNAR O MELHOR INDIVIDUO
        /// </summary>
        /// <returns></returns>
        public Individual GetBest()
        {
            OrdenPopulation();
            return population[0];

        }

        /// <summary>
        /// retornar o pior individuo
        /// </summary>
        /// <returns></returns>
        public Individual GetBad()
        {
            OrdenPopulation();
            return population[ConfigurationGA.sizePopulation - 1];
        }


        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() + "\n";
            }
            return result;
        }

    }
}
