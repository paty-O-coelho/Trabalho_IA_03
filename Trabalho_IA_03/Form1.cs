using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_IA_03.AGClass;
using System.IO;

namespace Trabalho_IA_03
{
    public partial class lbteste : Form
    {
        Graphics g;               //desenhar elementos na tela
        int count = 0;            //contador para verificar a quantidade de pontos na tela
        int pointCount = 0;      //sequenciador para indentificar pontos na tela


        public lbteste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        /// <summary>
        /// Função para marcar as cidades
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            // Console.WriteLine("Point insert");
            Pen blackPen = new Pen(Color.Aquamarine, 3);
            int X = e.X;
            int Y = e.Y;
            // Console.WriteLine("X :" + X + "Y :" + Y);
            TablePoints.AddPoint(X, Y);

            Rectangle rec = new Rectangle(X - 5, Y - 5, 10, 10);
            g.DrawEllipse(blackPen, rec);

            //distancias entre as coordenadas X,Y -> para mostrar na tela
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, X + 3, Y);
            g.DrawString("X :" + X.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 25);
            g.DrawString("Y :" + Y.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 12);

            pointCount++;
            lbQtdCidade.Text = pointCount.ToString();
            lbComplex.Text = Fatorial((ulong)pointCount).ToString();


            //if (++count >= 4)
            //{
            //    btnCriarPop.Enabled = true;
            //}
            //if (++count >= 1)
            //{
            //    btnLimpar.Enabled = true;
            //}
            //else
            //{
            //    btnLimpar.Enabled = false;

            //}
            Console.WriteLine(TablePoints.Print());
        }


        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Fatorial(number - 1);
        }


        /*
       private void ploatPonts()
        {
            //verificando se a tabela possue pontos
            if (TablePoints.pointCount > 0)
            {

                for (int i =0; i < TablePoints.pointCount; i ++)
                {

                    //criar um lapis
                    Pen blackPen = new Pen(Color.Red, 3);
                    //array de coordenadas x e y
                    int[] coo = TablePoints.gerCoordinates(i);
                    Rectangle rec = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);

                    g.DrawEllipse(blackPen, rec);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0]+ 3, coo[1]);
                    g.DrawString("X :" + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    g.DrawString("Y :" + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);

                }
            }


        }*/




        /*
        private void ploatLines(Population pop, Color color)
    {
        Pen penBest = new Pen(color, 3);
        int genA;
        int genB; 


        Individual best = pop.getBest();


        for (int i =0; i< ConfigurationGA.sizeChromossome; i ++)
        {
            if (i < CofigurationGA.sizeChromossome -1)
            {
                genA = best.getGene(i);
                genB = best.getGene(i + 1);


            }
            else
            {
                genA = best.getGene(i);
                genB = best.getGene(0);
            }

            int[] vetA = TablePoints.getCoordinates(genA);
            int[] vetB = TablePoints.getCoordinates(genB);

            g.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[1]);

        }


    }*/

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {

            Individual ind1 = new Individual();
            Individual ind2 = new Individual();

            Console.WriteLine(ind1);
            Console.WriteLine(ind2);


            GeneticAlgorithm AG = new GeneticAlgorithm();
            Individual[] inds = new Individual[2];


            inds = AG.CrossoverPMX(ind1, ind2);
            Console.WriteLine("cruuzamento \n");


            Console.WriteLine(inds[0]);
            Console.WriteLine(inds[1]);




            /*ConfigurationGA.sizePopulation = 500;
            Population pop = new Population();

            Console.WriteLine("Melhor " + pop.getBest());
            Console.WriteLine("Pior " + pop.getBad());
            */

        }
    }
}
