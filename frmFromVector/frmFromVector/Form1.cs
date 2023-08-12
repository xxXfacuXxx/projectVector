using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFromVector
{
    public partial class frmFromVector : Form
    {
        int i = 0;
        int[] vector = new int[25];

        public frmFromVector()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < vector.Length)
            {
                if (int.TryParse(numVec.Text, out int num) && num > 0)
                {
                    vector[i] = num;
                    i++;
                    numVec.Clear();
                }
                else
                {
                    MessageBox.Show("El numero debe ser mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("El Array está completo");
            }
            listBox1.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                listBox1.Items.Add(vector[j]);
            }
            int btnMax = vector[0];
            for (int j = 1; j < i; j++)
            {
                if (vector[j] > btnMax)
                {
                    btnMax = vector[j];
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int maxValue = FindMaxValue();
            if (maxValue != int.MinValue)
            {
                listBox1.Items.Add($"El valor máximo es: {maxValue}");
            }
            else
            {
                listBox1.Items.Add("No se han ingresado valores aún.");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int minValue = FindMinValue();
            if (minValue != int.MaxValue)
            {
                listBox1.Items.Add($"El valor mínimo es: {minValue}");
            }
            else
            {
                listBox1.Items.Add("No se han ingresado valores aún.");
            }
        }
        private int FindMaxValue()
        {
            if (i == 0)
            {
                return int.MinValue;
            }

            int maxValue = vector[0];
            for (int j = 1; j < i; j++)
            {
                if (vector[j] > maxValue)
                {
                    maxValue = vector[j];
                }
            }

            return maxValue;
        }

        private int FindMinValue()
        {
            if (i == 0)
            {
                return int.MaxValue;
            }

            int minValue = vector[0];
            for (int j = 1; j < i; j++)
            {
                if (vector[j] < minValue)
                {
                    minValue = vector[j];
                }
            }

            return minValue;
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = CalculateTotal();
            listBox1.Items.Add($"La suma total es: {total}");
        }
        private int CalculateTotal()
        {
            int total = 0;
            for (int j = 0; j < i; j++)
            {
                total += vector[j];
            }
            return total;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void numVec_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
