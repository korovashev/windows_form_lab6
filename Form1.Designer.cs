namespace lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            tabControl1 = new TabControl();
            task1 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            task2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            task3 = new TabPage();
            task4 = new TabPage();
            textBox2 = new TextBox();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            task1.SuspendLayout();
            task2.SuspendLayout();
            task4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(task1);
            tabControl1.Controls.Add(task2);
            tabControl1.Controls.Add(task3);
            tabControl1.Controls.Add(task4);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 451);
            tabControl1.TabIndex = 0;
            // 
            // task1
            // 
            task1.BackColor = Color.Indigo;
            task1.Controls.Add(button1);
            task1.Controls.Add(textBox1);
            task1.Location = new Point(4, 24);
            task1.Name = "task1";
            task1.Padding = new Padding(3);
            task1.Size = new Size(795, 423);
            task1.TabIndex = 0;
            task1.Text = "task1";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Dela Gothic One", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(138, 217);
            button1.Name = "button1";
            button1.Size = new Size(515, 92);
            button1.TabIndex = 1;
            button1.Text = "Проверить на делимость на 3";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(342, 134);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Число";
            textBox1.Size = new Size(119, 25);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // task2
            // 
            task2.BackColor = Color.OldLace;
            task2.Controls.Add(checkedListBox1);
            task2.Controls.Add(panel1);
            task2.Location = new Point(4, 24);
            task2.Name = "task2";
            task2.Padding = new Padding(3);
            task2.Size = new Size(795, 423);
            task2.TabIndex = 1;
            task2.Text = "task2";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Brown;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.ForeColor = SystemColors.Window;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "orange", "green", "blue", "pink", "magenta" });
            checkedListBox1.Location = new Point(144, 143);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(125, 104);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(458, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 0;
            // 
            // task3
            // 
            task3.Location = new Point(4, 24);
            task3.Name = "task3";
            task3.Size = new Size(795, 423);
            task3.TabIndex = 2;
            task3.Text = "task3";
            task3.UseVisualStyleBackColor = true;
            // 
            // task4
            // 
            task4.BackColor = Color.DarkGreen;
            task4.Controls.Add(textBox2);
            task4.Controls.Add(button21);
            task4.Controls.Add(button20);
            task4.Controls.Add(button19);
            task4.Controls.Add(button18);
            task4.Controls.Add(button17);
            task4.Controls.Add(button16);
            task4.Controls.Add(button15);
            task4.Controls.Add(button14);
            task4.Controls.Add(button13);
            task4.Controls.Add(button10);
            task4.Controls.Add(button11);
            task4.Controls.Add(button12);
            task4.Controls.Add(button7);
            task4.Controls.Add(button8);
            task4.Controls.Add(button9);
            task4.Controls.Add(button6);
            task4.Controls.Add(button5);
            task4.Controls.Add(button4);
            task4.Location = new Point(4, 24);
            task4.Name = "task4";
            task4.Size = new Size(795, 423);
            task4.TabIndex = 3;
            task4.Text = "task4";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(137, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 25);
            textBox2.TabIndex = 18;
            // 
            // button21
            // 
            button21.BackColor = Color.DarkOrange;
            button21.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button21.ForeColor = SystemColors.Control;
            button21.Location = new Point(583, 290);
            button21.Name = "button21";
            button21.Size = new Size(85, 32);
            button21.TabIndex = 17;
            button21.Text = "Clear";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.DarkOrange;
            button20.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.Control;
            button20.Location = new Point(480, 290);
            button20.Name = "button20";
            button20.Size = new Size(85, 32);
            button20.TabIndex = 16;
            button20.Text = "Delete";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.DarkOrange;
            button19.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button19.ForeColor = SystemColors.Control;
            button19.Location = new Point(583, 242);
            button19.Name = "button19";
            button19.Size = new Size(85, 32);
            button19.TabIndex = 15;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.DarkOrange;
            button18.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.Control;
            button18.Location = new Point(480, 242);
            button18.Name = "button18";
            button18.Size = new Size(85, 32);
            button18.TabIndex = 14;
            button18.Text = "^2";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DarkOrange;
            button17.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.Control;
            button17.Location = new Point(583, 194);
            button17.Name = "button17";
            button17.Size = new Size(85, 32);
            button17.TabIndex = 13;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkOrange;
            button16.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(480, 194);
            button16.Name = "button16";
            button16.Size = new Size(85, 32);
            button16.TabIndex = 12;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DarkOrange;
            button15.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(583, 147);
            button15.Name = "button15";
            button15.Size = new Size(85, 32);
            button15.TabIndex = 11;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.DarkOrange;
            button14.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.Control;
            button14.Location = new Point(480, 147);
            button14.Name = "button14";
            button14.Size = new Size(85, 32);
            button14.TabIndex = 10;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkOrange;
            button13.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.Control;
            button13.Location = new Point(228, 290);
            button13.Name = "button13";
            button13.Size = new Size(85, 32);
            button13.TabIndex = 9;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkOrange;
            button10.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(137, 242);
            button10.Name = "button10";
            button10.Size = new Size(85, 32);
            button10.TabIndex = 8;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkOrange;
            button11.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(228, 242);
            button11.Name = "button11";
            button11.Size = new Size(85, 32);
            button11.TabIndex = 7;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkOrange;
            button12.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(319, 242);
            button12.Name = "button12";
            button12.Size = new Size(85, 32);
            button12.TabIndex = 6;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkOrange;
            button7.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(137, 194);
            button7.Name = "button7";
            button7.Size = new Size(85, 32);
            button7.TabIndex = 5;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(228, 194);
            button8.Name = "button8";
            button8.Size = new Size(85, 32);
            button8.TabIndex = 4;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkOrange;
            button9.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(319, 194);
            button9.Name = "button9";
            button9.Size = new Size(85, 32);
            button9.TabIndex = 3;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(319, 147);
            button6.Name = "button6";
            button6.Size = new Size(85, 32);
            button6.TabIndex = 2;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(228, 147);
            button5.Name = "button5";
            button5.Size = new Size(85, 32);
            button5.TabIndex = 1;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Dela Gothic One", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(137, 147);
            button4.Name = "button4";
            button4.Size = new Size(85, 32);
            button4.TabIndex = 0;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Lab 6";
            tabControl1.ResumeLayout(false);
            task1.ResumeLayout(false);
            task1.PerformLayout();
            task2.ResumeLayout(false);
            task4.ResumeLayout(false);
            task4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage task1;
        private TabPage task2;
        private TabPage task3;
        private TabPage task4;
        private Button button1;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Button button13;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private TextBox textBox2;
    }
}