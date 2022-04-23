using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    class GuideForm : Form
    {
        public GuideForm()
        {
			ComboBox mybox = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(216, 26),
				Text = "Этапы прохождения"
			};

			mybox.Items.Add("Создание карты");
			mybox.Items.Add("Первые шаги");
			mybox.Items.Add("Электричество");
			mybox.Items.Add("Первая автоматизация");
			mybox.Items.Add("Красная наука");
			mybox.Items.Add("Зеленая наука");
			mybox.Items.Add("Важность обороны");
			mybox.Items.Add("Синяя наука");
			mybox.Items.Add("Фиолетовая и желтая наука");
			mybox.Items.Add("Финал!");
			Controls.Add(mybox);
        }
	}
}
