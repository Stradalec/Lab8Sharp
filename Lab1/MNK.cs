﻿using OxyPlot.Series;
using OxyPlot;
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
using NPOI.SS.Formula.Functions;

namespace Lab1
{
    public partial class MNK : Form, IMNKView
    {
        double[] pointNumberX = new double[5];
        double[] pointNumberY = new double[5];
        private Size formOriginalSize;
        private Rectangle recTextBox1;
        private Rectangle recLabel1;
        private Rectangle recInputButton;
        private Rectangle recGroupBox1;
        private Rectangle recLinear;
        private Rectangle recQadro;
        private Rectangle recCalculate;
        private Rectangle recGraph;


        public MNK()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            this.Resize += MNK_Resize;
            formOriginalSize = this.Size;
            recTextBox1 = new Rectangle(textBox1.Location, textBox1.Size);
            recLabel1 = new Rectangle(label1.Location, label1.Size);
            recInputButton = new Rectangle(inputButton.Location, inputButton.Size);
            recGroupBox1 = new Rectangle(groupBox1.Location, groupBox1.Size);
            recLinear = new Rectangle(linear.Location, linear.Size);
            recQadro = new Rectangle(quadro.Location, quadro.Size);
            recCalculate = new Rectangle(calculate.Location, calculate.Size);
            recGraph = new Rectangle(plotView1.Location, plotView1.Size);
        }
        private void MNK_Resize(object sender, EventArgs e)
        {
            AutoResize(textBox1, recTextBox1);
            AutoResize(label1 , recLabel1);
            AutoResize (inputButton , recInputButton);
            AutoResize(groupBox1, recGroupBox1);
            AutoResize(linear, recLinear);
            AutoResize(quadro, recQadro);
            AutoResize(calculate, recCalculate);
            AutoResize (plotView1, recGraph);
        }

        private void AutoResize(Control control, Rectangle rectangle)
        {
            double xRatio = (double)(this.Width) / (double)(formOriginalSize.Width);
            double yRatio = (double)(this.Height) / (double)(formOriginalSize.Height);
            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)(rectangle.Width * xRatio);
            int newHeight = (int)(rectangle.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
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
            pointNumberX = valuesOFX;
            return valuesOFX;
        }

        double[] IMNKView.GetYValue()
        {
            double[] valuesOFY = new double[dataGridView1.Rows.Count - 1];

            for (int indexOfY = 0; indexOfY < dataGridView1.Rows.Count - 1; ++indexOfY)
            {
                valuesOFY[indexOfY] = Convert.ToDouble(dataGridView1.Rows[indexOfY].Cells[1].Value);
            }
            pointNumberY = valuesOFY;
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
            var series = new LineSeries();
            series.MarkerType = MarkerType.Circle;
            series.Color = OxyColors.Violet;
            series.MarkerSize = 5;
            var points = new List<DataPoint>();
            for (int outputIndex = 0; outputIndex < pointNumberX.Length; outputIndex++) 
            {
                points.Add(new DataPoint(pointNumberX[outputIndex], pointNumberY[outputIndex]));
                points.Add(new DataPoint(double.NaN, double.NaN));
            }


            series.ItemsSource = points;
            
            plotView1.Model = plotModel;
            plotModel.Series.Add(series);
            plotView1.Model = plotModel;
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
