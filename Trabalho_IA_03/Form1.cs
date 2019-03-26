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

            Pen blackPen = new Pen(Color.Aquamarine, 3);
            int X = e.X;
            int Y = e.Y;

            //TablePoints.AddPoint(X, Y);

            Rectangle rec = new Rectangle(X - 5, Y - 5, 10, 10);
            g.DrawEllipse(blackPen, rec);

            //distancias entre as coordenadas X,Y -> para mostrar na tela
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, X + 3, Y);
            g.DrawString("X :" + X.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 25);
            g.DrawString("Y :" + Y.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 12);

            pointCount++;
            lbQtdCidade.Text = pointCount.ToString();
            lbComplex.Text = Fatorial((ulong)pointCount).ToString();

            Console.WriteLine(TablePoints.Print());
        }

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Fatorial(number - 1);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            GeradorDeCoordenadas.GerarCoordenadas();

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
