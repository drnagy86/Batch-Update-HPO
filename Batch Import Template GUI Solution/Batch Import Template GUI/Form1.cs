using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using DataAccessLayer;

namespace Batch_Import_Template_GUI
{
    public partial class Form1 : Form
    {

        private IHPOManager _hPOManager = null;
        private List<HumanPhenotypeOntology> _humanPhenotypeOntologies;

        public Form1()
        {
            InitializeComponent();

            _hPOManager = new HPOManager(new FakeHPODDataAccessor());
            //_hPOManager = new HPOManager();

            try
            {
                _humanPhenotypeOntologies = _hPOManager.RetrieveHumanPhenotypeOntologyIdAndLabels();

                //List<string> labels = new List<string>();
                //foreach (HumanPhenotypeOntology item in humanPhenotypeOntologies)
                //{
                //    labels.Add(item.Label);
                //}

                //cmbHpoLabels.DataSource = labels;

                //cmbHpoLabels.DataSource = _hPOManager.RetrieveHumanPhenotypeOntologyIdAndLabels();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading the data for the HPO labels\n" + ex.Message);
                throw;
            }
            

        }

        private void btnAddHpo_Click(object sender, EventArgs e)
        {


            //lbSelectedHpo.Items.Add(cmbHpoLabels.SelectedItem.ToString());


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchInput_TextChanged(object sender, EventArgs e)
        {

            listViewResults.Items.Clear();

            foreach (HumanPhenotypeOntology hpo in _humanPhenotypeOntologies)
            {
                string labelToLower = hpo.ToString().ToLower();
                if (labelToLower.Contains(tbSearchInput.Text.ToLower()))
                {
                    listViewResults.Items.Add(hpo.Label);
                }
            }

            if (tbSearchInput.Text == "")
            {
                listViewResults.Items.Clear();
            }
        }
    }
}
