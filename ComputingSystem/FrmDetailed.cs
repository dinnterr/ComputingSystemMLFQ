using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingSystem
{
    public partial class FrmDetailed : Form
    {
        public FrmDetailed()
        {
            InitializeComponent();
        }

        private void workingCycle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!!!");
            Model model = new Model();
            Settings settings = new Settings();
            settings.ValueOfRAMSize = 32000;
            settings.MinValueOfBurstTime = 3;
            settings.MaxValueOfBurstTime = 7;
            settings.Intensity = 0.9;
            IdGenerator id = new IdGenerator();
            for (int i = 0; i < 10; i++)
            {
                model.WorkingCycle();
                MessageBox.Show(model.cpu.IsFree().ToString());
               // MessageBox.Show(model.device.IsFree().ToString());
            }
           
        }
    }
}
