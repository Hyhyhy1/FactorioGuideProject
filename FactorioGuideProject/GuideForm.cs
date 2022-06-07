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

			Panel = GetSimplePage(initialSlideLabel, initialSlideText);

			var Chapters = new ComboBox()
			{
				Location = new Point(0, 0),
				Size = new Size(210, 40),
				Text = "Этапы прохождения",
				DropDownStyle = ComboBoxStyle.DropDownList
			};

			Chapters.Items.Add("Создание карты");
			Chapters.Items.Add("Первые шаги");
			Chapters.Items.Add("Ресурсы");
			Chapters.Items.Add("Транспортировка предметов");
			Chapters.Items.Add("Начальная наука");
			Chapters.Items.Add("Важность обороны");
			Chapters.Items.Add("Синяя наука");
			Chapters.Items.Add("Фиолетовая и желтая наука");
			Chapters.Items.Add("Финал!");

			Chapters.SelectedIndexChanged += (sender, args) =>
			{
				Controls.Remove(Panel);

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						CurrentGroup.Clear();
						var MapCreationGroupText = GetMapCreationGroup();
						var MapCreationLabels = GetMapCreationLabels();

						CurrentGroup.Add(GetDificultSlide
                            (MapCreationLabels[0], MapCreationGroupText[0], GetNextButton(1,"Ресурсы"), GetNextButton(2,"Ландшафт"), GetNextButton(3,"Противники"), GetNextButton()));
						CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[1], MapCreationGroupText[1], Backgrounds.ResourcesSlideBackground, GetPrevButton(), GetNextButton(), false));
                        CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[2], MapCreationGroupText[2],Backgrounds.LandscapeSlideBackground, GetPrevButton(), GetNextButton(), false));
                        CurrentGroup.Add(GetSettingsSlide(MapCreationLabels[3], MapCreationGroupText[3],Backgrounds.EnemySlideBackground, GetPrevButton(), GetNextButton(), true));


						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;

						Controls.Add(Panel);
						break;

                    //case 1://Первые шаги
                    //	Scheme.GetPageWithNextButton(panel, firstStepsLabel, firstStepsText0, nextSlide);
                    //	Controls.Add(panel);
                    //	break;

                    case 2://Ресурсы
						CurrentGroup.Clear();
						var resourcesGroupTexts = ResourcesGroup.GetResourcesGroupTexts();
						var resourcesGroupLabels = ResourcesGroup.GetResourcesGroupLables();

						CurrentGroup.Add(GetResourcesMainSlide(
							GetPictureBoxButton(Resource1.stone,1),GetPictureBoxButton(Resource1.wood,2),
							GetPictureBoxButton(Resource1.coal,3),GetPictureBoxButton(Resource1.coper,4),
							GetPictureBoxButton(Resource1.iron,5),GetPictureBoxButton(Resource1.water,6),
							GetPictureBoxButton(Resource1.oil,7),GetPictureBoxButton(Resource1.uranium,8),GetPictureBoxButton(Resource1.fish,9)));
                        CurrentGroup.Add(GetResource(Resource1.stone, resourcesGroupLabels[0], resourcesGroupTexts[0],GetPrevButton(1,"Назад")));
                        CurrentGroup.Add(GetResource(Resource1.wood, resourcesGroupLabels[1], resourcesGroupTexts[1], GetPrevButton(2, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.coal, resourcesGroupLabels[2], resourcesGroupTexts[2], GetPrevButton(3, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.coper, resourcesGroupLabels[3], resourcesGroupTexts[3], GetPrevButton(4, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.iron, resourcesGroupLabels[4], resourcesGroupTexts[4], GetPrevButton(5, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.water, resourcesGroupLabels[5], resourcesGroupTexts[5], GetPrevButton(6, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.oil, resourcesGroupLabels[6], resourcesGroupTexts[6], GetPrevButton(7, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.uranium, resourcesGroupLabels[7], resourcesGroupTexts[7], GetPrevButton(8, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.fish, resourcesGroupLabels[8], resourcesGroupTexts[8], GetPrevButton(9, "Назад")));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
                        break;

					case 3://Транспортировка
						CurrentGroup.Clear();
						var transportGroupTexts = TransportGroup.GetTransportGroupTexts();
						var transportGroupLabels = TransportGroup.GetTransportGroupLabels();

						CurrentGroup.Add(GetTransportMainSlide(
							GetPictureBoxButton(Resource1.Belts, 1), GetPictureBoxButton(Resource1.Manipulator, 2),
							GetPictureBoxButton(Resource1.Pipes, 3), GetPictureBoxButton(Resource1.Train, 4), GetPictureBoxButton(Resource1.Drones, 5)));
						CurrentGroup.Add(GetResource(Resource1.Belts, transportGroupLabels[0], transportGroupTexts[0], GetPrevButton(1, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.Manipulator, transportGroupLabels[1], transportGroupTexts[1], GetPrevButton(2, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.Pipes, transportGroupLabels[2], transportGroupTexts[2], GetPrevButton(3, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.Train, transportGroupLabels[3], transportGroupTexts[3], GetPrevButton(4, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.Drones, transportGroupLabels[4], transportGroupTexts[4], GetPrevButton(5, "Назад")));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;


					case 5: //Важность обороны
						CurrentGroup.Clear();
						var defenceGroupTexts = DefenceGroup.GetDefenceGroupTexts();
						var defenceGroupLabels = DefenceGroup.GetDefenceGroupLabels();

						CurrentGroup.Add(GetDefenceGroupMainSlide(Resource1.Жуки, defenceGroupLabels[0], defenceGroupTexts[0],
							GetNextButton(1, "Оружие"), GetNextButton(2, "Турели"), GetNextButton(3, "Гранаты"), GetNextButton(4, "Броня")));
                        CurrentGroup.Add(GetResource(Resource1.guns, defenceGroupLabels[1], defenceGroupTexts[1], GetPrevButton(1, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.turret, defenceGroupLabels[2], defenceGroupTexts[2], GetPrevButton(2, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.grenade, defenceGroupLabels[3], defenceGroupTexts[3], GetPrevButton(3, "Назад")));
						CurrentGroup.Add(GetResource(Resource1.Armor, defenceGroupLabels[4], defenceGroupTexts[4], GetPrevButton(4, "Назад")));

						currentPanel = CurrentGroup.First();
						Panel = currentPanel.Value;
						Controls.Add(Panel);
						break;
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
			nextButton.BackColor = FormColors.AccentColor;
			nextButton.ForeColor = Color.White;
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
			nextButton.BackColor = FormColors.AccentColor;
			nextButton.ForeColor = Color.White;
			nextButton.Font = new Font(nextButton.Font, FontStyle.Bold);
			nextButton.UseCompatibleTextRendering = true;
			for (int i = 0; i < stepsCount; i++)
				nextButton.Click += nextButtonClick;
			return nextButton;
		}

		private Button GetPrevButton()
        {
			var prevButton = new Button { Text = "Назад", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, };
			prevButton.BackColor = FormColors.AccentColor;
			prevButton.ForeColor = Color.White;
			prevButton.Click += prevButtonClick;
			return prevButton;
		}

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
