using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int somme = 0;
            int numero;

            Console.WriteLine("Entrez des numéros (entrez 0 pour arrêter) :");

            do
            {
                Console.Write("Entrez un numéro : ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    somme += numero;
                }
                else
                {
                    Console.WriteLine("Ce n'est pas un numéro valide. Réessayez.");
                }
            } while (numero != 0);

            Console.WriteLine($"La somme des numéros entrés est : {somme}");
        }
    }
}
