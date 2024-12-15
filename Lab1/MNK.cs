using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MNK : Form, IMNKView
    {
        public MNK()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        private void calculate_Click(object sender, EventArgs inputEvent)
        {
            Calculate(sender, inputEvent);
        }

        double[] IMNKView.GetXValue() 
        {
            double[] valuesOFX = new double[dataGridView1.Rows.Count - 1];

            for (int indexOfX = 0; indexOfX < dataGridView1.Rows.Count - 1; ++indexOfX)
            {
                valuesOFX[indexOfX] = Convert.ToDouble(dataGridView1.Rows[indexOfX].Cells[0].Value);
            }

            return valuesOFX;
        }

        double[] IMNKView.GetYValue()
        {
            double[] valuesOFY = new double[dataGridView1.Rows.Count - 1];

            for (int indexOfY = 0; indexOfY < dataGridView1.Rows.Count - 1; ++indexOfY)
            {
                valuesOFY[indexOfY] = Convert.ToDouble(dataGridView1.Rows[indexOfY].Cells[1].Value);
            }

            return valuesOFY;
        }

        bool IMNKView.IsLinear() 
        {
            if (linear.Checked)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        void IMNKView.ShowResult(double[] result, OxyPlot.PlotModel plotModel) 
        {
            string resultString = "";
            if (result != null)
            {
                for (int outputIndex = 0; outputIndex < result.Length; ++outputIndex)
                {
                    resultString += "x" + (outputIndex + 1) + " = " + Math.Round(result[outputIndex], 2).ToString() + "\n";
                }

            }
            MessageBox.Show(resultString, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event EventHandler<EventArgs> Calculate;
        private void inputButton_Click(object sender, EventArgs inputEvent)
        {
            int rowsCount = Convert.ToInt32(textBox1.Text); 


            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");


            for (int inputIndex = 0; inputIndex < rowsCount; ++inputIndex)
            {
                dataGridView1.Rows.Add();
            }


        }
    }
}
