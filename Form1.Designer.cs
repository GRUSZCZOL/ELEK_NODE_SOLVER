namespace ELEK_NODE_SOLVER
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Raport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_U = new System.Windows.Forms.Button();
            this.button_I = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Raport
            // 
            this.textBox_Raport.Location = new System.Drawing.Point(539, 12);
            this.textBox_Raport.Multiline = true;
            this.textBox_Raport.Name = "textBox_Raport";
            this.textBox_Raport.Size = new System.Drawing.Size(381, 482);
            this.textBox_Raport.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 152);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(521, 399);
            this.dataGridView.TabIndex = 3;
            // 
            // button_U
            // 
            this.button_U.Location = new System.Drawing.Point(130, 12);
            this.button_U.Name = "button_U";
            this.button_U.Size = new System.Drawing.Size(64, 64);
            this.button_U.TabIndex = 10;
            this.button_U.Text = "ŹRÓDŁO NAPIĘCIOWE";
            this.button_U.UseVisualStyleBackColor = true;
            this.button_U.Click += new System.EventHandler(this.button_U_Click);
            // 
            // button_I
            // 
            this.button_I.Location = new System.Drawing.Point(200, 12);
            this.button_I.Name = "button_I";
            this.button_I.Size = new System.Drawing.Size(64, 64);
            this.button_I.TabIndex = 11;
            this.button_I.Text = "ŹRÓDŁO PRĄDOWE";
            this.button_I.UseVisualStyleBackColor = true;
            this.button_I.Click += new System.EventHandler(this.button_I_Click);
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(130, 82);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(64, 64);
            this.button_R.TabIndex = 12;
            this.button_R.Text = "REZYSTOR";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(200, 82);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(64, 64);
            this.button_C.TabIndex = 13;
            this.button_C.Text = "KONDENSATOR";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(270, 82);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(64, 64);
            this.button_L.TabIndex = 14;
            this.button_L.Text = "CEWKA";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // button_Run
            // 
            this.button_Run.BackColor = System.Drawing.Color.LightGreen;
            this.button_Run.Location = new System.Drawing.Point(469, 12);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(64, 64);
            this.button_Run.TabIndex = 15;
            this.button_Run.Text = "GO GO GO";
            this.button_Run.UseVisualStyleBackColor = false;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "MODE:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "AC",
            "DC",
            "DYN"});
            this.listBox1.Location = new System.Drawing.Point(15, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(61, 104);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.button_L);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_R);
            this.Controls.Add(this.button_I);
            this.Controls.Add(this.button_U);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Raport);
            this.Name = "Form1";
            this.Text = "ELEK_NODE_SOLVER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Raport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_U;
        private System.Windows.Forms.Button button_I;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

