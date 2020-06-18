using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void dugum(string[] data1 , string[,]data2 , int uz,int sira)
        {
            int toplam = 0;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < uz; j++)
                {
                    
                    if(data2[i, j] == "1"  ) 
                    {
                        toplam += int.Parse(data1[j]);
                    }
                }
            }
            label2.Text += toplam;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] data1,tmp;
            label2.Text = "";
            int uz,uz2;
            using (StreamReader sr = new StreamReader(@"C:\Users\damla\source\repos\final\data1.txt"))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
                label1.Text = line;
                data1 = line.Split(' ');
                uz = data1.Length;
            }

         /*   for(int i=0;i<uz;i++)
            {
                label2.Text += data1[i];
            }*/
            string[,] data2 = new string[uz,uz];
            using (StreamReader sr = new StreamReader(@"C:\Users\damla\source\repos\final\data2.txt"))
            {
                String line2 = sr.ReadToEnd();                
                tmp = line2.Split(' ', '\n');              
                uz2 = tmp.Length;
            }

      
             int sayac = 0;
             for (int i=0;i<uz;i++)
             {
                 for (int j = 0; j <uz; j++)
                 {
                     data2[i,j] = tmp[sayac];
                     sayac++;
                 }
             }

            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            dugum(data1, data2, 12, sayi);






        }
    }
}
