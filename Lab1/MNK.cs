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
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Text.RegularExpressions;
using NPOI.XSSF.Streaming.Values;


namespace Lab1
{
    public partial class MNK : Form, IMNKView
    {
        private string pathToFile = "temporary";
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
        private Rectangle recGroupBox2;
        private Rectangle recHand;
        private Rectangle recFile;
        private Rectangle recLabel2;
        private Rectangle recTextBox2;
        private Rectangle recGenerate;
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
            recGroupBox2 = new Rectangle(groupBox2.Location, groupBox2.Size);
            recHand = new Rectangle(hand.Location, hand.Size);
            recFile = new Rectangle(file.Location, file.Size);
            recLabel2 = new Rectangle(label2.Location, label2.Size);
            recTextBox2 = new Rectangle(textBox2.Location, textBox2.Size);
            recGenerate = new Rectangle(generate.Location, generate.Size);
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
            AutoResize(groupBox2 , recGroupBox2);
            AutoResize(hand, recHand);
            AutoResize(file, recFile);
            AutoResize(label2, recLabel2);
            AutoResize(textBox2, recTextBox2);
            AutoResize(generate, recGenerate);
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
                    if (outputIndex == 0)
                    {
                        resultString += "a" + " = " + Math.Round(result[outputIndex], 2).ToString() + "\n";
                    }
                    else if (outputIndex == 1)
                    {
                        resultString += "b" + " = " + Math.Round(result[outputIndex], 2).ToString() + "\n";
                    }
                    else if (outputIndex == 2) 
                    {
                        resultString += "c" + " = " + Math.Round(result[outputIndex], 2).ToString() + "\n";
                    }
                    
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
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            int matrixCount = 1;
            int rowsCount = 1;
            int Interval = 5;
            if (string.IsNullOrEmpty(textBox1.Text) || (regex.IsMatch(textBox1.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода размерности таблицы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matrixCount = 1;
            }
            else 
            {
                rowsCount = Convert.ToInt32(textBox1.Text);
            }
            
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
            if (hand.Checked)
            {

                for (int inputIndex = 0; inputIndex < rowsCount; ++inputIndex)
                {
                    dataGridView1.Rows.Add();
                }
            }
            else if (file.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathToFile = openFileDialog1.FileName;
                }
                if (pathToFile != "temporary")
                {
                    if (pathToFile.Contains("xlsx"))
                    {
                        using (FileStream file = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
                        {
                            IWorkbook workbook = new XSSFWorkbook(file);
                            ISheet sheet = workbook.GetSheetAt(0);

                            for (int excelIndex = 0; excelIndex <= sheet.LastRowNum; ++excelIndex)
                            {
                                IRow currentrow = sheet.GetRow(excelIndex);
                                if (currentrow != null)
                                {
                                    ICell cell = currentrow.GetCell(0);
                                    ICell Secondcell = currentrow.GetCell(1);
                                    if (cell != null)
                                    {
                                        dataGridView1.Rows.Add(cell.NumericCellValue, Secondcell.NumericCellValue);
                                    }
                                }

                            }
                        }
                    }
                    else if (pathToFile.Contains("txt"))
                    {
                        string text = File.ReadAllText(pathToFile);
                        string[] lines = text.Split('\n');


                        foreach (string line in lines)
                        {
                            string[] numbers = line.Split(' ');
                            if (numbers.Length == 2)
                            {
                                int value1 = int.Parse(numbers[0]);
                                int value2 = int.Parse(numbers[1]);
                                dataGridView1.Rows.Add(value1, value2);
                            }
                        }
                    }

                }

            }
            else if (generate.Checked) 
            {
                Random random = new Random();
                if (string.IsNullOrEmpty(textBox2.Text) || (regex.IsMatch(textBox2.Text)) == false)
                {
                    MessageBox.Show("Ошибка ввода размерности диапазона", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    matrixCount = 1;
                }
                else
                {
                    Interval = Convert.ToInt32(textBox2.Text);
                }
                for (int randomIndex = 0; randomIndex < rowsCount * 2; ++randomIndex)
                {
                    dataGridView1.Rows.Add(random.Next(-Interval, Interval), random.Next(-Interval, Interval));
                }
            }
            


        }
    }
}
