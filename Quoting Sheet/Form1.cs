using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quoting_Sheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
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


        }
    }
}
