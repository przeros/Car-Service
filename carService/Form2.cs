using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carService
{
    public partial class Form2 : Form
    {
        List<Repair> repairs;
        double procent;
        public Form2(List<Repair> newRepairs, double newProcent)
        {
            this.repairs = newRepairs;
            this.procent = newProcent;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Repair repair in repairs)
            {
                dataGridView1.Rows.Add(repair.getId(), repair.getRegistrationNumber(), repair.getCarTakeDate(), $"{repair.getMechanic().getName()} {repair.getMechanic().getSurname()}",
                    repair.getPartsCost(), repair.getNumberOfHours(), repair.getTotalCost());
            }

            percentAllRepairs.Text = $"{procent} %";
        }
    }
}
