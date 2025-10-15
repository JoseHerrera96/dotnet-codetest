using CodeChallenge.PartLengthCalculation.CodeChallenge;
using CodeChallenge.PartLengthCalculation.Answers.Model;
using CodeChallenge.PartLengthCalculation.Answers.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeChallenge.PartLengthCalculation.UI
{
    public partial class Main : Form
    {
        #region Application Infrastructure

        private List<Part> parts;

        public Main()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            parts = PartRepository.GetParts();
            PopulateList();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            foreach (Part part in this.parts)
            {
                UpdateList(part.Callout, PartLengthCalculator.DeterminePartLength(part)); ;
            }
        }
        private void PopulateList()
        {
            listData.Columns.Add("Part Callout");
            listData.Columns.Add("Known Part Length");
            listData.Columns.Add("Calculated Length");

            foreach (Part part in this.parts)
            {
                AddToList(part.Callout, part.PartLength);
            }

            listData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listData.Sorting = SortOrder.Ascending;
        }
        private void AddToList(string partCallout, float partLength)
        {
            ListViewItem item = new ListViewItem();

            item.Text = partCallout;
            item.SubItems.Add(partLength.ToString("0.000"));
            item.SubItems.Add("");
            item.ImageKey = "TBD";

            listData.Items.Add(item);
        }
        private void UpdateList(string partCallout, float calculatedLength)
        {
            ListViewItem item = listData.FindItemWithText(partCallout, false, 0, false);

            if (item != null)
            {
                item.SubItems[2].Text = calculatedLength.ToString("0.000");
                if (item.SubItems[1].Text == item.SubItems[2].Text)
                    item.ImageKey = "Match";
                else
                    item.ImageKey = "Mismatch";
            }
        }

        #endregion Application Infrastructure
    }
}