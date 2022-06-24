using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    public class Repair
    {
        private static int repairCounter = 1;

        private int id;

        private string registrationNumber;

        private DateTime carTakeDate;

        private Mechanic mechanic;

        private double partsCost;

        private int numberOfHours;

        private double totalCost;

        public Repair(string newRegistrationNumber, DateTime newCarTakeDate, Mechanic newMechanic, double newPartsCost, int newNumberOfHours)
        {
            this.id = repairCounter;
            this.registrationNumber = newRegistrationNumber;
            this.carTakeDate = newCarTakeDate;
            this.mechanic = newMechanic;
            this.partsCost = newPartsCost;
            this.numberOfHours = newNumberOfHours;
            this.totalCost = countRepairCost();
            incrementRepairCounter();
        }

        public double countRepairCost()
        {
            double repairCost = partsCost + (numberOfHours * mechanic.getStakePerHour());
            return repairCost;
        }

        private void incrementRepairCounter()
        {
            repairCounter++;
        }

        public int getId()
        {
            return id;
        }

        public string getRegistrationNumber()
        {
            return registrationNumber;
        }

        public void setRegistrationNumber(string newRegistrationNumber)
        {
            this.registrationNumber = newRegistrationNumber;
        }

        public DateTime getCarTakeDate()
        {
            return carTakeDate;
        }

        public void setCarTakeDate(DateTime newCarTakeDate)
        {
            this.carTakeDate = newCarTakeDate;
        }

        public Mechanic getMechanic()
        {
            return mechanic;
        }

        public void setMechanic(Mechanic newMechanic)
        {
            this.mechanic = newMechanic;
        }

        public double getPartsCost()
        {
            return partsCost;
        }

        public void setMechanic(double newPartsCost)
        {
            this.partsCost = newPartsCost;
        }

        public int getNumberOfHours()
        {
            return numberOfHours;
        }

        public void setNumberOfHours(int newNumberOfHours)
        {
            this.numberOfHours = newNumberOfHours;
        }

        public double getTotalCost()
        {
            return totalCost;
        }

        public void setTotalCost(double newTotalCost)
        {
            this.totalCost = newTotalCost;
        }
    }
}
