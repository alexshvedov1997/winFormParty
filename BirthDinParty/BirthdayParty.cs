using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthDinParty
{
    class BirthdayParty: Party
    {
        public string CakeWritting { get; set; }
        public BirthdayParty(int num, string cake, bool decor) : base(num, decor){
            CakeWritting = cake;
    }
        protected override double DecorationCost()
        {
            if (NumberOfPeople > 0)
            {
                if (dinnerDecoration) costOfDecaration = 15 * NumberOfPeople + 50;
                else costOfDecaration = 7.5 * NumberOfPeople + 30;
            }
            else costOfDecaration = 0;
            return costOfDecaration;
        }
        private int CakeWrittingLength() {
            string str = CakeWritting.Replace(" " , string.Empty);
            if (NumberOfPeople <= 4 & CakeWritting.Length < 16) return str.Count();
            else if (NumberOfPeople <= 4 & CakeWritting.Length > 16) return 16;
            else if (NumberOfPeople > 4 & CakeWritting.Length < 40) return str.Count();
            else return 40;
        }
        private int CostCake() {
            if (NumberOfPeople == 0) return 0;
            else if (NumberOfPeople <= 4 & NumberOfPeople != 0) return 40;
            else return 75;
        }
        private double TotalCakeCost(){
            return  CakeWrittingLength()* 0.25 + CostCake();
        }
        public override double Cost
        {
            get
            {
                return TotalCakeCost() + DecorationCost();
            }
        }

    }
}
