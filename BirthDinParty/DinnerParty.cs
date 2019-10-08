using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthDinParty
{
    class DinnerParty : Party
    {
         double costOfBeveragesPerPerson { get; set; }
         public bool healthyMenu;
         const int costOfFoodPerPerson = 25;
         public DinnerParty(int num, bool health, bool decor) : base( num,  decor){
             healthyMenu = health;
         }
         double BeverageCost()
         {
             if (healthyMenu) costOfBeveragesPerPerson = NumberOfPeople * 5;
             else costOfBeveragesPerPerson = NumberOfPeople * 20;
             return costOfBeveragesPerPerson;
         }
 protected override  double DecorationCost()
         {
             if (NumberOfPeople > 0)
             {
                 if (dinnerDecoration) costOfDecaration = 15 * NumberOfPeople + 50;
                 else costOfDecaration = 7.5 * NumberOfPeople + 30;
             }
             else costOfDecaration = 0;
             return costOfDecaration;
         }
     public   override  double Cost
         {
             get
             {
                 double totalCost;
                 if (healthyMenu) totalCost = (NumberOfPeople * costOfFoodPerPerson + BeverageCost() + DecorationCost()) * 0.95;
                 else totalCost = NumberOfPeople * costOfFoodPerPerson + BeverageCost() + DecorationCost();
                 return totalCost;
             }
         }

    }
}
