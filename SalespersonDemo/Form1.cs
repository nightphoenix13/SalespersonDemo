using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalespersonDemo
{
    public partial class Form1 : Form
    {
        // global variables
        RealEstateSalesperson res;
        GirlScout gs;

        public Form1()
        {
            InitializeComponent();
        }

        private void resCreateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(resFNTextBox.Text) || 
                String.IsNullOrEmpty(resLNTextBox.Text))
            {
                MessageBox.Show("You must enter a first and last name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
            else
            {
                res = new RealEstateSalesperson(resFNTextBox.Text, resLNTextBox.Text,
                    double.Parse(resCommissionTextBox.Text));
                resCreateButton.Enabled = false;
                resNameLabel.Text = res.ToString();
                resNameLabel.Visible = true;
                resSaleLabel.Visible = true;
                resSaleTextBox.Visible = true;
                resPitchButton.Visible = true;
                resSaleButton.Visible = true;
                resTotalSoldLabel.Visible = true;
                resCommissionEarnedLabel.Visible = true;
            } // end else
        } // resCreateButton_Click method end

        private void gsCreateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(gsFNTextBox.Text) ||
                String.IsNullOrEmpty(gsLNTextBox.Text))
            {
                MessageBox.Show("You must enter a first and last name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
            else
            {
                gs = new GirlScout(gsFNTextBox.Text, gsLNTextBox.Text);
                gsCreateButton.Enabled = false;
                gsNameLabel.Text = gs.ToString();
                gsNameLabel.Visible = true;
                gsSaleLabel.Visible = true;
                gsSaleTextBox.Visible = true;
                gsPitchButton.Visible = true;
                gsSaleButton.Visible = true;
                gsTotalSoldLabel.Visible = true;
            } // end else
        } // gsCreateButton_Click method end

        private void resPitchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(res.SalesSpeech(), "Sales Pitch",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gsPitchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gs.SalesSpeech(), "Sales Pitch",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resSaleButton_Click(object sender, EventArgs e)
        {
            res.TotalSold += Convert.ToInt32(resSaleTextBox.Text);
            resTotalSoldLabel.Text = "Total Value Sold: $" + res.TotalSold;
            resCommissionEarnedLabel.Text = "Commission Earned: $" +
                res.CommissionEarned;
        }

        private void gsSaleButton_Click(object sender, EventArgs e)
        {
            gs.BoxesSold += Convert.ToInt32(gsSaleTextBox.Text);
            gsTotalSoldLabel.Text = "Total Boxes Sold: " + gs.BoxesSold;
        } // resPitchButton_Click method end
    }
}
