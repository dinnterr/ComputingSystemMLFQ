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
            //lbltime
            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));
            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));
            frm.TbFreeMemValue.DataBindings.Add(new Binding("Text", model.ram, "FreeSize"));
            frm.TbOccupiedMemValue.DataBindings.Add(new Binding("Text", model.ram, "OccupiedSize"));

            //элементы управления
            Binding intensityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudIntensity.DataBindings.Add(intensityBinding);

            Binding burstMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudBurstMin.DataBindings.Add(burstMinBinding);

            Subscribe();
        }
        public override void DataUnbind()
        {

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
            model.PropertyChanged += PropertyChangedHandler;
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
    }
}
