using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BirthDinParty
{
    public partial class Form1 : Form
    {
       DinnerParty dinner;
       BirthdayParty birthday;
        public Form1()
        {
            InitializeComponent();
            dinner = new DinnerParty((int)numberPeople.Value, healthBox.Checked, fancyDecor.Checked );
            birthday = new BirthdayParty((int)bithdUpDOwn.Value, brthCakeWritting.Text, bthFancyDecor.Checked);
            Display();
            DisplayBth();
        }

        private void numberPeople_ValueChanged(object sender, EventArgs e)
        {
            dinner.NumberOfPeople = (int)numberPeople.Value;
            Display();
        }
        private void fancyDecor_CheckedChanged(object sender, EventArgs e)
        {
            dinner.dinnerDecoration = fancyDecor.Checked;
            Display();
        }

        private void healthBox_CheckedChanged(object sender, EventArgs e)
        {
            dinner.healthyMenu = healthBox.Checked;
            Display();
        }
        void Display()
        {
            lableCost.Text = dinner.Cost.ToString("c");
        }
        void DisplayBth()
        {
            brthLableCost.Text = birthday.Cost.ToString("c");
        }
        private void bithdUpDOwn_ValueChanged(object sender, EventArgs e)
        {
            birthday.NumberOfPeople = (int)bithdUpDOwn.Value;
            DisplayBth();
        }

        private void bthFancyDecor_CheckedChanged(object sender, EventArgs e)
        {
            birthday.dinnerDecoration = bthFancyDecor.Checked;
            DisplayBth();
        }

        private void brthCakeWritting_TextChanged(object sender, EventArgs e)
        {
            birthday.CakeWritting = brthCakeWritting.Text;
            DisplayBth();
        }


    }
}
