using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    public class Scheme
    {
		
		/// <summary>
		/// стандартный макет таблицы слайда
		/// </summary>
		/// <returns>стандартный макет таблицы</returns>
		public static TableLayoutPanel CreateSimplePanel()
        {
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowCount = 5;
			panel.ColumnCount = 3;
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 7));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 3));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.Dock = DockStyle.Fill;
			
			return panel;

		}
		private static TableLayoutPanel CreateSettingsPanel()
        {
			var panel = new TableLayoutPanel();
			panel.RowCount = 4;
			panel.ColumnCount = 5;
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 7));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 3));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.Dock = DockStyle.Fill;

			return panel;
		}

		private static TableLayoutPanel CreateResourcesMainPanel()
        {
			var panel = new TableLayoutPanel();
			panel.RowCount = 4;
			panel.ColumnCount = 3;

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 65));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			panel.Dock = DockStyle.Fill;

			return panel;
		}

		/// <summary>
		/// таблица для слайдов ресурсов
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreateResourcePanel()
        {
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowCount = 3;
			panel.ColumnCount = 3;

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

        private static TableLayoutPanel CreateDefencePanel()
        {
            var panel = new TableLayoutPanel();
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            panel.Dock = DockStyle.Fill;
            return panel;
        }

        /// <summary>
        /// таблица с 1й строкой и 3мя колонками
        /// </summary>
        /// <returns></returns>
        public static TableLayoutPanel CreatePanel1_3()
        {
			TableLayoutPanel panel = new TableLayoutPanel();

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 3мя строками и 1й колонкой
		/// </summary>
		/// <returns></returns>
		public static TableLayoutPanel CreatePanel3_1()
        {
			var panel = new TableLayoutPanel();
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		public static TableLayoutPanel CreatePanel4_1()
        {
			var panel = new TableLayoutPanel();
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 1й строкой и 2мя колонками
		/// </summary>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel1_2(int first, int second)
		{
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, first));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, second));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 2мя строками и 1й колонкой
		/// </summary>
		/// <param name="first">ширина первой строки</param>
		/// <param name="second">ширина второй строки</param>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel2_1(int first, int second)
        {
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, first));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, second));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 5ю строками и 6ю столбцами
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel5_6()
        {
			TableLayoutPanel panel = new TableLayoutPanel();

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 3мя строками и 6ю столбцами
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel3_6()
        {
			var panel = new TableLayoutPanel();

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 2мя строками и 2мя столбцами
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel2_2()
        {
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 4мя строками и 2мя колонками
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreatePanel4_2()
		{
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// Этот метод создает таблицу с картинкой и текстом
		/// </summary>
		/// <returns></returns>
		private static TableLayoutPanel CreateTextAndPicturePanel(Bitmap bitmap, Label text)
        {
			var panel = CreatePanel1_2(40,60);
            var picture = new PictureBox{Image = bitmap};
			picture.Dock = DockStyle.Fill;
			picture.SizeMode = PictureBoxSizeMode.Zoom;
            panel.Controls.Add(picture, 0, 0);
			panel.Controls.Add(text, 1, 0);
			return panel;
		}

		/// <summary>
		/// Этот метод создает слайд с картинкой и тестом
		/// </summary>
		/// <param name="label">заголовк слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="nextButton"></param>
		/// <param name="prevButton"></param>
		/// <param name="picture"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetPageWithTextAndPicture(Label label, Label text, Button nextButton, Button prevButton, Bitmap picture)
        {
			var panel = CreateSimplePanel();
			panel.Controls.Add(prevButton, 0, 3);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(CreateTextAndPicturePanel(picture,text), 1, 2);
			panel.Controls.Add(nextButton, 2, 3);
			return panel;
		}

		/// <summary>
		/// этот метод создает простой слайд без кнопок
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <returns></returns>
		public static TableLayoutPanel GetSimplePage(Label label, Label text)
        {
			var panel = CreateSimplePanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.MainSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			panel.SuspendLayout();
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.ResumeLayout();

			return panel;
		}

		/// <summary>
		/// Конструктор обычных слайдов для раздела "настройка"
		/// </summary>
		/// <param name="label">заголовок</param>
		/// <param name="text">текс</param>
		/// <param name="backround">фон</param>
		/// <param name="prevButton">кнопка назад</param>
		/// <param name="nextButton">кнопка вперед</param>
		/// <param name="isLastSlide">маркер конца раздела</param>
		/// <returns></returns>
		public static TableLayoutPanel GetSettingsSlide(Label label, Label text, Bitmap backround, Button prevButton, Button nextButton, bool isLastSlide)
        {
			var panel = CreateSettingsPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = backround;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			var textPanel = CreatePanel2_1(15, 85);

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);

			textPanel.Controls.Add(label, 0, 0);
			textPanel.Controls.Add(text, 0, 1);

			panel.SuspendLayout();
			panel.Controls.Add(prevButton, 0, 2);
			panel.Controls.Add(textPanel, 3, 1);
			if (!isLastSlide)
				panel.Controls.Add(nextButton, 4, 2);
			panel.ResumeLayout();

			return panel;
		}

		/// <summary>
		/// конструктор начального слайда раздела "настройка"
		/// </summary>
		/// <param name="label"></param>
		/// <param name="text"></param>
		/// <param name="nextButton"></param>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <param name="third"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetDificultSlide(Label label, Label text, Button first, Button second, Button third, Button nextButton)
        {
			var panel = CreateSettingsPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.SettingsBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			var textPanel = CreatePanel2_1(15, 85);

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);

			textPanel.Controls.Add(label, 0, 0);
			textPanel.Controls.Add(text, 0, 1);

			panel.SuspendLayout();
			panel.Controls.Add(GetThreeButtonsWithSpaces(first, second, third), 1, 1);
			panel.Controls.Add(textPanel, 3, 1);
			panel.Controls.Add(nextButton, 4, 2);
			panel.ResumeLayout();

			return panel;
		}

		public static TableLayoutPanel GetResourcesMainSlide(PictureBox stone, PictureBox wood, PictureBox coal, PictureBox coper,
			PictureBox iron, PictureBox water, PictureBox oil, PictureBox uranium, PictureBox fish)
        {
			var panel = CreateResourcesMainPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.MainSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			var label = new Label() { Text = "Ресурсы", AutoSize = true, Anchor = AnchorStyles.Top, ForeColor = Color.White, Font = new Font("Intro", 20, FontStyle.Bold) };
			panel.SuspendLayout();
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(GetResources(stone, wood, coal, coper, iron, water, oil, uranium, fish), 1, 2);
			panel.ResumeLayout();

			return panel;
		}

		public static TableLayoutPanel GetTransportMainSlide(PictureBox belt, PictureBox manipulator, PictureBox pipe, PictureBox train, PictureBox drone)
        {
			var panel = CreateResourcesMainPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.MainSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			panel.Controls.Add(new Label() { Text = "Транспортировка", AutoSize = true, Anchor = AnchorStyles.Top, ForeColor = Color.White, Font = new Font("Intro", 20, FontStyle.Bold) }, 1, 1);
			panel.Controls.Add(GetTransport(belt, manipulator, pipe, train, drone), 1, 2);
			return panel;
		}

		public static TableLayoutPanel GetResource(Bitmap picture,Label label, Label text, Button prevButton)
        {
			var panel = CreateResourcePanel();
			panel.BackColor = FormColors.MainColor;

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);

			panel.SuspendLayout();
			panel.Controls.Add(new Panel() { Dock = DockStyle.Fill, BackColor = FormColors.AccentColor, Margin = new Padding(0) }, 0, 0);
			panel.Controls.Add(new PictureBox() { Image = picture, Dock = DockStyle.Fill, Margin = new Padding(0), SizeMode = PictureBoxSizeMode.StretchImage }, 0, 1);
			panel.Controls.Add(prevButton,0,2);
			panel.Controls.Add(GetLabelAndText(label, text), 1, 1);
			panel.ResumeLayout();

			return panel;
        }

		public static TableLayoutPanel GetDefenceGroupMainSlide(Bitmap picture, Label label, Label text, Button first, Button second, Button third, Button fourth)
        {
			var panel = CreateDefencePanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.DefenceSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			var textPanel = CreatePanel2_1(15, 85);

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);

			textPanel.Controls.Add(label, 0, 0);
			textPanel.Controls.Add(text, 0, 1);

			panel.Controls.Add(textPanel, 1, 1);
			panel.Controls.Add(GetPlaceholder(), 1, 2);
			panel.Controls.Add(GetFourButtons(first, second, third, fourth), 2, 1);
			panel.Controls.Add(GetPlaceholder(), 2, 2);
			return panel;
		}

		private static TableLayoutPanel GetThreeButtonsWithSpaces(Button first, Button second, Button third)
        {
			var panel = CreatePanel4_1();
			panel.Controls.Add(first, 0, 0);
			panel.Controls.Add(second, 0, 1);
			panel.Controls.Add(third, 0, 2);
			panel.Controls.Add(GetPlaceholder(), 0, 3);
			return panel;
		}

		private static TableLayoutPanel GetFourButtons(Button first, Button second, Button third, Button fourth)
        {
			var panel = CreatePanel4_1();
			panel.Controls.Add(first, 0, 0);
			panel.Controls.Add(second, 0, 1);
			panel.Controls.Add(third, 0, 2);
			panel.Controls.Add(fourth, 0, 3);
			return panel;

		}

		private static TableLayoutPanel GetLabelAndText(Label label, Label text)
        {
			var panel = CreatePanel2_1(20,80);
			panel.Controls.Add(label, 0, 0);
			panel.Controls.Add(text, 0, 1);
			return panel;
        }

		private static TableLayoutPanel GetResources(PictureBox stone, PictureBox wood, PictureBox coal, PictureBox coper, 
			PictureBox iron, PictureBox water, PictureBox oil, PictureBox uranium, PictureBox fish)
        {
			var labels = ResourcesGroup.GetResourcesGroupLables();
			var panel = CreatePanel5_6();
			panel.Controls.Add(stone, 1, 0);
			panel.Controls.Add(wood, 1, 1);
			panel.Controls.Add(coal, 1, 2);
			panel.Controls.Add(coper, 1, 3);
			panel.Controls.Add(iron, 1, 4);
            panel.Controls.Add(labels[0], 2, 0);
            panel.Controls.Add(labels[1], 2, 1);
            panel.Controls.Add(labels[2], 2, 2);
            panel.Controls.Add(labels[3], 2, 3);
            panel.Controls.Add(labels[4], 2, 4);
			panel.Controls.Add(water, 3, 0);
			panel.Controls.Add(oil, 3, 1);
			panel.Controls.Add(uranium, 3, 2);
			panel.Controls.Add(fish, 3, 3);
			panel.Controls.Add(GetPlaceholder(), 3, 4);
            panel.Controls.Add(labels[5], 4, 0);
            panel.Controls.Add(labels[6], 4, 1);
            panel.Controls.Add(labels[7], 4, 2);
            panel.Controls.Add(labels[8], 4, 3);
			return panel;
		}

		private static TableLayoutPanel GetTransport(PictureBox belt, PictureBox manipulator, PictureBox pipe, PictureBox train, PictureBox drone)
        {
			var panel = CreatePanel3_6();
			var labels = TransportGroup.GetTransportGroupLabels();
			panel.Controls.Add(belt, 1, 0);
			panel.Controls.Add(manipulator, 1, 1);
			panel.Controls.Add(pipe, 1, 2);
			panel.Controls.Add(labels[0], 2, 0);
			panel.Controls.Add(labels[1], 2, 1);
			panel.Controls.Add(labels[2], 2, 2);
			panel.Controls.Add(train, 3, 0);
			panel.Controls.Add(drone, 3, 1);
			panel.Controls.Add(GetPlaceholder(), 3, 2);
			panel.Controls.Add(labels[3], 4, 0);
			panel.Controls.Add(labels[4], 4, 1);
			return panel;
		}

		/// <summary>
		/// Конструктор плейсхолдеров
		/// </summary>
		/// <returns>Возвращает празрачный Panel для таблиц</returns>
		private static Panel GetPlaceholder()
        {
			var panel = new Panel();
			panel.BackColor = Color.Transparent;
			return panel;
		}
	}
}
