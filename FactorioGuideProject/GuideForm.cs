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
			var panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

			var Chapters = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(210, 40),
				Text = "Этапы прохождения",
			};

			var slideLabel = new Label
			{
				Text = "Введение"
			};

			var slideText = new TextBox()
			{
				Multiline = true,
				Text = "Добро пожаловать в наше приложение!" +
				Environment.NewLine + "Данный интерактивный гайд поможет Вам разобраться в Factorio." +
				Environment.NewLine + "Мы постарались сделать его максимально удобным и сконструированным." +
				Environment.NewLine + "" +
				Environment.NewLine + "Тут Вы сможете найти:" +
				Environment.NewLine + "Пошаговую инструкцию, со всей нужной дополнительной информацией" +
				Environment.NewLine + "Сведения о механиках игры" +
				Environment.NewLine + "Полезные советы при тупиковых ситуациях." +
				Environment.NewLine + "С нами у Вас не возникнет проблем с прохождением Factorio. Приятной игры!",
				Dock = DockStyle.Fill,
			};

			Chapters.Items.Add("Создание карты");
			Chapters.Items.Add("Первые шаги");
			Chapters.Items.Add("Электричество");
			Chapters.Items.Add("Первая автоматизация");
			Chapters.Items.Add("Красная наука");
			Chapters.Items.Add("Зеленая наука");
			Chapters.Items.Add("Важность обороны");
			Chapters.Items.Add("Синяя наука");
			Chapters.Items.Add("Фиолетовая и желтая наука");
			Chapters.Items.Add("Финал!");

			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(new Panel(), 0, 3);//заменить на кнопку 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(slideLabel, 1, 1);//заменить на заголовок(возможно)
			panel.Controls.Add(slideText, 1, 2);//заменить на текст
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(new Panel(), 2, 3);//заменить на кнопку
			panel.Controls.Add(new Panel(), 2, 4);

			panel.Dock = DockStyle.Fill;

			Controls.Add(Chapters);
			Controls.Add(panel);
			Chapters.SelectedIndexChanged += new EventHandler(Chapters_SelectedIndexChanged);
		}
		private void Chapters_SelectedIndexChanged()
        {
			switch()
        }
	}
}
