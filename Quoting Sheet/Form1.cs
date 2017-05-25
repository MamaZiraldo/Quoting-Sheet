using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Quoting_Sheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal time;
            decimal atCost;
            decimal clientCost;
            decimal employeeCost = 0.22M;
            decimal regularCost = 2;
            decimal rushCost = 1.1M;
            decimal difficultCost = 1.1M;
            decimal preferredCost = 1.5M;
            decimal designCost = 0.29M;
            decimal atCostUnit;
            decimal clientCostUnit;

            time = MachineTime.Value + ManualLabourTime.Value;
            atCost = time * employeeCost;
            atCost = atCost + MaterialCost.Value;
            atCost = atCost * Quantity.Value;
            designCost = designCost * DesignTime.Value;
            atCost = atCost + designCost;

            if (PreferredClient.Checked)
            {
                clientCost = atCost * preferredCost;
            }
            else
            {
                clientCost = atCost * regularCost;
            }

            if (RushJob.Checked)
            {
                clientCost = clientCost * rushCost;
            }

            if (DifficultClient.Checked)
            {
                clientCost = clientCost * difficultCost;
            }

            atCostUnit = atCost / Quantity.Value;
            clientCostUnit = clientCost / Quantity.Value;

            AtCost.Text = atCost.ToString();
            ClientCost.Text = clientCost.ToString();
            AtCostUnit.Text = atCostUnit.ToString();
            ClientCostUnit.Text = clientCostUnit.ToString();

            AtCost.Text = string.Format("{0:0.00}", AtCost.Text);
            ClientCost.Text = string.Format("{0:0.00}", ClientCost.Text);
            AtCostUnit.Text = string.Format("{0:0.00}", AtCostUnit.Text);
            ClientCostUnit.Text = string.Format("{0:0.00}", ClientCostUnit.Text);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Quote Files (*.quote)|*quote";
            dialog.ShowDialog();

            if(dialog.FileName != "")
            {
                SaveData Data = new SaveData();
                Data.DesignTime = DesignTime.Value;
                Data.MachineTime = MachineTime.Value;
                Data.ManualLabourTime = ManualLabourTime.Value;
                Data.MaterialCost = MaterialCost.Value;
                Data.Quantity = Quantity.Value;
                Data.RushJob = RushJob.Checked;
                Data.DifficultClient = DifficultClient.Checked;
                Data.PreferredClient = PreferredClient.Checked;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, Data);
                stream.Close();
            }

        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Quote Files (*.quote)|*quote";
            dialog.ShowDialog();

            if(dialog.FileName != "")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData Data = (SaveData)formatter.Deserialize(stream);
                stream.Close();

                DesignTime.Value = Data.DesignTime;
                MachineTime.Value = Data.MachineTime;
                ManualLabourTime.Value = Data.ManualLabourTime;
                MaterialCost.Value = Data.MaterialCost;
                Quantity.Value = Data.Quantity;
                RushJob.Checked = Data.RushJob;
                DifficultClient.Checked = Data.DifficultClient;
                PreferredClient.Checked = Data.PreferredClient;
            }
            
        }
    }

    [Serializable]
    public class SaveData
    {
        public decimal DesignTime = 0;
        public decimal MachineTime = 0;
        public decimal ManualLabourTime = 0;
        public decimal MaterialCost = 0;
        public decimal Quantity = 1;
        public bool RushJob = false;
        public bool DifficultClient = false;
        public bool PreferredClient = false;
    }
}
