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
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }

        /*private void workingCycle_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("!!!!!");
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

            Model model = new Model();
            model.ModelSettings.Intensity = 0.8;
            model.ModelSettings.MinValueOfAddrSpace = 100;
            model.ModelSettings.MaxValueOfAddrSpace = 300;
            model.ModelSettings.MinValueOfBurstTime = 3;
            model.ModelSettings.MaxValueOfBurstTime = 7;
            model.ModelSettings.ValueOfRAM = 32000;
            model.SaveSettings();
            
            for (int i = 0; i < 20; i++)
            {
                model.WorkingCycle();
                if (model.Cpu.ActiveProcess != null)
                {
                    //Console.WriteLine("On cpu: {0}", model.Cpu.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On cpu: " + model.Cpu.ActiveProcess.ToString());
                }
                if (model.ReadyQueue.Count != 0)
                {
                    //Console.WriteLine("Первый в очереди гоовых процессов: {0}", model.ReadyQueue.Item());
                    MessageBox.Show("Первый в очереди готовых процессов: " + model.ReadyQueue.Item());
                }
                if (model.Device.ActiveProcess != null)
                {
                    //Console.WriteLine("On device: {0}", model.Device.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On device: " + model.Device.ActiveProcess.ToString());
                }
                if (model.DeviceQueue.Count != 0)
                {
                    //Console.WriteLine("Первый в очереди к внешнему устройству: {0}", model.DeviceQueue.Item());
                    MessageBox.Show("Первый в очереди к внешнему устройству: " + model.DeviceQueue.Item());
                }

            }

        }*/
     
        private ViewDetailed viewDetailed{ get; set; }
        public Label LblTime { get { return lblTime; } }
        public ListBox LbCPUQueue { get { return lbCPUQueue; } }
        public ListBox LbDeviceQueue { get { return lbDeviceQueue; } }
        public TextBox TbCPU { get { return tbCPU; } }
        public TextBox TbDevice { get { return tbDevice; } }
        public Label LblFreeMemValue { get { return lblFreeMemValue; } }
        public Label LblOccupiedMemValue { get { return lblOccupiedMemValue; } }

        public ComboBox CbRamSize { get { return cbRamSize; } }

        public NumericUpDown NudIntensity { get { return nudIntensity; } }
        public NumericUpDown NudBurstMin { get { return nudBurstMin; } }
        public NumericUpDown NudBurstMax { get { return nudBurstMax; } }
        public NumericUpDown NudAddrSpaceMin { get { return nudAddrSpaceMin; } }
        public NumericUpDown NudAddrSpaceMax { get { return nudAddrSpaceMax; } }

        public TableLayoutPanel TlPanelSettings { get { return tlPanelSettings; } }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void btnSessionEnd_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            endOfSession();
            UpdateSettings();
        }

        private void sessionPreparation()
        {
            btnStart.Enabled = false;
            btnSessionEnd.Enabled = true;
            btnWork.Enabled = true;
            //btnWork.Enabled = rbManual.Checked;
            TlPanelSettings.Enabled = false;
        }

        private void endOfSession()
        {
            btnSessionEnd.Enabled = false;
            btnStart.Enabled = true;
            btnWork.Enabled = false;
            TlPanelSettings.Enabled = true;
        }

        private void UpdateSettings()
        {
            nudIntensity.Value = 0.5m;
            nudBurstMin.Value = nudBurstMin.Minimum;
            nudBurstMax.Value = nudBurstMax.Minimum;
            nudAddrSpaceMin.Value = nudAddrSpaceMin.Minimum;
            nudAddrSpaceMax.Value = nudAddrSpaceMax.Minimum;
            cbRamSize.SelectedItem = cbRamSize.Items[0];
        }
    }
}
