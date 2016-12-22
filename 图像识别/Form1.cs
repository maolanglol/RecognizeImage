using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODI;

namespace 图像识别
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择图片";
            fileDialog.Filter = "图像文件(*.*)|*.png|图像文件(*.*)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                IMGpath.Text = file;
            }
        }

        private void begin_Click(object sender, EventArgs e)
        {
            StringBuilder ab = new StringBuilder();
            MODI.Document doc = new MODI.Document();
            doc.Create(IMGpath.Text);
            MODI.Image image;
            MODI.Layout layout;
            doc.OCR(MODI.MiLANGUAGES.miLANG_CHINESE_SIMPLIFIED,true,true);
            for (int i = 0; i < doc.Images.Count; i++)
            {
                image = (MODI.Image)doc.Images[i];
                layout = image.Layout;
                ab.Append(layout.Text);
            }
            content.Text = ab.ToString();
        }
    }
}
