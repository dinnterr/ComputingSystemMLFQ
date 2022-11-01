using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ComputingSystem
{
    class ViewDetailed : View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) :
          base(model, controller)
        {
            this.frm = frm;        
        }

        public override void DataBind()
        {
           
            // привязка счётчика тактов
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));
            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));
            frm.LblFreeMemValue.DataBindings.Add(new Binding("Text", model.ram, "FreeSize"));
            frm.LblOccupiedMemValue.DataBindings.Add(new Binding("Text", model.ram, "OccupiedSize"));

            //элементы управления
            Binding intensityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudIntensity.DataBindings.Add(intensityBinding);

            Binding burstMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime");
            burstMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudBurstMin.DataBindings.Add(burstMinBinding);

            Binding burstMaxBinding = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime");
            burstMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudBurstMax.DataBindings.Add(burstMaxBinding);

            Binding addrSpaceMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace");
            addrSpaceMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudAddrSpaceMin.DataBindings.Add(addrSpaceMinBinding);

            Binding addrSpaceMaxBinding = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace");
            addrSpaceMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudAddrSpaceMax.DataBindings.Add(addrSpaceMaxBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAM");
            ramSizeBinding.Parse += objectToInt;
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.CbRamSize.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }
        public override void DataUnbind()
        {
            frm.NudIntensity.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.NudAddrSpaceMin.DataBindings.RemoveAt(0);
            frm.NudAddrSpaceMax.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }

        private FrmDetailed frm;

        // подписчик
        private void Subscribe() 
        {
            model.PropertyChanged += PropertyChangedHandler;
        }
        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }

        private void PropertyChangedHandler(object
                sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                updateListBox(model.ReadyQueue, frm.LbCPUQueue);
            }
            else
            {
                updateListBox(model.DeviceQueue, frm.LbDeviceQueue);
            }

        }

        private void updateListBox(
                IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());

        }

        private void objectToInt (object sender, ConvertEventArgs cevent)
        {
            if(cevent.DesiredType != typeof(int))
            {
                return;
            }
            cevent.Value = int.Parse(cevent.Value.ToString(), System.Globalization.NumberStyles.Integer, null);
        }
    }
}
