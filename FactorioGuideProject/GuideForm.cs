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
			DoubleBuffered = true;
			var initialSlideLabel = new Label
			{
				Text = "Введение"
			};

			var initialSlideText = new Label()
			{
				//Multiline = true,
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
				Panel = Scheme.CreateSimplePanel();

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						var MapCreationGroupText = GetMapCreationGroup();
						var MapCreationLabels = GetMapCreationLabels();
						CurrentGroup.Add(GetDificultSlide
                            (MapCreationLabels[0], MapCreationGroupText[0], GetNextButton(), GetPrevButton(), GetNextButton(1,"Ресурсы"), GetNextButton(2,"Ландшафт"), GetNextButton(3,"Противники")));
                        CurrentGroup.Add(GetPageWithTextAndPicture(MapCreationLabels[1], MapCreationGroupText[1],GetNextButton(),GetPrevButton(), Resource1.Settings1));
                        //CurrentGroup.Add(GetPageWithTwoButtons(MapCreationLabels[1], MapCreationGroupText[1], GetNextButton(), GetPrevButton()));
                        CurrentGroup.Add(GetPageWithTwoButtons(MapCreationLabels[2], MapCreationGroupText[2], GetNextButton(), GetPrevButton()));
                        CurrentGroup.Add(GetPageWithPrevButton(MapCreationLabels[3], MapCreationGroupText[3], GetPrevButton()));
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
		/// <summary>
		/// конструктор кнопки для перехода на следующий слайд
		/// </summary>
		/// <returns></returns>
		private Button GetNextButton()
        {
			var nextButton = new Button { Text = "Далее", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			nextButton.BackColor = Color.Transparent;
			nextButton.Click += nextButtonClick;
			return nextButton;
		}

		/// <summary>
		/// конструктор кнопки для перехода на stepsCount слайдов
		/// </summary>
		/// <param name="stepsCount">количество переходов вперед</param>
		/// <param name="text">текст кнопки</param>
		/// <returns></returns>
		private Button GetNextButton(int stepsCount, string text)
        {
			var nextButton = new Button { Text = text, Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			nextButton.BackColor = Color.Transparent;
			nextButton.Font = new Font(nextButton.Font, FontStyle.Bold);
			nextButton.UseCompatibleTextRendering = true;
			for (int i = 0; i < stepsCount; i++)
				nextButton.Click += nextButtonClick;
			return nextButton;
		}

		private Button GetPrevButton()
        {
			var prevButton = new Button { Text = "Назад", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			prevButton.BackColor = Color.Transparent;
			prevButton.Click += prevButtonClick;
			return prevButton;
		}
	}
}
