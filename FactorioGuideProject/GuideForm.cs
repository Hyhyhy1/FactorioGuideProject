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
		DoubleSideLinkedList<TableLayoutPanel> CurrentGroup;
		ListItem<TableLayoutPanel> currentPanel;
        public GuideForm()
        {
			var panel =Scheme.CreateNewTablePanel();

			var Chapters = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(210, 40),
				Text = "Этапы прохождения",
			};

			var initialSlideLabel = new Label
			{
				Text = "Введение"
			};

			var initialSlideText = new TextBox()
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

			var mapCreationLabel = new Label
			{
				Text = "Настройки мира игры"
			};

			var mapCreationText = new TextBox()
			{
				Multiline = true,
				Text = "Генератор карты - это совокупность настроек, с помощью которых определяется, как будет выглядеть ваш мир после создания. " +
				"Для новичков рекомендуется оставлять дефолтные настройки, мы тоже оставили за исключением некоторых пунктов, о которых расскажем ниже.",
				Dock = DockStyle.Fill,
			};

			var nextSlide = new Button
			{
				Text = "Далее",
				Dock = DockStyle.Fill,
				FlatStyle = FlatStyle.Flat,
			};

			var prevSlide = new Button
			{
				Text = "Назад",
				Dock = DockStyle.Fill,
				FlatStyle = FlatStyle.Flat,
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

			Scheme.GetSiplePage(panel, initialSlideLabel, initialSlideText);

			nextSlide.Click += (sender, args) =>
			{
				Controls.Remove(panel);
				currentPanel = currentPanel.Next;
				panel = currentPanel.Value;
				Controls.Add(panel);
			};

			prevSlide.Click += (sender, args) =>
			{
				Controls.Remove(panel);
				currentPanel = currentPanel.Previous;
				panel = currentPanel.Value;
				Controls.Add(panel);
			};


			Chapters.SelectedIndexChanged += (sender, args) =>
			{
				Controls.Remove(panel);
				panel = Scheme.CreateNewTablePanel();

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						Scheme.GetPageWithNextButton(panel, mapCreationLabel, mapCreationText, nextSlide);
						Controls.Add(panel);
						break;

					//case 1://Первые шаги
					//	Scheme.GetPageWithNextButton(panel, firstStepsLabel, firstStepsText0, nextSlide);
					//	Controls.Add(panel);
					//	break;

					//case 2://Электричество
					//	Scheme.GetPageWithNextButton(panel, electricityLabel, electricityText0, nextSlide);
					//	Controls.Add(panel);
					//	break;

					//case 3://Первая автоматизация
					//	Scheme.GetPageWithNextButton(panel, initialAutomationLabel, initialAutomationText0, nextSlide);
					//	Controls.Add(panel);
					//	break;

					//case 4://Красная наука
					//	Scheme.GetPageWithNextButton(panel, redScienceLabel, redScienceText0, nextSlide)
					//	Controls.Add(panel);
					//	break;
				}
			};

			Controls.Add(Chapters);
			Controls.Add(panel);
		}
	}
}
