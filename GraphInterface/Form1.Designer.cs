
namespace GraphInterface
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 473);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(273, 26);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(128, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Backspace";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(271, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button20, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button19, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button17, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button18, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 227);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 220);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(64, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 49);
            this.button6.TabIndex = 3;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(125, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 49);
            this.button7.TabIndex = 4;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(3, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(64, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 49);
            this.button9.TabIndex = 6;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(125, 58);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 49);
            this.button10.TabIndex = 7;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(3, 113);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 49);
            this.button11.TabIndex = 8;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(64, 113);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 49);
            this.button12.TabIndex = 9;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(125, 113);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 49);
            this.button13.TabIndex = 10;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(186, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 49);
            this.button14.TabIndex = 11;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(64, 168);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 49);
            this.button15.TabIndex = 12;
            this.button15.Text = "+/-";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(186, 58);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 49);
            this.button16.TabIndex = 13;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.ForeColor = System.Drawing.Color.Red;
            this.button17.Location = new System.Drawing.Point(186, 113);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 49);
            this.button17.TabIndex = 14;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.ForeColor = System.Drawing.Color.Red;
            this.button18.Location = new System.Drawing.Point(186, 168);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 49);
            this.button18.TabIndex = 15;
            this.button18.Text = "+";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(3, 168);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 49);
            this.button19.TabIndex = 16;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.ForeColor = System.Drawing.Color.Red;
            this.button20.Location = new System.Drawing.Point(125, 168);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 49);
            this.button20.TabIndex = 17;
            this.button20.Text = "mod";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.button24, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button22, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button23, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(321, 227);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(62, 217);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.ForeColor = System.Drawing.Color.MediumBlue;
            this.button21.Location = new System.Drawing.Point(3, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 48);
            this.button21.TabIndex = 5;
            this.button21.Text = "MR";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.ForeColor = System.Drawing.Color.MediumBlue;
            this.button22.Location = new System.Drawing.Point(3, 57);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 48);
            this.button22.TabIndex = 7;
            this.button22.Text = "M+";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.ForeColor = System.Drawing.Color.MediumBlue;
            this.button23.Location = new System.Drawing.Point(3, 111);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 48);
            this.button23.TabIndex = 8;
            this.button23.Text = "MC";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.ForeColor = System.Drawing.Color.Red;
            this.button24.Location = new System.Drawing.Point(3, 165);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 49);
            this.button24.TabIndex = 9;
            this.button24.Text = "=";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 517);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

