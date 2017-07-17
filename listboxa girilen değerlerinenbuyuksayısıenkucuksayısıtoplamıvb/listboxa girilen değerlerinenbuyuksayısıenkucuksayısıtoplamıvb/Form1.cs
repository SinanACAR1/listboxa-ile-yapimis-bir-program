using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];//Count sayıcı demektir. Bu kod in dizisinin değerlerini listbox1deki sayılardan alıcagını belirtiyoruz.
            for (int i = 0; i < listBox1.Items.Count; i++)//Burda i Listboxdaki değerlerden büyük olana kadar döngünün çalışmasını istiyoruz listboxda ne kadar değer varsa dögü o kadar çalışır.
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());//Listboxun i'ninci değerini int'e dönüştürüyoruz yani eğer i 1 ise 1. değeri int oluyor.
            }
            Array.Sort(sayılar);//Bu kod ise Dizilerde ki Değerleri Yani listboxdaki değerleri Küçükten Büyüğe Doğru sıralıyor.
            lblenbuyuk.Text = sayılar[sayılar.Length - 1].ToString();//Bu kod satırında ise sayılar dizisinin uzunlugundan 1 eksiğinde olan sayıyı yazdır. listboxta 8 tane değer varsa 7. değeri yazdır gibi bu satırı yazmamızın nedeni ise dizilerin 0 dan başlamasıdır.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayılar);
            lblkucuk.Text = sayılar[0].ToString();//ARRAY.SORT KOMUTU KÜÇÜKTEN BÜYÜĞE DOĞRU SIRALADIĞI İÇİN 0. İNDİS EN KÜÇÜK SAYIDIR.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach (int sayı in sayılar)
            {
                toplam = toplam + sayı;
            }
            lbltoplam.Text = toplam.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayılar= new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach (int sayı in sayılar)
            {
                toplam = toplam + sayı;
            }
            lblort.Text = (toplam / sayılar.Length).ToString();//Burda Toplam ile sayılar dizisin veri sayısını bölüyoruz ve ortalama çıkıyor



        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int sayı in sayılar)
            {
                if (sayı % 2 == 0)
                {
                    listBox2.Items.Add(sayı);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());

            }
            foreach (int sayı in sayılar)
            {
                if (sayı % 2 == 1)
                {
                    listBox3.Items.Add(sayı);
                }
            }
            
            
            
            
            }    
            
    }
}
