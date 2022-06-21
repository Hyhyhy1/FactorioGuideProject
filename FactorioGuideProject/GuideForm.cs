using System;
using System.Drawing;
using static FactorioGuideProject.GroupsData;
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
				Text = "Введение",
				Font = new Font("Actor", 12),
				ForeColor = Color.White,
				AutoSize = true,
				Anchor = AnchorStyles.Top,
			};

			var initialSlideText = new Label
			{
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
				Font = new Font("Actor",12),
				Dock = DockStyle.Fill,
				ForeColor = Color.White,
				AutoSize = true,
				Anchor = AnchorStyles.Top,
			};

			Panel = GetSimpleSlide(initialSlideLabel, initialSlideText);

			var Chapters = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(210, 40),
				Text = "Этапы прохождения",
				DropDownStyle = ComboBoxStyle.DropDownList
			};

			Chapters.Items.Add("Создание карты");
			Chapters.Items.Add("Первые шаги");
			Chapters.Items.Add("Электричество");
			Chapters.Items.Add("Начальная наука");
			Chapters.Items.Add("Ресурсы");
			Chapters.Items.Add("Транспортировка предметов");
			Chapters.Items.Add("Важность обороны");
			Chapters.Items.Add("Советы");
			Chapters.Items.Add("Финал!");

			Chapters.SelectedIndexChanged += (sender, args) =>
			{
				Controls.Remove(Panel);

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						CurrentGroup.Clear();
						var MapCreationGroupText = GetMapCreationGroupText();
						var MapCreationLabels = GetMapCreationGroupLabels();

						CurrentGroup.Add(GetSettingsFirstSlide
                            (MapCreationLabels[0], MapCreationGroupText[0], GetNextButton(1,"Ресурсы"), GetNextButton(2,"Ландшафт"), GetNextButton(3,"Противники"), GetNextButton()));
						CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[1], MapCreationGroupText[1], Backgrounds.ResourcesSlideBackground, GetPrevButton(), GetNextButton(), false));
                        CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[2], MapCreationGroupText[2],Backgrounds.LandscapeSlideBackground, GetPrevButton(), GetNextButton(), false));
                        CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[3], MapCreationGroupText[3],Backgrounds.EnemySlideBackground, GetPrevButton(), GetNextButton(), true));


						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;

						Controls.Add(Panel);
						break;

                    case 1://Первые шаги
						CurrentGroup.Clear();
						var firstStepsGroupText = GetFirstStepsText();
						var firstStepsGroupLabel = GetFirstStepsLabel();

						CurrentGroup.Add(GetSimpleSlideWithPicture(Pictures.firstSteps, firstStepsGroupLabel, firstStepsGroupText));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;

						Controls.Add(Panel);
						break;

					case 2://Электричество
						CurrentGroup.Clear();
						var electicityText = GetElectricityText();
						var electicityLabel = GetElectricityLabel();

						CurrentGroup.Add(GetSimpleSlideWithPicture(Pictures.electricity, electicityLabel, electicityText));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;

						Controls.Add(Panel);
						break;

					case 3: //Начальная наука
						CurrentGroup.Clear();
						var initialScienceText = GetInitialScienceText();
						var initialScienceLabel = GetInitialScienceLabel();

						CurrentGroup.Add(GetSimpleSlideWithPicture(Pictures.science, initialScienceLabel, initialScienceText));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;

						Controls.Add(Panel);
						break;

					case 4://Ресурсы
						CurrentGroup.Clear();
						var resourcesGroupTexts = GetResourcesGroupTexts();
						var resourcesGroupLabels = GetResourcesGroupLables();

						CurrentGroup.Add(GetResourcesMainSlide(
							GetPictureBoxButton(Pictures.stone,1),GetPictureBoxButton(Pictures.wood,2),
							GetPictureBoxButton(Pictures.coal,3),GetPictureBoxButton(Pictures.coper,4),
							GetPictureBoxButton(Pictures.iron,5),GetPictureBoxButton(Pictures.water,6),
							GetPictureBoxButton(Pictures.oil,7),GetPictureBoxButton(Pictures.uranium,8),GetPictureBoxButton(Pictures.fish,9)));
                        CurrentGroup.Add(GetResourceSlide(Pictures.stone, resourcesGroupLabels[0], resourcesGroupTexts[0],GetPrevButton(1,"Назад"), true));
                        CurrentGroup.Add(GetResourceSlide(Pictures.wood, resourcesGroupLabels[1], resourcesGroupTexts[1], GetPrevButton(2, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.coal, resourcesGroupLabels[2], resourcesGroupTexts[2], GetPrevButton(3, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.coper, resourcesGroupLabels[3], resourcesGroupTexts[3], GetPrevButton(4, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.iron, resourcesGroupLabels[4], resourcesGroupTexts[4], GetPrevButton(5, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.water, resourcesGroupLabels[5], resourcesGroupTexts[5], GetPrevButton(6, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.oil, resourcesGroupLabels[6], resourcesGroupTexts[6], GetPrevButton(7, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.uranium, resourcesGroupLabels[7], resourcesGroupTexts[7], GetPrevButton(8, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.fish, resourcesGroupLabels[8], resourcesGroupTexts[8], GetPrevButton(9, "Назад"), true));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
                        break;

					case 5://Транспортировка
						CurrentGroup.Clear();
						var transportGroupTexts = GetTransportGroupTexts();
						var transportGroupLabels = GetTransportGroupLabels();

						CurrentGroup.Add(GetTransportMainSlide(
							GetPictureBoxButton(Pictures.Belts, 1), GetPictureBoxButton(Pictures.Manipulator, 2),
							GetPictureBoxButton(Pictures.Pipes, 3), GetPictureBoxButton(Pictures.Train, 4), GetPictureBoxButton(Pictures.Drones, 5)));
						CurrentGroup.Add(GetResourceSlide(Pictures.Belts, transportGroupLabels[0], transportGroupTexts[0], GetPrevButton(1, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.Manipulator, transportGroupLabels[1], transportGroupTexts[1], GetPrevButton(2, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.Pipes, transportGroupLabels[2], transportGroupTexts[2], GetPrevButton(3, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.Train, transportGroupLabels[3], transportGroupTexts[3], GetPrevButton(4, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.Drones, transportGroupLabels[4], transportGroupTexts[4], GetPrevButton(5, "Назад"), true));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;


					case 6: //Важность обороны
						CurrentGroup.Clear();
						var defenceGroupTexts = GetDefenceGroupTexts();
						var defenceGroupLabels = GetDefenceGroupLabels();

						CurrentGroup.Add(GetDefenceGroupMainSlide(Pictures.Жуки, defenceGroupLabels[0], defenceGroupTexts[0],
							GetNextButton(1, "Оружие"), GetNextButton(2, "Турели"), GetNextButton(3, "Гранаты"), GetNextButton(4, "Броня")));
                        CurrentGroup.Add(GetResourceSlide(Pictures.guns, defenceGroupLabels[1], defenceGroupTexts[1], GetPrevButton(1, "Назад"), false));
						CurrentGroup.Add(GetResourceSlide(Pictures.turret, defenceGroupLabels[2], defenceGroupTexts[2], GetPrevButton(2, "Назад"), true));
						CurrentGroup.Add(GetResourceSlide(Pictures.grenade, defenceGroupLabels[3], defenceGroupTexts[3], GetPrevButton(3, "Назад"), false));
						CurrentGroup.Add(GetResourceSlide(Pictures.Armor, defenceGroupLabels[4], defenceGroupTexts[4], GetPrevButton(4, "Назад"), true));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;

					case 7: //Cоветы
						CurrentGroup.Clear();
						var tipsTexts = GetTipsTexts();
						var tipsLabel = GetTipsLabel();

						CurrentGroup.Add(GetTipsSlide(tipsLabel, tipsTexts[0], tipsTexts[1], tipsTexts[2]));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;

					case 8: //Финал
						CurrentGroup.Clear();
						var finalText = GetFinalText();
						var finalLabel = GetFinalLabel();

						CurrentGroup.Add(GetSimpleSlideWithPicture(Pictures.Final,finalLabel, finalText));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;
				}
            };
			Controls.Add(Chapters);
			Controls.Add(Panel);
		}
				
		/// <summary>
		/// метод для перехода на следующий слайд при нажатии на объект
		/// </summary>
		/// <param name="sender">объект - отправитель</param>
		/// <param name="e"></param>
		private void nextButtonClick(object sender, EventArgs e)
		{
			Controls.Remove(Panel);
			currentPanel = currentPanel.Next;
			Panel = currentPanel.Value;
			Controls.Add(Panel);
		}

		/// <summary>
		/// метод перехода на предыдущий слайд при нажатии на объект
		/// </summary>
		/// <param name="sender">объект - отправитель</param>
		/// <param name="e"></param>
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
			nextButton.BackColor = FormColors.AccentColor;
			nextButton.ForeColor = Color.White;
			nextButton.Click += nextButtonClick;
			return nextButton;
		}

		/// <summary>
		/// конструктор кнопки для перехода на stepsCount слайдов вперед
		/// </summary>
		/// <param name="stepsCount">количество переходов вперед</param>
		/// <param name="text">текст кнопки</param>
		/// <returns></returns>
		private Button GetNextButton(int stepsCount, string text)
        {
			var nextButton = new Button { Text = text, Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			nextButton.BackColor = FormColors.AccentColor;
			nextButton.ForeColor = Color.White;
			nextButton.Font = new Font(nextButton.Font, FontStyle.Bold);
			nextButton.UseCompatibleTextRendering = true;
			for (int i = 0; i < stepsCount; i++)
				nextButton.Click += nextButtonClick;
			return nextButton;
		}

		/// <summary>
		/// конструктор кнопки для перехода на предыдущий слайд
		/// </summary>
		/// <returns></returns>
		private Button GetPrevButton()
        {
			var prevButton = new Button { Text = "Назад", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			prevButton.BackColor = FormColors.AccentColor;
			prevButton.ForeColor = Color.White;
			prevButton.Click += prevButtonClick;
			return prevButton;
		}

		/// <summary>
		/// конструктор кнопки для перехода на stepsCount слайдов назад
		/// </summary>
		/// <param name="stepsCount"> число переходов</param>
		/// <param name="text">текст кнопки</param>
		/// <returns></returns>
		private Button GetPrevButton(int stepsCount, string text)
		{
			var prevButton = new Button { Text = text, Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, Margin = new Padding(0) };
			prevButton.BackColor = FormColors.AccentColor;
			prevButton.ForeColor = Color.White;
			prevButton.Font = new Font(prevButton.Font, FontStyle.Bold);
			prevButton.UseCompatibleTextRendering = true;
			for (int i = 0; i < stepsCount; i++)
				prevButton.Click += prevButtonClick;
			return prevButton;
		}

		/// <summary>
		/// конструктор Picturebox-кнопки
		/// </summary>
		/// <param name="picture">картинка кнопки</param>
		/// <param name="stepsCount">число переходов вперед</param>
		/// <returns></returns>
		private PictureBox GetPictureBoxButton(Bitmap picture, int stepsCount)
        {
			var pictureBox = new PictureBox() {Image = picture};
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.Dock = DockStyle.Fill;
			for (int i = 0; i < stepsCount; i++)
				pictureBox.Click += nextButtonClick;
			return pictureBox;
        }
	}
}
