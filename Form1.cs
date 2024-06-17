using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhLaiSuatNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tienlai, sonamgui;
            double sotien = double.Parse(txtSotien.Text);
            double laisuat = double.Parse(txtLaisuat.Text.Replace("%", "")) / 100;
            sonamgui = Convert.ToInt32(txtSonamgui.Text);
            for (int i =1; i <= sonamgui; i++) 
            {
                tienlai = sotien * laisuat;
                lsbKQ.Items.Add("Số năm: " +i+ " .Số tiền hiện tại là: " +sotien+ " .Số tiền lãi là: " + tienlai);
                sotien += tienlai;
                
            }
            
        }
    }
}
 