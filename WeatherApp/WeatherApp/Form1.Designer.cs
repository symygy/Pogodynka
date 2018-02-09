using System;

namespace WeatherApp
{
    partial class Weather
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMiasto = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.pbChmury = new System.Windows.Forms.PictureBox();
            this.lblZachod = new System.Windows.Forms.Label();
            this.lblWschod = new System.Windows.Forms.Label();
            this.lblWilgotnosc = new System.Windows.Forms.Label();
            this.lblCisnienie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.imagelist1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dbDzien3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbDzien3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWilg3 = new System.Windows.Forms.Label();
            this.lblCisn3 = new System.Windows.Forms.Label();
            this.lblOpis3 = new System.Windows.Forms.Label();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTMin3 = new System.Windows.Forms.Label();
            this.lblTMax3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gbDzien2 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pbDzien2 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblWilg2 = new System.Windows.Forms.Label();
            this.lblCisn2 = new System.Windows.Forms.Label();
            this.lblOpis2 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblTMin2 = new System.Windows.Forms.Label();
            this.lblTMax2 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.gbDzien1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbDzien1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblWilg1 = new System.Windows.Forms.Label();
            this.lblCisn1 = new System.Windows.Forms.Label();
            this.lblOpis1 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTMin1 = new System.Windows.Forms.Label();
            this.lblTMax1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.imagelist2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChmury)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.dbDzien3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien3)).BeginInit();
            this.gbDzien2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien2)).BeginInit();
            this.gbDzien1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMiasta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblMiasto);
            this.groupBox1.Controls.Add(this.lblKraj);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukaj miasto";
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(293, 19);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(121, 21);
            this.cbMiasta.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblMiasto
            // 
            this.lblMiasto.AutoSize = true;
            this.lblMiasto.Location = new System.Drawing.Point(53, 78);
            this.lblMiasto.Name = "lblMiasto";
            this.lblMiasto.Size = new System.Drawing.Size(10, 13);
            this.lblMiasto.TabIndex = 3;
            this.lblMiasto.Text = " ";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Location = new System.Drawing.Point(53, 53);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(10, 13);
            this.lblKraj.TabIndex = 2;
            this.lblKraj.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Miasto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kraj:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTest);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblOpis);
            this.groupBox2.Controls.Add(this.pbChmury);
            this.groupBox2.Controls.Add(this.lblZachod);
            this.groupBox2.Controls.Add(this.lblWschod);
            this.groupBox2.Controls.Add(this.lblWilgotnosc);
            this.groupBox2.Controls.Add(this.lblCisnienie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTemp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktualna pogoda";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(296, 157);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 17;
            this.lblTest.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Opis:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(80, 149);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(27, 25);
            this.lblOpis.TabIndex = 15;
            this.lblOpis.Text = " 0";
            // 
            // pbChmury
            // 
            this.pbChmury.BackColor = System.Drawing.Color.Transparent;
            this.pbChmury.Location = new System.Drawing.Point(282, 35);
            this.pbChmury.Name = "pbChmury";
            this.pbChmury.Size = new System.Drawing.Size(100, 50);
            this.pbChmury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbChmury.TabIndex = 0;
            this.pbChmury.TabStop = false;
            // 
            // lblZachod
            // 
            this.lblZachod.AutoSize = true;
            this.lblZachod.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZachod.Location = new System.Drawing.Point(80, 124);
            this.lblZachod.Name = "lblZachod";
            this.lblZachod.Size = new System.Drawing.Size(27, 25);
            this.lblZachod.TabIndex = 14;
            this.lblZachod.Text = " 0";
            // 
            // lblWschod
            // 
            this.lblWschod.AutoSize = true;
            this.lblWschod.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWschod.Location = new System.Drawing.Point(80, 99);
            this.lblWschod.Name = "lblWschod";
            this.lblWschod.Size = new System.Drawing.Size(27, 25);
            this.lblWschod.TabIndex = 13;
            this.lblWschod.Text = " 0";
            // 
            // lblWilgotnosc
            // 
            this.lblWilgotnosc.AutoSize = true;
            this.lblWilgotnosc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWilgotnosc.Location = new System.Drawing.Point(80, 74);
            this.lblWilgotnosc.Name = "lblWilgotnosc";
            this.lblWilgotnosc.Size = new System.Drawing.Size(27, 25);
            this.lblWilgotnosc.TabIndex = 12;
            this.lblWilgotnosc.Text = " 0";
            // 
            // lblCisnienie
            // 
            this.lblCisnienie.AutoSize = true;
            this.lblCisnienie.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCisnienie.Location = new System.Drawing.Point(80, 49);
            this.lblCisnienie.Name = "lblCisnienie";
            this.lblCisnienie.Size = new System.Drawing.Size(27, 25);
            this.lblCisnienie.TabIndex = 11;
            this.lblCisnienie.Text = " 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zachód:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wschód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wilgotność:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ciśnienie:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp.Location = new System.Drawing.Point(80, 24);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(27, 25);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = " 0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Temperatura:";
            // 
            // imagelist1
            // 
            this.imagelist1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist1.ImageStream")));
            this.imagelist1.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist1.Images.SetKeyName(0, "a1.png");
            this.imagelist1.Images.SetKeyName(1, "a2 (2).png");
            this.imagelist1.Images.SetKeyName(2, "a3.png");
            this.imagelist1.Images.SetKeyName(3, "a4.png");
            this.imagelist1.Images.SetKeyName(4, "a5.png");
            this.imagelist1.Images.SetKeyName(5, "a6.png");
            this.imagelist1.Images.SetKeyName(6, "a7.png");
            this.imagelist1.Images.SetKeyName(7, "a8.png");
            this.imagelist1.Images.SetKeyName(8, "a9.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dbDzien3);
            this.groupBox3.Controls.Add(this.gbDzien2);
            this.groupBox3.Controls.Add(this.gbDzien1);
            this.groupBox3.Location = new System.Drawing.Point(12, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 312);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prognoza na 5 dni";
            // 
            // dbDzien3
            // 
            this.dbDzien3.Controls.Add(this.label7);
            this.dbDzien3.Controls.Add(this.pbDzien3);
            this.dbDzien3.Controls.Add(this.label8);
            this.dbDzien3.Controls.Add(this.lblWilg3);
            this.dbDzien3.Controls.Add(this.lblCisn3);
            this.dbDzien3.Controls.Add(this.lblOpis3);
            this.dbDzien3.Controls.Add(this.lblTemp3);
            this.dbDzien3.Controls.Add(this.label21);
            this.dbDzien3.Controls.Add(this.lblTMin3);
            this.dbDzien3.Controls.Add(this.lblTMax3);
            this.dbDzien3.Controls.Add(this.label24);
            this.dbDzien3.Controls.Add(this.label25);
            this.dbDzien3.Controls.Add(this.label26);
            this.dbDzien3.Location = new System.Drawing.Point(322, 28);
            this.dbDzien3.Name = "dbDzien3";
            this.dbDzien3.Size = new System.Drawing.Size(161, 284);
            this.dbDzien3.TabIndex = 30;
            this.dbDzien3.TabStop = false;
            this.dbDzien3.Text = "3 dzień";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 28;
            this.label7.Text = "Opis:";
            // 
            // pbDzien3
            // 
            this.pbDzien3.Location = new System.Drawing.Point(22, 29);
            this.pbDzien3.Name = "pbDzien3";
            this.pbDzien3.Size = new System.Drawing.Size(100, 50);
            this.pbDzien3.TabIndex = 1;
            this.pbDzien3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ciśnienie:";
            // 
            // lblWilg3
            // 
            this.lblWilg3.AutoSize = true;
            this.lblWilg3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWilg3.ForeColor = System.Drawing.Color.Red;
            this.lblWilg3.Location = new System.Drawing.Point(75, 183);
            this.lblWilg3.Name = "lblWilg3";
            this.lblWilg3.Size = new System.Drawing.Size(16, 14);
            this.lblWilg3.TabIndex = 24;
            this.lblWilg3.Text = " 0";
            // 
            // lblCisn3
            // 
            this.lblCisn3.AutoSize = true;
            this.lblCisn3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCisn3.ForeColor = System.Drawing.Color.Red;
            this.lblCisn3.Location = new System.Drawing.Point(75, 158);
            this.lblCisn3.Name = "lblCisn3";
            this.lblCisn3.Size = new System.Drawing.Size(16, 14);
            this.lblCisn3.TabIndex = 23;
            this.lblCisn3.Text = " 0";
            // 
            // lblOpis3
            // 
            this.lblOpis3.AutoSize = true;
            this.lblOpis3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis3.ForeColor = System.Drawing.Color.Red;
            this.lblOpis3.Location = new System.Drawing.Point(37, 258);
            this.lblOpis3.Name = "lblOpis3";
            this.lblOpis3.Size = new System.Drawing.Size(16, 14);
            this.lblOpis3.TabIndex = 27;
            this.lblOpis3.Text = " 0";
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp3.ForeColor = System.Drawing.Color.Red;
            this.lblTemp3.Location = new System.Drawing.Point(75, 133);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(16, 14);
            this.lblTemp3.TabIndex = 18;
            this.lblTemp3.Text = " 0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(9, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 20;
            this.label21.Text = "Wilgotność:";
            // 
            // lblTMin3
            // 
            this.lblTMin3.AutoSize = true;
            this.lblTMin3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMin3.ForeColor = System.Drawing.Color.Red;
            this.lblTMin3.Location = new System.Drawing.Point(75, 208);
            this.lblTMin3.Name = "lblTMin3";
            this.lblTMin3.Size = new System.Drawing.Size(16, 14);
            this.lblTMin3.TabIndex = 25;
            this.lblTMin3.Text = " 0";
            // 
            // lblTMax3
            // 
            this.lblTMax3.AutoSize = true;
            this.lblTMax3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMax3.ForeColor = System.Drawing.Color.Red;
            this.lblTMax3.Location = new System.Drawing.Point(75, 233);
            this.lblTMax3.Name = "lblTMax3";
            this.lblTMax3.Size = new System.Drawing.Size(16, 14);
            this.lblTMax3.TabIndex = 26;
            this.lblTMax3.Text = " 0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(9, 233);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 14);
            this.label24.TabIndex = 22;
            this.label24.Text = "Temp. max.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(9, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 14);
            this.label25.TabIndex = 21;
            this.label25.Text = "Temp. min.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(9, 133);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 14);
            this.label26.TabIndex = 17;
            this.label26.Text = "Temperatura:";
            // 
            // gbDzien2
            // 
            this.gbDzien2.Controls.Add(this.label27);
            this.gbDzien2.Controls.Add(this.pbDzien2);
            this.gbDzien2.Controls.Add(this.label28);
            this.gbDzien2.Controls.Add(this.lblWilg2);
            this.gbDzien2.Controls.Add(this.lblCisn2);
            this.gbDzien2.Controls.Add(this.lblOpis2);
            this.gbDzien2.Controls.Add(this.lblTemp2);
            this.gbDzien2.Controls.Add(this.label33);
            this.gbDzien2.Controls.Add(this.lblTMin2);
            this.gbDzien2.Controls.Add(this.lblTMax2);
            this.gbDzien2.Controls.Add(this.label36);
            this.gbDzien2.Controls.Add(this.label37);
            this.gbDzien2.Controls.Add(this.label38);
            this.gbDzien2.Location = new System.Drawing.Point(157, 28);
            this.gbDzien2.Name = "gbDzien2";
            this.gbDzien2.Size = new System.Drawing.Size(159, 284);
            this.gbDzien2.TabIndex = 29;
            this.gbDzien2.TabStop = false;
            this.gbDzien2.Text = "2 dzień";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(9, 258);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 14);
            this.label27.TabIndex = 28;
            this.label27.Text = "Opis:";
            // 
            // pbDzien2
            // 
            this.pbDzien2.Location = new System.Drawing.Point(22, 29);
            this.pbDzien2.Name = "pbDzien2";
            this.pbDzien2.Size = new System.Drawing.Size(100, 50);
            this.pbDzien2.TabIndex = 1;
            this.pbDzien2.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(9, 158);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 14);
            this.label28.TabIndex = 19;
            this.label28.Text = "Ciśnienie:";
            // 
            // lblWilg2
            // 
            this.lblWilg2.AutoSize = true;
            this.lblWilg2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWilg2.ForeColor = System.Drawing.Color.Red;
            this.lblWilg2.Location = new System.Drawing.Point(75, 183);
            this.lblWilg2.Name = "lblWilg2";
            this.lblWilg2.Size = new System.Drawing.Size(16, 14);
            this.lblWilg2.TabIndex = 24;
            this.lblWilg2.Text = " 0";
            // 
            // lblCisn2
            // 
            this.lblCisn2.AutoSize = true;
            this.lblCisn2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCisn2.ForeColor = System.Drawing.Color.Red;
            this.lblCisn2.Location = new System.Drawing.Point(75, 158);
            this.lblCisn2.Name = "lblCisn2";
            this.lblCisn2.Size = new System.Drawing.Size(16, 14);
            this.lblCisn2.TabIndex = 23;
            this.lblCisn2.Text = " 0";
            // 
            // lblOpis2
            // 
            this.lblOpis2.AutoSize = true;
            this.lblOpis2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis2.ForeColor = System.Drawing.Color.Red;
            this.lblOpis2.Location = new System.Drawing.Point(37, 258);
            this.lblOpis2.Name = "lblOpis2";
            this.lblOpis2.Size = new System.Drawing.Size(16, 14);
            this.lblOpis2.TabIndex = 27;
            this.lblOpis2.Text = " 0";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp2.ForeColor = System.Drawing.Color.Red;
            this.lblTemp2.Location = new System.Drawing.Point(75, 133);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(16, 14);
            this.lblTemp2.TabIndex = 18;
            this.lblTemp2.Text = " 0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label33.Location = new System.Drawing.Point(9, 183);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 14);
            this.label33.TabIndex = 20;
            this.label33.Text = "Wilgotność:";
            // 
            // lblTMin2
            // 
            this.lblTMin2.AutoSize = true;
            this.lblTMin2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMin2.ForeColor = System.Drawing.Color.Red;
            this.lblTMin2.Location = new System.Drawing.Point(75, 208);
            this.lblTMin2.Name = "lblTMin2";
            this.lblTMin2.Size = new System.Drawing.Size(16, 14);
            this.lblTMin2.TabIndex = 25;
            this.lblTMin2.Text = " 0";
            // 
            // lblTMax2
            // 
            this.lblTMax2.AutoSize = true;
            this.lblTMax2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMax2.ForeColor = System.Drawing.Color.Red;
            this.lblTMax2.Location = new System.Drawing.Point(75, 233);
            this.lblTMax2.Name = "lblTMax2";
            this.lblTMax2.Size = new System.Drawing.Size(16, 14);
            this.lblTMax2.TabIndex = 26;
            this.lblTMax2.Text = " 0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label36.Location = new System.Drawing.Point(9, 233);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 14);
            this.label36.TabIndex = 22;
            this.label36.Text = "Temp. max.";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label37.Location = new System.Drawing.Point(9, 208);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 14);
            this.label37.TabIndex = 21;
            this.label37.Text = "Temp. min.";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label38.Location = new System.Drawing.Point(9, 133);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 14);
            this.label38.TabIndex = 17;
            this.label38.Text = "Temperatura:";
            // 
            // gbDzien1
            // 
            this.gbDzien1.Controls.Add(this.label6);
            this.gbDzien1.Controls.Add(this.pbDzien1);
            this.gbDzien1.Controls.Add(this.label18);
            this.gbDzien1.Controls.Add(this.lblWilg1);
            this.gbDzien1.Controls.Add(this.lblCisn1);
            this.gbDzien1.Controls.Add(this.lblOpis1);
            this.gbDzien1.Controls.Add(this.lblTemp1);
            this.gbDzien1.Controls.Add(this.label17);
            this.gbDzien1.Controls.Add(this.lblTMin1);
            this.gbDzien1.Controls.Add(this.lblTMax1);
            this.gbDzien1.Controls.Add(this.label15);
            this.gbDzien1.Controls.Add(this.label16);
            this.gbDzien1.Controls.Add(this.label20);
            this.gbDzien1.Location = new System.Drawing.Point(3, 27);
            this.gbDzien1.Name = "gbDzien1";
            this.gbDzien1.Size = new System.Drawing.Size(148, 284);
            this.gbDzien1.TabIndex = 3;
            this.gbDzien1.TabStop = false;
            this.gbDzien1.Text = "1 dzień";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "Opis:";
            // 
            // pbDzien1
            // 
            this.pbDzien1.Location = new System.Drawing.Point(22, 29);
            this.pbDzien1.Name = "pbDzien1";
            this.pbDzien1.Size = new System.Drawing.Size(100, 50);
            this.pbDzien1.TabIndex = 1;
            this.pbDzien1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(9, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 14);
            this.label18.TabIndex = 19;
            this.label18.Text = "Ciśnienie:";
            // 
            // lblWilg1
            // 
            this.lblWilg1.AutoSize = true;
            this.lblWilg1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWilg1.ForeColor = System.Drawing.Color.Red;
            this.lblWilg1.Location = new System.Drawing.Point(75, 183);
            this.lblWilg1.Name = "lblWilg1";
            this.lblWilg1.Size = new System.Drawing.Size(16, 14);
            this.lblWilg1.TabIndex = 24;
            this.lblWilg1.Text = " 0";
            // 
            // lblCisn1
            // 
            this.lblCisn1.AutoSize = true;
            this.lblCisn1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCisn1.ForeColor = System.Drawing.Color.Red;
            this.lblCisn1.Location = new System.Drawing.Point(75, 158);
            this.lblCisn1.Name = "lblCisn1";
            this.lblCisn1.Size = new System.Drawing.Size(16, 14);
            this.lblCisn1.TabIndex = 23;
            this.lblCisn1.Text = " 0";
            // 
            // lblOpis1
            // 
            this.lblOpis1.AutoSize = true;
            this.lblOpis1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis1.ForeColor = System.Drawing.Color.Red;
            this.lblOpis1.Location = new System.Drawing.Point(37, 258);
            this.lblOpis1.Name = "lblOpis1";
            this.lblOpis1.Size = new System.Drawing.Size(16, 14);
            this.lblOpis1.TabIndex = 27;
            this.lblOpis1.Text = " 0";
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp1.ForeColor = System.Drawing.Color.Red;
            this.lblTemp1.Location = new System.Drawing.Point(75, 133);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(16, 14);
            this.lblTemp1.TabIndex = 18;
            this.lblTemp1.Tag = "edytowalne";
            this.lblTemp1.Text = " 0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(9, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 14);
            this.label17.TabIndex = 20;
            this.label17.Text = "Wilgotność:";
            // 
            // lblTMin1
            // 
            this.lblTMin1.AutoSize = true;
            this.lblTMin1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMin1.ForeColor = System.Drawing.Color.Red;
            this.lblTMin1.Location = new System.Drawing.Point(75, 208);
            this.lblTMin1.Name = "lblTMin1";
            this.lblTMin1.Size = new System.Drawing.Size(16, 14);
            this.lblTMin1.TabIndex = 25;
            this.lblTMin1.Text = " 0";
            // 
            // lblTMax1
            // 
            this.lblTMax1.AutoSize = true;
            this.lblTMax1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTMax1.ForeColor = System.Drawing.Color.Red;
            this.lblTMax1.Location = new System.Drawing.Point(75, 233);
            this.lblTMax1.Name = "lblTMax1";
            this.lblTMax1.Size = new System.Drawing.Size(16, 14);
            this.lblTMax1.TabIndex = 26;
            this.lblTMax1.Text = " 0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(9, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 22;
            this.label15.Text = "Temp. max.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(9, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 14);
            this.label16.TabIndex = 21;
            this.label16.Text = "Temp. min.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(9, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 14);
            this.label20.TabIndex = 17;
            this.label20.Text = "Temperatura:";
            // 
            // imagelist2
            // 
            this.imagelist2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imagelist2.ImageSize = new System.Drawing.Size(32, 32);
            this.imagelist2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Weather";
            this.Text = "Weather App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChmury)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.dbDzien3.ResumeLayout(false);
            this.dbDzien3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien3)).EndInit();
            this.gbDzien2.ResumeLayout(false);
            this.gbDzien2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien2)).EndInit();
            this.gbDzien1.ResumeLayout(false);
            this.gbDzien1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDzien1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMiasto;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblZachod;
        private System.Windows.Forms.Label lblWschod;
        private System.Windows.Forms.Label lblWilgotnosc;
        private System.Windows.Forms.Label lblCisnienie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbChmury;
        private System.Windows.Forms.ImageList imagelist1;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ImageList imagelist2;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.GroupBox dbDzien3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbDzien3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWilg3;
        private System.Windows.Forms.Label lblCisn3;
        private System.Windows.Forms.Label lblOpis3;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTMin3;
        private System.Windows.Forms.Label lblTMax3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbDzien2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pbDzien2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblWilg2;
        private System.Windows.Forms.Label lblCisn2;
        private System.Windows.Forms.Label lblOpis2;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblTMin2;
        private System.Windows.Forms.Label lblTMax2;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox gbDzien1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbDzien1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblWilg1;
        private System.Windows.Forms.Label lblCisn1;
        private System.Windows.Forms.Label lblOpis1;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTMin1;
        private System.Windows.Forms.Label lblTMax1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;

        public EventHandler button1_ClickAsync { get; private set; }
    }
}

