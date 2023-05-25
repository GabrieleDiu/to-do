namespace WinFormsApp2
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
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editorToolStripMenuItem = new ToolStripMenuItem();
            salveazaToolStripMenuItem = new ToolStripMenuItem();
            salveazaCaToolStripMenuItem = new ToolStripMenuItem();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            editareToolStripMenuItem = new ToolStripMenuItem();
            adaugaSarcinaToolStripMenuItem = new ToolStripMenuItem();
            editeazaSarcinaToolStripMenuItem = new ToolStripMenuItem();
            eliminaSarcinaToolStripMenuItem = new ToolStripMenuItem();
            ajutoToolStripMenuItem = new ToolStripMenuItem();
            despreToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Salvare = new Button();
            button2 = new Button();
            button1 = new Button();
            deschidereToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, editareToolStripMenuItem, ajutoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, editorToolStripMenuItem, salveazaToolStripMenuItem, salveazaCaToolStripMenuItem, iesireToolStripMenuItem, deschidereToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(46, 20);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Nou";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(180, 22);
            editorToolStripMenuItem.Text = "Editor";
            // 
            // salveazaToolStripMenuItem
            // 
            salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            salveazaToolStripMenuItem.Size = new Size(180, 22);
            salveazaToolStripMenuItem.Text = "Salveaza";
            salveazaToolStripMenuItem.Click += salveazaToolStripMenuItem_Click;
            // 
            // salveazaCaToolStripMenuItem
            // 
            salveazaCaToolStripMenuItem.Name = "salveazaCaToolStripMenuItem";
            salveazaCaToolStripMenuItem.Size = new Size(180, 22);
            salveazaCaToolStripMenuItem.Text = "Salveaza ca";
            salveazaCaToolStripMenuItem.Click += salveazaCaToolStripMenuItem_Click;
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(180, 22);
            iesireToolStripMenuItem.Text = "Iesire";
            iesireToolStripMenuItem.Click += iesireToolStripMenuItem_Click;
            // 
            // editareToolStripMenuItem
            // 
            editareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaSarcinaToolStripMenuItem, editeazaSarcinaToolStripMenuItem, eliminaSarcinaToolStripMenuItem });
            editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            editareToolStripMenuItem.Size = new Size(55, 20);
            editareToolStripMenuItem.Text = "Editare";
            // 
            // adaugaSarcinaToolStripMenuItem
            // 
            adaugaSarcinaToolStripMenuItem.Name = "adaugaSarcinaToolStripMenuItem";
            adaugaSarcinaToolStripMenuItem.Size = new Size(157, 22);
            adaugaSarcinaToolStripMenuItem.Text = "Adauga sarcina";
            adaugaSarcinaToolStripMenuItem.Click += adaugaSarcinaToolStripMenuItem_Click;
            // 
            // editeazaSarcinaToolStripMenuItem
            // 
            editeazaSarcinaToolStripMenuItem.Name = "editeazaSarcinaToolStripMenuItem";
            editeazaSarcinaToolStripMenuItem.Size = new Size(157, 22);
            editeazaSarcinaToolStripMenuItem.Text = "Editeaza sarcina";
            editeazaSarcinaToolStripMenuItem.Click += editeazaSarcinaToolStripMenuItem_Click;
            // 
            // eliminaSarcinaToolStripMenuItem
            // 
            eliminaSarcinaToolStripMenuItem.Name = "eliminaSarcinaToolStripMenuItem";
            eliminaSarcinaToolStripMenuItem.Size = new Size(157, 22);
            eliminaSarcinaToolStripMenuItem.Text = "Elimina sarcina ";
            eliminaSarcinaToolStripMenuItem.Click += eliminaSarcinaToolStripMenuItem_Click;
            // 
            // ajutoToolStripMenuItem
            // 
            ajutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despreToolStripMenuItem });
            ajutoToolStripMenuItem.Name = "ajutoToolStripMenuItem";
            ajutoToolStripMenuItem.Size = new Size(48, 20);
            ajutoToolStripMenuItem.Text = "Ajuto";
            // 
            // despreToolStripMenuItem
            // 
            despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            despreToolStripMenuItem.Size = new Size(110, 22);
            despreToolStripMenuItem.Text = "Despre";
            despreToolStripMenuItem.Click += despreToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(511, 394);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(599, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Visible = false;
            textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(599, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(597, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2023, 3, 30, 15, 18, 59, 0);
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(554, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 141);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 3;
            label1.Text = "Cat de importatnt este activitatea";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(14, 116);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(114, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Foarte Important";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Important";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Neimportant";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Salvare
            // 
            Salvare.Location = new Point(624, 392);
            Salvare.Name = "Salvare";
            Salvare.Size = new Size(75, 23);
            Salvare.TabIndex = 6;
            Salvare.Text = "salvare";
            Salvare.UseVisualStyleBackColor = true;
            Salvare.Visible = false;
            Salvare.Click += Salvare_Click;
            // 
            // button2
            // 
            button2.Location = new Point(624, 363);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Stergere";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(624, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Editare";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // deschidereToolStripMenuItem
            // 
            deschidereToolStripMenuItem.Name = "deschidereToolStripMenuItem";
            deschidereToolStripMenuItem.Size = new Size(180, 22);
            deschidereToolStripMenuItem.Text = "Deschidere";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(Salvare);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "me";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editareToolStripMenuItem;
        private ToolStripMenuItem ajutoToolStripMenuItem;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem salveazaToolStripMenuItem;
        private ToolStripMenuItem salveazaCaToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private ToolStripMenuItem adaugaSarcinaToolStripMenuItem;
        private ToolStripMenuItem editeazaSarcinaToolStripMenuItem;
        private ToolStripMenuItem eliminaSarcinaToolStripMenuItem;
        private ToolStripMenuItem despreToolStripMenuItem;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Label label1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button Salvare;
        private Button button2;
        private Button button1;
        private ToolStripMenuItem deschidereToolStripMenuItem;
    }
}