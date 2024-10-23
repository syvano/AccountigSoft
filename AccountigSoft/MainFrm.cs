using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountigSoft
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

            //-------------
            AccountigSoft.Properties.Settings.Default.Sel_img_index = this.BackgroundComboBox.SelectedIndex;
            AccountigSoft.Properties.Settings.Default.Save();
            //-------------
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DateTimeLabel.Text = DateTime.Now.Date.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void BackgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fn = "";
                fn = Application.StartupPath + "Data\\Pics\\" + this.BackgroundComboBox.SelectedIndex.ToString() + ".jpg";
                this.BackgroundImage = Image.FromFile(fn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            int index = AccountigSoft.Properties.Settings.Default.Sel_img_index;
            this.BackgroundComboBox.SelectedIndex = index;
        }
    }
}
