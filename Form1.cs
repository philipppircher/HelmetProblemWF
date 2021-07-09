using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelmetProblemWF
{
    public partial class Form1 : Form
    {
        const int MAXHELMETNUMBER = 28;
        const double COSTPERHELMET = 0.25;
        int[] helmets = new int[MAXHELMETNUMBER];
        int tries = 0;
        double costTotal = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void initalizeMemberVariables()
        {
            tries = 0;
            costTotal = 0;

            for (int index = 0; index < helmets.Length; index++)
            {
                helmets[index] = 0;
            }
        }

        private void btn_RandomHelmet_Click(object sender, EventArgs e)
        {
            AddCost();
            AddTry();
            AddHelmet();
            AllHelmetsPossesed();
        }

        private bool AllHelmetsPossesed()
        {
            bool allpossesed = false;

            for (int index = 0; index < MAXHELMETNUMBER; index++)
            {
                if (helmets[index] > 0)
                {
                    allpossesed = true;
                    continue;
                }
                else
                {
                    allpossesed = false;
                    break;
                }
            }

            return allpossesed;
        }

        private void AddCost()
        {
            costTotal += COSTPERHELMET;
        }

        private void AddTry()
        {
            tries++;
        }

        private bool AreAllHelmetsAvailable()
        {
            bool allAvailable = true;

            for (int i = 0; i < MAXHELMETNUMBER; i++)
            {
                if (helmets[i] > 0)
                {
                    continue;
                }
                else
                {
                    allAvailable = false;
                    break;
                }
            }
            return allAvailable;
        }

        private void AddHelmet()
        {
            int helmetNumber = GetRandomHelmetNumber(MAXHELMETNUMBER);
            helmets[helmetNumber]++;
        }

        /// <summary>
        /// Get a random number from 0 to 27 representing the index of helmet in array
        /// </summary>
        /// <returns></returns>
        private int GetRandomHelmetNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber);
        }

        private void btn_FullSimulation_Click(object sender, EventArgs e)
        {
            initalizeMemberVariables();
            do
            {
                AddCost();
                AddTry();
                AddHelmet();
            } while (!AllHelmetsPossesed());
            PrintResult();
        }

        private void PrintResult()
        {
            lst_Output.Items.Clear();
            lst_Output.Items.Add("Cost per try: " + COSTPERHELMET.ToString("C"));
            lst_Output.Items.Add("Cost total: " + costTotal.ToString("C"));
            lst_Output.Items.Add("Tries: " + tries);
            lst_Output.Items.Add("\n--------------------------------------");

            for (int index = 0; index < helmets.Length; index++)
            {
                lst_Output.Items.Add("Helmet team " + index + " count: " + helmets[index]);
            }
        }
    }
}
