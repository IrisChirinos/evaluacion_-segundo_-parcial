using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;

            f = Convert.ToInt32(filas.Text);
            c = Convert.ToInt32(columnas.Text);
            int[,] matriz = new int[f, c];
            Random rand = new Random();
            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            { 
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    
                    aleatorio.Items.Add(rand.Next(1,101));
                    
                }

                }
            

        }
    }
}
