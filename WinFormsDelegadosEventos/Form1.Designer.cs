
namespace WinFormsDelegadosEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStart4 = new System.Windows.Forms.Button();
            this.btnStart5 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStop4 = new System.Windows.Forms.Button();
            this.btnStop5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(614, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 375);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(614, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 70);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(614, 23);
            this.progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(12, 99);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(614, 23);
            this.progressBar4.TabIndex = 7;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(12, 128);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(614, 23);
            this.progressBar5.TabIndex = 8;
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(632, 41);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 23);
            this.btnStart2.TabIndex = 9;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(632, 70);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(75, 23);
            this.btnStart3.TabIndex = 10;
            this.btnStart3.Text = "Start";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStart4
            // 
            this.btnStart4.Location = new System.Drawing.Point(632, 99);
            this.btnStart4.Name = "btnStart4";
            this.btnStart4.Size = new System.Drawing.Size(75, 23);
            this.btnStart4.TabIndex = 11;
            this.btnStart4.Text = "Start";
            this.btnStart4.UseVisualStyleBackColor = true;
            this.btnStart4.Click += new System.EventHandler(this.btnStart4_Click);
            // 
            // btnStart5
            // 
            this.btnStart5.Location = new System.Drawing.Point(632, 128);
            this.btnStart5.Name = "btnStart5";
            this.btnStart5.Size = new System.Drawing.Size(75, 23);
            this.btnStart5.TabIndex = 12;
            this.btnStart5.Text = "Start";
            this.btnStart5.UseVisualStyleBackColor = true;
            this.btnStart5.Click += new System.EventHandler(this.btnStart5_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(713, 41);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 23);
            this.btnStop2.TabIndex = 13;
            this.btnStop2.Text = "Stop";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(713, 70);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(75, 23);
            this.btnStop3.TabIndex = 14;
            this.btnStop3.Text = "Stop";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStop4
            // 
            this.btnStop4.Location = new System.Drawing.Point(713, 99);
            this.btnStop4.Name = "btnStop4";
            this.btnStop4.Size = new System.Drawing.Size(75, 23);
            this.btnStop4.TabIndex = 15;
            this.btnStop4.Text = "Stop";
            this.btnStop4.UseVisualStyleBackColor = true;
            this.btnStop4.Click += new System.EventHandler(this.btnStop4_Click);
            // 
            // btnStop5
            // 
            this.btnStop5.Location = new System.Drawing.Point(713, 128);
            this.btnStop5.Name = "btnStop5";
            this.btnStop5.Size = new System.Drawing.Size(75, 23);
            this.btnStop5.TabIndex = 16;
            this.btnStop5.Text = "Stop";
            this.btnStop5.UseVisualStyleBackColor = true;
            this.btnStop5.Click += new System.EventHandler(this.btnStop5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.btnStop5);
            this.Controls.Add(this.btnStop4);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStart5);
            this.Controls.Add(this.btnStart4);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Button btnStart4;
        private System.Windows.Forms.Button btnStart5;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop4;
        private System.Windows.Forms.Button btnStop5;
    }
}

