using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthDinParty
{
   abstract class Party
    {
       public int NumberOfPeople;
       protected double costOfDecaration { get; set; }
       protected abstract double DecorationCost();
       public bool dinnerDecoration;
       public abstract double Cost { get;  }
       public Party(int num, bool decor) {
           dinnerDecoration = decor;
           NumberOfPeople = num;
       }
       
    }
}
