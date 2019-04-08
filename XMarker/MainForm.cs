using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMarker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            SourceFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SourceFileDialog.FileName)) return;
            SourceText.Text = SourceFileDialog.FileName;
        }

        private void TargetButton_Click(object sender, EventArgs e)
        {
            TargetFolderDialog.ShowDialog();
            if (!Directory.Exists(TargetFolderDialog.SelectedPath)) return;
            TargetText.Text = TargetFolderDialog.SelectedPath;
        }

        private void MarkFontButton_Click(object sender, EventArgs e)
        {
            MarkFontDialog.ShowDialog();
            MarkFontText.Text = MarkFontDialog.Font.Name;
        }

        private void MarkColorPicture_Click(object sender, EventArgs e)
        {
            MarkColorDialog.ShowDialog();
            MarkColorPicture.BackColor = MarkColorDialog.Color;
        }

        private void AddOfficeButton_Click(object sender, EventArgs e)
        {
            var text = AddOfficeText.Text;
            if (string.IsNullOrEmpty(text)) return;
            if (OfficeList.Items.Contains(text)) return;
            OfficeList.Items.Insert(0, AddOfficeText.Text.Trim());
            OfficeList.SelectedIndex = 0;
        }

        private void DeleteOfficeButton_Click(object sender, EventArgs e)
        {
            if (OfficeList.SelectedItem == null) return;
            OfficeList.Items.Remove(OfficeList.SelectedItem);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Todo");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Todo");
        }

        private void SolidRadio_Click(object sender, EventArgs e)
        {
            SolidRadio.Checked = true;
            SolidGroup.Enabled = true;
            foreach (Control control in SolidGroup.Controls)
            {
                control.Enabled = true;
            }
            NumberGroup.Enabled = false;
            foreach (Control control in NumberGroup.Controls)
            {
                control.Enabled = false;
            }
            OfficeGroup.Enabled = false;
            foreach (Control control in OfficeGroup.Controls)
            {
                control.Enabled = false;
            }
        }

        private void NumberRadio_Click(object sender, EventArgs e)
        {
            NumberRadio.Checked = true;
            SolidGroup.Enabled = false;
            foreach (Control control in SolidGroup.Controls)
            {
                control.Enabled = false;
            }
            NumberGroup.Enabled = true;
            foreach (Control control in NumberGroup.Controls)
            {
                control.Enabled = true;
            }
            OfficeGroup.Enabled = false;
            foreach (Control control in OfficeGroup.Controls)
            {
                control.Enabled = false;
            }
        }

        private void ListRadio_Click(object sender, EventArgs e)
        {
            ListRadio.Checked = true;
            SolidGroup.Enabled = false;
            foreach (Control control in SolidGroup.Controls)
            {
                control.Enabled = false;
            }
            NumberGroup.Enabled = false;
            foreach (Control control in NumberGroup.Controls)
            {
                control.Enabled = false;
            }
            OfficeGroup.Enabled = true;
            foreach (Control control in OfficeGroup.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
