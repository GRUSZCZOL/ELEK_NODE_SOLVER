namespace ELEK_NODE_SOLVER
{
    partial class Form_U
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Branch_V1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Branch_V2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Branch_U = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początek:";
            // 
            // textBox_Branch_V1
            // 
            this.textBox_Branch_V1.Location = new System.Drawing.Point(113, 27);
            this.textBox_Branch_V1.Name = "textBox_Branch_V1";
            this.textBox_Branch_V1.Size = new System.Drawing.Size(65, 22);
            this.textBox_Branch_V1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koniec:";
            // 
            // textBox_Branch_V2
            // 
            this.textBox_Branch_V2.Location = new System.Drawing.Point(113, 60);
            this.textBox_Branch_V2.Name = "textBox_Branch_V2";
            this.textBox_Branch_V2.Size = new System.Drawing.Size(65, 22);
            this.textBox_Branch_V2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Branch_V2);
            this.groupBox1.Controls.Add(this.textBox_Branch_V1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WĘZŁY GAŁĘZI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Branch_U);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(15, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DC PARAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Napięcie:";
            // 
            // textBox_Branch_U
            // 
            this.textBox_Branch_U.Location = new System.Drawing.Point(113, 27);
            this.textBox_Branch_U.Name = "textBox_Branch_U";
            this.textBox_Branch_U.Size = new System.Drawing.Size(65, 22);
            this.textBox_Branch_U.TabIndex = 1;
            // 
            // button_Apply
            // 
            this.button_Apply.BackColor = System.Drawing.Color.LightGreen;
            this.button_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Apply.Location = new System.Drawing.Point(128, 408);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(87, 30);
            this.button_Apply.TabIndex = 7;
            this.button_Apply.Text = "ZASTOSUJ";
            this.button_Apply.UseVisualStyleBackColor = false;
            // 
            // Form_U
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 450);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_U";
            this.Text = "Form_U";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Branch_V1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Branch_V2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Branch_U;
        private System.Windows.Forms.Button button_Apply;
    }
}