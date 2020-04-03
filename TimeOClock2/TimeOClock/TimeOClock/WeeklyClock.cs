using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOClock
{
    public partial class WeeklyClock : Form
    {
        public WeeklyClock()
        {
            InitializeComponent();
        }

        private void WeeklyClock_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDomain formDomain = new FormDomain();
            formDomain.Show();
        }
    }
}
