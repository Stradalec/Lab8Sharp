namespace Lab1
{
    partial class MNK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            quadro = new System.Windows.Forms.RadioButton();
            linear = new System.Windows.Forms.RadioButton();
            calculate = new System.Windows.Forms.Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            textBox1 = new System.Windows.Forms.TextBox();
            inputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quadro);
            groupBox1.Controls.Add(linear);
            groupBox1.Location = new System.Drawing.Point(25, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(144, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Уравнение";
            // 
            // quadro
            // 
            quadro.AutoSize = true;
            quadro.Location = new System.Drawing.Point(11, 51);
            quadro.Name = "quadro";
            quadro.Size = new System.Drawing.Size(118, 19);
            quadro.TabIndex = 1;
            quadro.TabStop = true;
            quadro.Text = "y = ax^2 + bx + c";
            quadro.UseVisualStyleBackColor = true;
            // 
            // linear
            // 
            linear.AutoSize = true;
            linear.Location = new System.Drawing.Point(11, 26);
            linear.Name = "linear";
            linear.Size = new System.Drawing.Size(78, 19);
            linear.TabIndex = 0;
            linear.TabStop = true;
            linear.Text = "y = ax + b";
            linear.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            calculate.Location = new System.Drawing.Point(50, 354);
            calculate.Name = "calculate";
            calculate.Size = new System.Drawing.Size(75, 23);
            calculate.TabIndex = 2;
            calculate.Text = "Посчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new System.Drawing.Point(331, 14);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotView1.Size = new System.Drawing.Size(457, 412);
            plotView1.TabIndex = 3;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(27, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // inputButton
            // 
            inputButton.Location = new System.Drawing.Point(28, 227);
            inputButton.Name = "inputButton";
            inputButton.Size = new System.Drawing.Size(75, 23);
            inputButton.TabIndex = 5;
            inputButton.Text = "Начать ввод";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // MNK
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(inputButton);
            Controls.Add(textBox1);
            Controls.Add(plotView1);
            Controls.Add(calculate);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MNK";
            Text = "MNK";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton quadro;
        private System.Windows.Forms.RadioButton linear;
        private System.Windows.Forms.Button calculate;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inputButton;
    }
}