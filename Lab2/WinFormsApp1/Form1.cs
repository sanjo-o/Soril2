namespace WinFormsApp1
{
    public partial class FlightResForm : Form
    {
        public FlightResForm()
        {
            InitializeComponent();
        }

        private void passNum_Click(object sender, EventArgs e)
        {

        }

        private void lblFlightNum_Click(object sender, EventArgs e)
        {

        }

        private void txtFlightNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (lbFrom.Text == lbTo.Text)
            {
                MessageBox.Show("Can't fly to the same location!");
            }
            else
            {    MessageBox.Show("Flight Number: "+txtFlightNum.Text+
                    "\n"+ "Passanger Name: " + txtPassName.Text+
                    "\n"+"Passport Number: " + txtPassNum.Text+
                    "\n"+"Flight Date: " + datePick.Text+
                    "\n"+"Flight Location: " + lbFrom.Text+
                    "\n"+"Landing Location: "+lbTo.Text+
                    "\n"+"Flight Type: "+lbType.Text);

                foreach (string s in cbService.CheckedItems)
                {
                    MessageBox.Show("Chosen Service: " + s);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFlightNum.Text = "";
            txtPassName.Text = "";
            txtPassNum.Text = "";
            datePick.Text = "";
            lbFrom.ClearSelected();
            lbTo.ClearSelected();
            lbType.ClearSelected();
            cbService.ClearSelected();
            for (int i = 0; i <= cbService.CheckedItems.Count; i++)
            {
                cbService.SetItemChecked(i, false);
            }
        }
    }
}
