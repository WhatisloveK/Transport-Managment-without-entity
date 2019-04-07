using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmCargoSearch : Form
    {
        public FrmCargoSearch()
        {
            InitializeComponent();
            cargosCitySearchTableAdapter1.Fill(dsTranspManag1.CargosCitySearch, 0, "", "", "", "", "", "", "", "");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                

                dGVSearchCargos.Visible = true;
                string depart_city = textBoxDeparture.Text;
                string dest_city = textBoxDestination.Text;
                string departureAdress = textBoxDepartureAdress.Text;
                string destinationAdress = textBoxDestinationAdress.Text;
                int weight = (int)numericUpDownWeight.Value;
                string depart_day = datePickerDeparture.Value.ToString("yyyy-MM-dd");
                string dest_day = datePickerDestination.Value.ToString("yyyy-MM-dd");
                 
                 string depart_time = timePickerDepartures.Value.TimeOfDay.ToString();
                 string dest_time = timePickerDestination.Value.TimeOfDay.ToString();
                if (!checkBoxDepartureDay.Checked)
                    depart_day = "";
                if (!checkBoxDestinationDay.Checked)
                    dest_day = "";
                if (!checkBoxDepartureTime.Checked)
                    depart_time = "";
                if (!checkBoxDestinationTime.Checked)
                    dest_time = "";


                cargosCitySearchTableAdapter1.Fill(dsTranspManag1.CargosCitySearch, weight, 
                    destinationAdress, dest_time, dest_day,dest_city,
                    departureAdress, depart_time, depart_day, depart_city);
               
               
            }
            catch
            {
                MessageBox.Show("Searching error (exp)", "exeption");
            }
        }

      
    }
}