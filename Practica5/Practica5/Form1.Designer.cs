/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 02/05/2014
 * Time: 10:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica5
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.numericEstados1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.BoxRusia = new System.Windows.Forms.CheckBox();
			this.BoxJapon = new System.Windows.Forms.CheckBox();
			this.BoxAlemania = new System.Windows.Forms.CheckBox();
			this.BoxReinoUnido = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radBut_Berlusconi = new System.Windows.Forms.RadioButton();
			this.radBut_Hitler = new System.Windows.Forms.RadioButton();
			this.radBut_Mussolini = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxPais = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.term_button1 = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			((System.ComponentModel.ISupportInitialize)(this.numericEstados1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "1. Numero de estados de la Republica Méxicanos";
			// 
			// numericEstados1
			// 
			this.numericEstados1.Location = new System.Drawing.Point(50, 52);
			this.numericEstados1.Name = "numericEstados1";
			this.numericEstados1.Size = new System.Drawing.Size(120, 20);
			this.numericEstados1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "2. Paises aliados que conformaron la  segunda guerra mundial";
			// 
			// BoxRusia
			// 
			this.BoxRusia.Location = new System.Drawing.Point(24, 145);
			this.BoxRusia.Name = "BoxRusia";
			this.BoxRusia.Size = new System.Drawing.Size(104, 24);
			this.BoxRusia.TabIndex = 3;
			this.BoxRusia.Text = "Rusia";
			this.BoxRusia.UseVisualStyleBackColor = true;
			// 
			// BoxJapon
			// 
			this.BoxJapon.Location = new System.Drawing.Point(24, 175);
			this.BoxJapon.Name = "BoxJapon";
			this.BoxJapon.Size = new System.Drawing.Size(104, 24);
			this.BoxJapon.TabIndex = 4;
			this.BoxJapon.Text = "Japon";
			this.BoxJapon.UseVisualStyleBackColor = true;
			this.BoxJapon.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// BoxAlemania
			// 
			this.BoxAlemania.Location = new System.Drawing.Point(24, 205);
			this.BoxAlemania.Name = "BoxAlemania";
			this.BoxAlemania.Size = new System.Drawing.Size(104, 24);
			this.BoxAlemania.TabIndex = 5;
			this.BoxAlemania.Text = "Alemania";
			this.BoxAlemania.UseVisualStyleBackColor = true;
			// 
			// BoxReinoUnido
			// 
			this.BoxReinoUnido.Location = new System.Drawing.Point(24, 235);
			this.BoxReinoUnido.Name = "BoxReinoUnido";
			this.BoxReinoUnido.Size = new System.Drawing.Size(104, 24);
			this.BoxReinoUnido.TabIndex = 6;
			this.BoxReinoUnido.Text = "Reino Unido";
			this.BoxReinoUnido.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(269, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "3. Dictador de Italia durante la segunda guerra mundial";
			// 
			// radBut_Berlusconi
			// 
			this.radBut_Berlusconi.Location = new System.Drawing.Point(38, 325);
			this.radBut_Berlusconi.Name = "radBut_Berlusconi";
			this.radBut_Berlusconi.Size = new System.Drawing.Size(104, 24);
			this.radBut_Berlusconi.TabIndex = 8;
			this.radBut_Berlusconi.TabStop = true;
			this.radBut_Berlusconi.Text = "Berlusconi";
			this.radBut_Berlusconi.UseVisualStyleBackColor = true;
			// 
			// radBut_Hitler
			// 
			this.radBut_Hitler.Location = new System.Drawing.Point(38, 295);
			this.radBut_Hitler.Name = "radBut_Hitler";
			this.radBut_Hitler.Size = new System.Drawing.Size(104, 24);
			this.radBut_Hitler.TabIndex = 9;
			this.radBut_Hitler.TabStop = true;
			this.radBut_Hitler.Text = "Hitler";
			this.radBut_Hitler.UseVisualStyleBackColor = true;
			// 
			// radBut_Mussolini
			// 
			this.radBut_Mussolini.Location = new System.Drawing.Point(38, 355);
			this.radBut_Mussolini.Name = "radBut_Mussolini";
			this.radBut_Mussolini.Size = new System.Drawing.Size(104, 24);
			this.radBut_Mussolini.TabIndex = 10;
			this.radBut_Mussolini.TabStop = true;
			this.radBut_Mussolini.Text = "Mussolini";
			this.radBut_Mussolini.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 397);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(250, 34);
			this.label4.TabIndex = 11;
			this.label4.Text = "4. En que continente se encuentra el pais Tuvalu";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// comboBoxPais
			// 
			this.comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] {
									"America",
									"Oceania\t",
									"Africa\t",
									"Asia",
									"Europa"});
			this.comboBoxPais.FormattingEnabled = true;
			this.comboBoxPais.Items.AddRange(new object[] {
									"America",
									"Europa",
									"Asia",
									"Oceania",
									"Africa"});
			this.comboBoxPais.Location = new System.Drawing.Point(24, 434);
			this.comboBoxPais.Name = "comboBoxPais";
			this.comboBoxPais.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPais.TabIndex = 12;
			this.comboBoxPais.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 484);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "5. Fecha del grito de dolores";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// term_button1
			// 
			this.term_button1.BackColor = System.Drawing.SystemColors.Window;
			this.term_button1.Location = new System.Drawing.Point(309, 751);
			this.term_button1.Name = "term_button1";
			this.term_button1.Size = new System.Drawing.Size(179, 37);
			this.term_button1.TabIndex = 15;
			this.term_button1.Text = "Terminar";
			this.term_button1.UseVisualStyleBackColor = false;
			this.term_button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(18, 516);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 16;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1DateChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(753, 814);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.term_button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxPais);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radBut_Mussolini);
			this.Controls.Add(this.radBut_Hitler);
			this.Controls.Add(this.radBut_Berlusconi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BoxReinoUnido);
			this.Controls.Add(this.BoxAlemania);
			this.Controls.Add(this.BoxJapon);
			this.Controls.Add(this.BoxRusia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericEstados1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.numericEstados1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button term_button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxPais;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radBut_Mussolini;
		private System.Windows.Forms.RadioButton radBut_Hitler;
		private System.Windows.Forms.RadioButton radBut_Berlusconi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox BoxReinoUnido;
		private System.Windows.Forms.CheckBox BoxAlemania;
		private System.Windows.Forms.CheckBox BoxJapon;
		private System.Windows.Forms.CheckBox BoxRusia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericEstados1;
		private System.Windows.Forms.Label label1;
		
		void Form1Load(object sender, System.EventArgs e)
		{
			
		}
	}
}
