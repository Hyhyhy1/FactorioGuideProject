using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    public partial class GuideForm : Form
    {
        ComboBox sections;
        public GuideForm()
        {

            sections = new ComboBox()
            {
                Location = new Point(10, 10),
                Size = new Size(150, 30),
                Text = "Этапы прохождения",
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            sections.SelectedIndexChanged += sb_SelectIndexChanged;

            var table = new TableLayoutPanel();
            table.ColumnStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            InitializeComponent();

        }

        private void sb_Load(object sender, EventArgs e)
        {
            sections.Items.Add("Создание карты");
            sections.Items.Add("Первые шаги");
            sections.Items.Add("Электричество");
            sections.Items.Add("Первая автоматизация");
            sections.Items.Add("Красная наука");
            sections.Items.Add("Зеленая наука");
            sections.Items.Add("Синяя наука");
            sections.Items.Add("Фиолетовая и желтая наука");
            sections.Items.Add("РАКЕТА!!!!");
        }

        private void sb_SelectIndexChanged(object sender, EventArgs e)
        {
            string selectedState = sections.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }
    }
}
