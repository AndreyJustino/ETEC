/*
 * Created by SharpDevelop.
 * User: Alunos
 * Date: 08/04/2022
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dados
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		Random rnd = new Random();
		int sortea1, sortea2, sortea3, pontuacao;
		
		
		void Button1Click(object sender, EventArgs e)
		{
			pontuacao = 0;
			sortea1 = rnd.Next(1,7);
			
			if (sortea1 == 1) 
			{
				pictureBox1.Load("dado1.png");
			}
			else if(sortea1 == 2)
			{
				pictureBox1.Load("dado2.png");
			}
			else if(sortea1 == 3)
			{
				pictureBox1.Load("dado3.png");
			}
			else if(sortea1 == 4)
			{
				pictureBox1.Load("dado4.png");
			}
			else if(sortea1 == 5)
			{
				pictureBox1.Load("dado5.png");
			}
			else if(sortea1 == 6)
			{
				pictureBox1.Load("dado6.png");
			}
			
			sortea2 = rnd.Next(1,7);
			
			if (sortea2 == 1) 
			{
				pictureBox2.Load("dado1.png");
			}
			else if(sortea2 == 2)
			{
				pictureBox2.Load("dado2.png");
			}
			else if(sortea2 == 3)
			{
				pictureBox2.Load("dado3.png");
			}
			else if(sortea2 == 4)
			{
				pictureBox2.Load("dado4.png");
			}
			else if(sortea2 == 5)
			{
				pictureBox2.Load("dado5.png");
			}
			else if(sortea2 == 6)
			{
				pictureBox2.Load("dado6.png");
			}
			
			sortea3 = rnd.Next(1,7);
			
			if (sortea3 == 1) 
			{
				pictureBox3.Load("dado1.png");
			}
			else if(sortea3 == 2)
			{
				pictureBox3.Load("dado2.png");
			}
			else if(sortea3 == 3)
			{
				pictureBox3.Load("dado3.png");
			}
			else if(sortea3 == 4)
			{
				pictureBox3.Load("dado4.png");
			}
			else if(sortea3 == 5)
			{
				pictureBox3.Load("dado5.png");
			}
			else if(sortea3 == 6)
			{
				pictureBox3.Load("dado6.png");
			}
			
			if (sortea1 == 6 && sortea2 == 6 && sortea3 == 6)
			{
				MessageBox.Show("Você fez uma trinca!");
				pontuacao = pontuacao + 1;
				textBox1.Text = pontuacao.ToString();
			}
		}
	}
}
