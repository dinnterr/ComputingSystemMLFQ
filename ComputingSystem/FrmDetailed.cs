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
            btnSessionEnd.Enabled = false;
            btnStart.Enabled = true;
            btnWork.Enabled = false;
        }
     
        private ViewDetailed viewDetailed{ get; set; }
        public Label LblTime { get { return lblTime; } }
        public ListBox LbCPUQueue { get { return lbCPUQueue; } }
        public ListBox LbDeviceQueue { get { return lbDeviceQueue; } }
        public ListBox LbDeviceQueue2 { get { return lbDeviceQueue2; } }
        public TextBox TbCPU { get { return tbCPU; } }
        public TextBox TbDevice1 { get { return tbDevice1; } }
        public TextBox TbDevice2 { get { return tbDevice2; } }

        public TextBox TbCpuUtil { get { return tbCpuUtil; } }
        public TextBox TbProductivity { get { return tbProductivity; } }
        
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
            //btnWork.Enabled = true;
            btnWork.Enabled = rbManual.Checked;
            if (rbManual.Checked == false)
            {
                timer.Start();
            }
            TlPanelSettings.Enabled = false;
        }

        private void endOfSession()
        {
            btnSessionEnd.Enabled = false;
            btnStart.Enabled = true;
            btnWork.Enabled = false;
            TlPanelSettings.Enabled = true;
            if(rbAuto.Checked == true)
            {
                timer.Stop();
            }
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

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbManual.Checked && btnSessionEnd.Enabled)
            {
                timer.Start();
                btnWork.Enabled = false;
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked && btnSessionEnd.Enabled)
            {
                timer.Stop();
                btnWork.Enabled = true;
            }
        }        
    }
}
