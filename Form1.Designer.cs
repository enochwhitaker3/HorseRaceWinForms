namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHelloWorld = new Label();
            btnStart = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            horseLabel3 = new Label();
            horseLabel2 = new Label();
            horseLabel1 = new Label();
            progressBar3 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Location = new Point(0, 0);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(100, 23);
            lblHelloWorld.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(6, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(horseLabel3);
            groupBox1.Controls.Add(horseLabel2);
            groupBox1.Controls.Add(horseLabel1);
            groupBox1.Controls.Add(progressBar3);
            groupBox1.Controls.Add(progressBar2);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(btnStart);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 413);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 230);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 166);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(667, 101);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // horseLabel3
            // 
            horseLabel3.AutoSize = true;
            horseLabel3.Location = new Point(50, 230);
            horseLabel3.Name = "horseLabel3";
            horseLabel3.Size = new Size(64, 20);
            horseLabel3.TabIndex = 7;
            horseLabel3.Text = "Horse III";
            // 
            // horseLabel2
            // 
            horseLabel2.AutoSize = true;
            horseLabel2.Location = new Point(50, 166);
            horseLabel2.Name = "horseLabel2";
            horseLabel2.Size = new Size(60, 20);
            horseLabel2.TabIndex = 6;
            horseLabel2.Text = "Horse II";
            // 
            // horseLabel1
            // 
            horseLabel1.AutoSize = true;
            horseLabel1.Location = new Point(50, 101);
            horseLabel1.Name = "horseLabel1";
            horseLabel1.Size = new Size(56, 20);
            horseLabel1.TabIndex = 5;
            horseLabel1.Text = "Horse I";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(178, 230);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(422, 29);
            progressBar3.Step = 1;
            progressBar3.TabIndex = 3;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(178, 166);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(422, 29);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.AccessibleName = "progressBar1";
            progressBar1.Location = new Point(178, 101);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(422, 29);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 324);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblHelloWorld);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblHelloWorld;
        private Button btnStart;
        private GroupBox groupBox1;
        private Label horseLabel1;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private Label horseLabel3;
        private Label horseLabel2;
        public ProgressBar progressBar1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}