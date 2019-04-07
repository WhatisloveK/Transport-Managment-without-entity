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
    public partial class FrmTrnspMng : Form
    {
        public FrmTrnspMng()
        {
            InitializeComponent();

            //filling data from database
            cargosTableAdapter1.Fill(dsTranspManag1.CARGOS);
            citiesTableAdapter1.Fill(dsTranspManag1.CITIES);
            departuresTableAdapter1.Fill(dsTranspManag1.DEPARTURES);
            truckersTableAdapter1.Fill(dsTranspManag1.TRUCKERS);
            truckTableAdapter1.Fill(dsTranspManag1.TRUCK);
            trucK_TYPESTableAdapter1.Fill(dsTranspManag1.TRUCK_TYPES);
            trailerTableAdapter1.Fill(dsTranspManag1.TRAILER);
            traileR_TYPESTableAdapter1.Fill(dsTranspManag1.TRAILER_TYPES);
        
        }

        #region Save Delete Buttons
        private void buttonCargosSave_Click(object sender, EventArgs e)
        {
            cargosTableAdapter1.Update(dsTranspManag1.CARGOS);
        }

        private void buttonCargosDelete_Click(object sender, EventArgs e)
        {
            cARGOSBindingSource.RemoveCurrent();
        }

        private void buttonCitiesSave_Click(object sender, EventArgs e)
        {
            citiesTableAdapter1.Update(dsTranspManag1.CITIES);
        }

        private void buttonCitiesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVCities.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value;

                global::System.Nullable<int> dp_count = queriesTableAdapter1.SQCountCITY_IDInDEPARTURES(id);

                if (dp_count == 0)
                    cITIESBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Departures ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
            
        }

        private void buttonDeparturesSave_Click(object sender, EventArgs e)
        {
            departuresTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonDeparturesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVDepartures.CurrentRow.Cells["dPIDDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> dp_count = queriesTableAdapter1.SQCountDP_IDInCARGOS(id);

                if (dp_count == 0)
                    dEPARTURESBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Cargos ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
           
        }

        private void buttonTruckersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTruckers.CurrentRow.Cells["tRTRUCKDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> tr_count = queriesTableAdapter1.SQCountTR_IDInCARGOS(id);

                if (tr_count == 0)
                    tRUCKBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Cargos ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
           
        }

        private void buttonTruckersSave_Click(object sender, EventArgs e)
        {
            truckersTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonTrucksSave_Click(object sender, EventArgs e)
        {
            truckTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonTrucksDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTrucks.CurrentRow.Cells["tRUCKIDDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> tr_count = queriesTableAdapter1.SQCountTRUCK_IDInTRUCKERS(id);

                if (tr_count == 0)
                    tRUCKBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Truckers ","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)","exeption");
            }
        }

        private void buttonTruckTypesSave_Click(object sender, EventArgs e)
        {
            trucK_TYPESTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonTruckTypesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTruckTypes.CurrentRow.Cells["tYPEIDDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> tr_count = queriesTableAdapter1.SQCountTYPE_IDInTRUCK(id);

                if (tr_count == 0)
                    tRUCKTYPESBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Truck ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
            
        }

        private void buttonTrailersSave_Click(object sender, EventArgs e)
        {
            trailerTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonTrailersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTrailers.CurrentRow.Cells["tRAILERIDDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> tr_count = queriesTableAdapter1.SQCountTRAILER_IDInTRUCK(id);

                if (tr_count == 0)
                    tRAILERBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Truck ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
            
        }

        private void buttonTrailerTypesSave_Click(object sender, EventArgs e)
        {
            traileR_TYPESTableAdapter1.Update(dsTranspManag1);
        }

        private void buttonTrailerTypesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTrailerTypes.CurrentRow.Cells["tYPETRIDDataGridViewTextBoxColumn1"].Value;

                global::System.Nullable<int> tr_count = queriesTableAdapter1.SQCountTYPE_TR_IDInTRAILER(id);

                if (tr_count == 0)
                    tRAILERTYPESBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Deleting error! There is a reference in Trailer ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Deleting error(exp)", "exeption");
            }
            
        }
        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FrmCargoSearch frmCargoSearch = new FrmCargoSearch();
            frmCargoSearch.Show();
        }

        private void dGVTruckers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           // if(e.ColumnIndex==4)
          //if( dGVTruckers.CurrentRow.Cells["dataGridViewTextBoxColumn19"].Value.Date < dGVTruckers.CurrentRow.Cells["dataGridViewTextBoxColumn18"].Value) 
        }
        #region NumbersNotLitrecha
        private void dGVTrucks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dGVTrucks_KeyPress);
            if (dGVTrucks.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dGVTrucks_KeyPress);
                }
            }
        }

        private void dGVTrucks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }


        

        private void dGVCargos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dGVCargos_KeyPress);
            if (dGVCargos.CurrentCell.ColumnIndex == 1||dGVCargos.CurrentCell.ColumnIndex==8) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dGVCargos_KeyPress);
                }
            }
        }

        private void dGVCargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }
       

        private void dGVTruckTypes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dGVTruckTypes_KeyPress);
            if (dGVTruckTypes.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dGVTruckTypes_KeyPress);
                }
            }
        }

        private void dGVTruckTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }


       
        private void dGVTrailerTypes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dGVTrailerTypes_KeyPress);
            if (dGVTrailerTypes.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dGVTrailerTypes_KeyPress);
                }
            }
        }

        private void dGVTrailerTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Incorrect value! \n Please enter the positive number");
            }
        }

        #endregion

    }
}
