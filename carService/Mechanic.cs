using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    public class Mechanic
    {
        private string name;

        private string surname;

        private int employmentYear;

        private double stakePerHour;

        private double money;

        public Mechanic()
        {

        }

        public Mechanic(string newName, string newSurname, int newEmploymentYear, double newStakePerHour)
        {
            this.name = newName;
            this.surname = newSurname;
            this.employmentYear = newEmploymentYear;
            this.stakePerHour = newStakePerHour;
            this.money = 0;
        }

        public void addMoney(double newMoney)
        {
            this.money += newMoney;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public string getSurname()
        {
            return surname;
        }

        public void setSurname(string newSurname)
        {
            this.surname = newSurname;
        }

        public int getEmploymentYear()
        {
            return employmentYear;
        }

        public void setEmploymentYear(int newEmploymentYear)
        {
            this.employmentYear = newEmploymentYear;
        }

        public double getStakePerHour()
        {
            return stakePerHour;
        }

        public void setStakePerHour(double newStakePerHour)
        {
            this.stakePerHour = newStakePerHour;
        }

        public double getMoney()
        {
            return money;
        }

        public void setMoney(double newMoney)
        {
            this.money = newMoney;
        }

    }
}
