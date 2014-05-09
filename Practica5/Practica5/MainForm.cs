/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 02/05/2014
 * Time: 10:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
     
       	if(Box1.Text == "arturo" && Box2.Text == "666")
			   {
			   	
				Form1 a = new Form1();
				a.Show(); 
				this.Hide();
			   
			   	
			   }
			   else
			   	MessageBox.Show("Error" );		
		}
	}
}
