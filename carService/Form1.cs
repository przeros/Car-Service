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
    public partial class Form1 : Form
    {
        private CarService carService;

        public Form1(CarService newCarService)
        {
            this.carService = newCarService;
            InitializeComponent();

            foreach (Mechanic mechanic in carService.getMechanics())
            {
                mechanicComboBox.Items.Add($"{mechanic.getName()} {mechanic.getSurname()}");
            }
            
            CarServiceGridView.Rows.Add(carService.getName(), carService.getEarnings());

            foreach (Mechanic mechanic in carService.getMechanics())
            {
                MechanicGridView.Rows.Add(mechanic.getName(), mechanic.getSurname(), mechanic.getMoney());
            }
                
            foreach(Repair repair in carService.getRepairs())
            {
                dataGridView1.Rows.Add(repair.getId(), repair.getRegistrationNumber(), repair.getCarTakeDate(), $"{repair.getMechanic().getName()} {repair.getMechanic().getSurname()}",
                    repair.getPartsCost(), repair.getNumberOfHours(), repair.getTotalCost());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Mechanic fetchMechanicByNameAndSurname()
        {
            Mechanic repairMechanic = null;

            try
            {
                string mechanicNameAndSurname = mechanicComboBox.Text;
                int indexOfSpace = mechanicNameAndSurname.IndexOf(" ");
                string mechanicName = mechanicNameAndSurname.Substring(0, indexOfSpace);
                string mechanicSurname = mechanicNameAndSurname.Substring(indexOfSpace + 1, mechanicNameAndSurname.Length - indexOfSpace - 1);
                foreach (Mechanic mechanic in carService.getMechanics())
                {
                    if (mechanic.getName() == mechanicName && mechanic.getSurname() == mechanicSurname)
                    {
                        repairMechanic = mechanic;
                    }
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                
            }

            return repairMechanic;
        }

        private void addRepairButton_Click(object sender, EventArgs e)
        {
            Mechanic repairMechanic = fetchMechanicByNameAndSurname();

            if (registrationNumberText.Text.Equals("") || partsCostText.Text.Equals("") || numberOfHoursText.Text.Equals("") || repairMechanic == null)
            {
                MessageBox.Show("Wypełnij puste pola w formularzu!");
                return;
            }

            Repair repair = new Repair(registrationNumberText.Text, dateTimePicker1.Value, repairMechanic, Convert.ToDouble(partsCostText.Text), Convert.ToInt32(numberOfHoursText.Text));
            carService.makeRepair(repair);
            dataGridView1.Rows.Add(repair.getId(), repair.getRegistrationNumber(), repair.getCarTakeDate(), $"{repair.getMechanic().getName()} {repair.getMechanic().getSurname()}",
                    repair.getPartsCost(), repair.getNumberOfHours(), repair.getTotalCost());

            CarServiceGridView.Rows.Clear();
            CarServiceGridView.Rows.Add(carService.getName(), carService.getEarnings());
       
            for (int i = 0; i < MechanicGridView.Rows.Count - 1; i++)
            {
                if (repair.getMechanic().getName() == MechanicGridView.Rows[i].Cells[0].Value.ToString())
                {
                    MechanicGridView.Rows[i].Cells[2].Value = repair.getMechanic().getMoney();
                }
            }

        }
    }
}
