using System;
using System.Drawing;
using static FactorioGuideProject.MapCreationGroup;
using static FactorioGuideProject.Scheme;

using System.Windows.Forms;

namespace FactorioGuideProject
{
    class GuideForm : Form
    {
		DoubleSideLinkedList<TableLayoutPanel> CurrentGroup = new DoubleSideLinkedList<TableLayoutPanel>();
		ListItem<TableLayoutPanel> currentPanel;
		TableLayoutPanel Panel;
		public GuideForm()
        {
			var nextButtons = new Button[30];
			for(int i = 0; i < 30; i++)
				nextButtons[i] = new Button { Text = "Далее", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			foreach (var button in nextButtons)
				button.Click += (nextButtonClick);

			var prevButtons = new Button[30];//можно ли как - то сделать одну универсальную кнопку вперед и назад и передавать её на все TableLayoutPanel?
			for (int i = 0; i < 30; i++)
				prevButtons[i] = new Button { Text = "Назад", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			foreach (var button in prevButtons)
				button.Click += (prevButtonClick);

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
				Environment.NewLine + "С нами у Вас не возникнет проблем с прохождением Factorio. " +
				Environment.NewLine + "Приятной игры!",
				Dock = DockStyle.Fill,
			};

			Panel = GetSiplePage(initialSlideLabel, initialSlideText);

			var Chapters = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(210, 40),
				Text = "Этапы прохождения",
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

			Chapters.SelectedIndexChanged += (sender, args) =>
			{
				Controls.Remove(Panel);
				Panel = Scheme.CreateNewTablePanel();

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						var MapCreationGroupText = GetMapCreationGroup();
						CurrentGroup.Add(GetPageWithNextButton(MapCreationLabel, MapCreationGroupText[0], nextButtons[0]));
						CurrentGroup.Add(GetPageWithTwoButtons(MapCreationLabel, MapCreationGroupText[1], nextButtons[1], prevButtons[0]));
						CurrentGroup.Add(GetPageWithTwoButtons(MapCreationLabel, MapCreationGroupText[2], nextButtons[2], prevButtons[1]));
						CurrentGroup.Add(GetPageWithPrevButton(MapCreationLabel, MapCreationGroupText[3], prevButtons[2]));
						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
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
			Controls.Add(Panel);
		}
		private void nextButtonClick(object sender, EventArgs e)
		{
			Controls.Remove(Panel);
			currentPanel = currentPanel.Next;
			Panel = currentPanel.Value;
			Controls.Add(Panel);
		}
		private void prevButtonClick(object sender, EventArgs e)
        {
			Controls.Remove(Panel);
			currentPanel = currentPanel.Previous;
			Panel = currentPanel.Value;
			Controls.Add(Panel);
		}
	}
}
