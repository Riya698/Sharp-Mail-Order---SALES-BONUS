using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sharp Mail Oder - Sales Bonus	
// Made by Riya Patel
// Student # 200335493
// Created on January 29th 2017	
// A windows form to calculate bonus per employee for each hour worked.

namespace Assignment1
{
    public partial class MailOrder : Form
    {
        private double _totalSales;
        public MailOrder()
        {
            InitializeComponent();
        }

        // make sure that the hours worked value is between 0 to 160 
        private void HoursWorked_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!HoursWorked_textBox.Text.Equals(""))
            {
                if (int.Parse(HoursWorked_textBox.Text) < 0 || int.Parse(HoursWorked_textBox.Text) > 160)
                {
                    MessageBox.Show("Invalid value!\nNumber of hours worked must be between 0 to 160", "Error");
                    HoursWorked_textBox.Text = "";
                }
            }
        }

        // clear the form from values
        private void Next_button_Click(object sender, EventArgs e)
        {
            EmpName_textBox.Text = "";
            EmpID_textBox.Text = "";
            HoursWorked_textBox.Text = "";
            SalesBonus_textBox.Text = "$0.00";
            EmpName_textBox.Focus();
        }
    
        // make sure that the text boxes don't consist letters
        private void JustDigits_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) // digits or backspace
                e.Handled = true;
        }

        // change all the labels and buttons to Francais
        //French radio button even handler
        private void Francais_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpName_label.Text = "Le Nom De L'employé:";
            EmpID_label.Text = "ID Employé:";
            HoursWorked_label.Text = "Heures Travaillées:";
            TotalSales_label.Text = "Ventes Totales:";
            SalesBonus_label.Text = "Bonus De Vente:";
            Calculate_button.Text = "Calculer";
            Print_button.Text = "Impression";
            Next_button.Text = "Prochain";
        }

        // change all the labels and buttons to Spanish
        //spanish radio button event handler
        private void Spanish_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpName_label.Text = "Nombre Del Empleado:";
            EmpID_label.Text = "ID De Empleado:";
            HoursWorked_label.Text = "Horas Trabajadas:";
            TotalSales_label.Text = "Ventas Totales:";
            SalesBonus_label.Text = "Bono De Ventas:";
            Calculate_button.Text = "Calcular";
            Print_button.Text = "Impresión";
            Next_button.Text = "Siguiente";
        }

        // change all the labels and buttons to English
        //english radio button event handler
        private void English_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpName_label.Text = "Employee's Name:";
            EmpID_label.Text = "Employee ID:";
            HoursWorked_label.Text = "Hours Worked:";
            TotalSales_label.Text = "Total Sales:";
            SalesBonus_label.Text = "Sales Bonus:";
            Calculate_button.Text = "Calculate";
            Print_button.Text = "Print";
            Next_button.Text = "Clear";
        }

        // format the text to a standard currency format
        private void TotalSales_textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _totalSales = double.Parse(TotalSales_textBox.Text);
                TotalSales_textBox.Text = double.Parse(TotalSales_textBox.Text).ToString("C2");
            }
            catch { }// catch if there is still $0.00 on the total sales text box
        }

        // make sure that the employee's name does not consist digits
        private void EmpName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) // without digits
                e.Handled = true;
        }

        // send message for the user that the form is being sent to the printer
        private void Print_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form is being sent to the printer.", "Print");
        }

        // calculates the total sales bonus amount
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            // if there are values inside all the text boxes
            if (!EmpName_textBox.Text.Equals("") && !EmpID_textBox.Text.Equals("") && !HoursWorked_textBox.Text.Equals("") && !TotalSales_textBox.Text.Equals(""))
            {
                double hoursWorkedPrecent, totalBonusAmount;
                hoursWorkedPrecent = double.Parse(HoursWorked_textBox.Text) / 160;
                totalBonusAmount = _totalSales * 0.02;

                SalesBonus_textBox.Text = (hoursWorkedPrecent * totalBonusAmount).ToString("C2");
            }
            // if one or more of the text boxes has no value 
            else
            {
                MessageBox.Show("Please make sure that you entered\nvalues in the right places.", "Value Missing");
            }
        }

    }
}
