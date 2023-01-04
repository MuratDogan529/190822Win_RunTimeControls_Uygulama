using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190822Win_RunTimeControls_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipler.SelectedIndex = 0;//comboboxta ilk seçenek seçili halde gelmesini istiyoruz
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int adet =Convert.ToInt32(nudAdet.Value);
            for (int i = 0; i < adet; i++)
            {
                switch (cmbTipler.Text)
                {
                    case "Button":
                        Button btn=new Button();
                        btn.Height = 30;
                        btn.Width = 80;
                        btn.Text = string.Format("Button{0}", i + 1);
                        btn.Font = new Font("Tahoma", 10) ;
                        btn.BackColor = Color.Gray;
                        btn.Click += Btn_Click;
                        btn.MouseHover += Btn_MouseHover;
                        btn.MouseLeave += Btn_MouseLeave;
                        btn.MouseEnter += Btn_MouseEnter;
                        flowLayoutPanel1.Controls.Add(btn);
                        break;

                    case "ComboBox":
                        //Girilen adet kadar combobox üretilecek.
                        //Her combobox ın itemlerine eleman eklenecek.
                        //SelectedIndexChanged eventi tanımlanacak.
                        //Bu event te seçilecek elemanın ismi messageBox ile gösterilecek.
                        //Comboboxların dropdown  özelliği dropdownlist seçilecek.
                        //Her combobox flowlayoutpanel e eklenecek.
                        ComboBox cmb = new ComboBox();
                        cmb.Items.Add("Item 1");
                        cmb.Items.Add("Item 2");
                        cmb.Items.Add("Item 3");
                        cmb.DropDownStyle= ComboBoxStyle.DropDownList;
                        cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
                        flowLayoutPanel1.Controls.Add(cmb);

                        break;
                    case "PictureBox": break;
                    case "TextBox": break;
                    case "ListBox": break;

                    default:
                        break;
                }
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox secilen = (ComboBox)sender;
            MessageBox.Show(secilen.Text);
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button tik = (Button)sender;
            tik.BackColor = Color.Green;//Mouse butonun üzerine gelirse rengini değiştirir. mouseHover dan hızlı çalışıyor.
        }

       private void Btn_MouseLeave(object sender, EventArgs e)
        {
           Button tiklanan=(Button)sender;//cast etme
            tiklanan.BackColor = Color.Gray;//mouse butonun üzerinden ayrılırsa gri yap
        }
       
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;//cast etme
           //tiklanan.BackColor = Color.Red;
           //mouse butonun üzerine gelirse kırmızı yap
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan=sender as Button;
            MessageBox.Show(string.Format("{0}'e Tıklandı.",tiklanan.Text));
        }
    }
}
