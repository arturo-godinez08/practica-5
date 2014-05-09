/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 02/05/2014
 * Time: 10:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica5
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
        
            //string Eva="";
            int cont=0;
            
            if(numericEstados1.Value == 30)
            	
            	cont++;
            
            if(this.BoxReinoUnido.Checked && this.BoxRusia.Checked)
            	
            	cont++;
            if(this.radBut_Mussolini.Checked)
            	
            	cont++;
            if(comboBoxPais.SelectedItem == "Oceania")
            	
            	cont++;
            
            if(monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810")
            	
                  cont++;
                  
            System.Windows.Forms.MessageBox.Show("respuestas correctas: "+ cont);
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
	}
}
