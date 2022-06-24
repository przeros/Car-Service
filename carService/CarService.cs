using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    public class CarService
    {
        private string name;

        private double earnings;

        private List<Mechanic> mechanics;

        private List<Repair> repairs;

        public CarService(string newName, List<Mechanic> newMechanics)
        {
            this.name = newName;
            this.earnings = 0;
            mechanics = newMechanics;
            repairs = new List<Repair>();
        }

        public void makeRepair(Repair newRepair)
        {
            repairs.Add(newRepair);
            earnings += newRepair.countRepairCost();
            Mechanic mechanic = newRepair.getMechanic();
            double mechanicReward = countMechanicRewardForRepair(newRepair);
            payTheMechanicForRepair(mechanic, mechanicReward);
        }

        private void payTheMechanicForRepair(Mechanic mechanic, double mechanicReward)
        {
            earnings -= mechanicReward;
            mechanic.addMoney(mechanicReward);
        }

        private double countMechanicRewardForRepair(Repair repair)
        {
            double provision2Percent = repair.getPartsCost() * 0.02;
            double work30Percent = repair.getNumberOfHours() * repair.getMechanic().getStakePerHour() * 0.3;
            double finalMechanicReward = provision2Percent + work30Percent;
            return finalMechanicReward;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public double getEarnings()
        {
            return earnings;
        }

        public void setEarnings(double newEarnings)
        {
            this.earnings = newEarnings;
        }

        public List<Mechanic> getMechanics()
        {
            return mechanics;
        }

        public List<Repair> getRepairs()
        {
            return repairs;
        }

    }
}
