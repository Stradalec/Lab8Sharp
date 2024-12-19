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
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            generate = new System.Windows.Forms.RadioButton();
            file = new System.Windows.Forms.RadioButton();
            hand = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(266, 150);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quadro);
            groupBox1.Controls.Add(linear);
            groupBox1.Controls.Add(calculate);
            groupBox1.Location = new System.Drawing.Point(56, 338);
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
            calculate.Location = new System.Drawing.Point(31, 71);
            calculate.Name = "calculate";
            calculate.Size = new System.Drawing.Size(75, 23);
            calculate.TabIndex = 2;
            calculate.Text = "Посчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new System.Drawing.Point(360, 14);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotView1.Size = new System.Drawing.Size(428, 412);
            plotView1.TabIndex = 3;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(112, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(70, 23);
            textBox1.TabIndex = 4;
            // 
            // inputButton
            // 
            inputButton.Location = new System.Drawing.Point(74, 309);
            inputButton.Name = "inputButton";
            inputButton.Size = new System.Drawing.Size(111, 23);
            inputButton.TabIndex = 5;
            inputButton.Text = "Начать ввод";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(99, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 15);
            label1.TabIndex = 6;
            label1.Text = "Кол-во значений";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(generate);
            groupBox2.Controls.Add(file);
            groupBox2.Controls.Add(hand);
            groupBox2.Location = new System.Drawing.Point(25, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(217, 123);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(111, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(70, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(93, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Диапазон генерации";
            // 
            // generate
            // 
            generate.AutoSize = true;
            generate.Location = new System.Drawing.Point(11, 70);
            generate.Name = "generate";
            generate.Size = new System.Drawing.Size(83, 19);
            generate.TabIndex = 2;
            generate.TabStop = true;
            generate.Text = "Генерация";
            generate.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            file.AutoSize = true;
            file.Location = new System.Drawing.Point(11, 45);
            file.Name = "file";
            file.Size = new System.Drawing.Size(77, 19);
            file.TabIndex = 1;
            file.TabStop = true;
            file.Text = "Из файла";
            file.UseVisualStyleBackColor = true;
            // 
            // hand
            // 
            hand.AutoSize = true;
            hand.Location = new System.Drawing.Point(11, 21);
            hand.Name = "hand";
            hand.Size = new System.Drawing.Size(66, 19);
            hand.TabIndex = 0;
            hand.TabStop = true;
            hand.Text = "Ручной";
            hand.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MNK
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(inputButton);
            Controls.Add(plotView1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MNK";
            Text = "MNK";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton generate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}