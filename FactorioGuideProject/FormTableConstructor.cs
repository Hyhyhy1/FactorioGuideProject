using System;
using System.Drawing;
using System.Windows.Forms;
using static FactorioGuideProject.GroupsData;
using static FactorioGuideProject.SlideTables;

namespace FactorioGuideProject
{
    public class Scheme
    {				
		/// <summary>
		/// этот метод создает простой слайд без кнопок
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <returns></returns>
		public static TableLayoutPanel GetSimpleSlide(Label label, Label text)
        {
			var panel = CreateSimplePanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.FirstSlideBackground;
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
		public static TableLayoutPanel GetSettingsFirstSlide(Label label, Label text, Button first, Button second, Button third, Button nextButton)
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

		/// <summary>
		/// Конструктор первого слайда раздела "ресурсы"
		/// </summary>
		/// <param name="stone"></param>
		/// <param name="wood"></param>
		/// <param name="coal"></param>
		/// <param name="coper"></param>
		/// <param name="iron"></param>
		/// <param name="water"></param>
		/// <param name="oil"></param>
		/// <param name="uranium"></param>
		/// <param name="fish"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetResourcesMainSlide(PictureBox stone, PictureBox wood, PictureBox coal, PictureBox coper, 
			PictureBox iron, PictureBox water, PictureBox oil, PictureBox uranium, PictureBox fish)
        {
			var panel = CreateResourcesMainPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.FirstSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			var label = new Label() { Text = "Ресурсы", AutoSize = true, Anchor = AnchorStyles.Top, ForeColor = Color.White, Font = new Font("Intro", 20, FontStyle.Bold) };
			panel.SuspendLayout();
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(GetResources(stone, wood, coal, coper, iron, water, oil, uranium, fish), 1, 2);
			panel.ResumeLayout();

			return panel;
		}

		/// <summary>
		/// конструктор первого слайда раздела "транспортировка"
		/// </summary>
		/// <param name="belt"></param>
		/// <param name="manipulator"></param>
		/// <param name="pipe"></param>
		/// <param name="train"></param>
		/// <param name="drone"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetTransportMainSlide(PictureBox belt, PictureBox manipulator, PictureBox pipe, PictureBox train, PictureBox drone)
        {
			var panel = CreateResourcesMainPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.FirstSlideBackground;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			panel.Controls.Add(new Label() { Text = "Транспортировка", AutoSize = true, Anchor = AnchorStyles.Top, ForeColor = Color.White, Font = new Font("Intro", 20, FontStyle.Bold) }, 1, 1);
			panel.Controls.Add(GetTransport(belt, manipulator, pipe, train, drone), 1, 2);
			return panel;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="picture"></param>
		/// <param name="label"></param>
		/// <param name="text"></param>
		/// <param name="prevButton"></param>
		/// <param name="isSquareImage"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetResourceSlide(Bitmap picture,Label label, Label text, Button prevButton, bool isSquareImage)
        {
			var panel = CreateResourcePanel();
			panel.BackColor = FormColors.MainColor;

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);

			panel.SuspendLayout();
			if(isSquareImage)
				panel.Controls.Add(new Panel() { Dock = DockStyle.Fill, BackColor = FormColors.AccentColor, Margin = new Padding(0) }, 0, 0);
			panel.Controls.Add(new PictureBox() { Image = picture, Dock = DockStyle.Fill, Margin = new Padding(0), SizeMode = PictureBoxSizeMode.StretchImage }, 0, 1);
			panel.Controls.Add(prevButton,0,2);
			panel.Controls.Add(GetLabelAndText(label, text), 1, 1);
			panel.ResumeLayout();

			return panel;
        }

		/// <summary>
		/// конструктор слайда "советы"
		/// </summary>
		/// <param name="label"></param>
		/// <param name="topText"></param>
		/// <param name="midText"></param>
		/// <param name="botText"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetTipsSlide(Label label, Label topText, Label midText, Label botText)
        {
			var panel = CreateTipsPanel();
			panel.BackColor = FormColors.MainColor;

			panel.BackgroundImage = Backgrounds.Tips;
			panel.BackgroundImageLayout = ImageLayout.Stretch;

			label.Font = new Font("Intro", 22, FontStyle.Bold);
			topText.Font = new Font("Actor", 10, FontStyle.Bold);
			midText.Font = new Font("Actor", 10, FontStyle.Bold);
			botText.Font = new Font("Actor", 10, FontStyle.Bold);

			panel.SuspendLayout();
			panel.Controls.Add(label, 2, 0);
			panel.Controls.Add(topText, 1, 1);
			panel.Controls.Add(midText, 2, 2);
			panel.Controls.Add(botText, 1, 3);
			panel.SetColumnSpan(panel.GetControlFromPosition(1, 1), 2);
			panel.SetColumnSpan(panel.GetControlFromPosition(1, 3), 2);
			panel.ResumeLayout();
			return panel;
		}

		/// <summary>
		/// Конструктор первого слайда раздела "оборона"
		/// </summary>
		/// <param name="picture"></param>
		/// <param name="label"></param>
		/// <param name="text"></param>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <param name="third"></param>
		/// <param name="fourth"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Конструктор простого слайда с картинкой
		/// </summary>
		/// <param name="picture"></param>
		/// <param name="label"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static TableLayoutPanel GetSimpleSlideWithPicture(Bitmap picture, Label label, Label text)
        {
			var panel = CreateResourcePanel();
			panel.BackColor = FormColors.MainColor;
			
			label.Font = new Font("Intro", 22, FontStyle.Bold);
			text.Font = new Font("Actor", 10, FontStyle.Bold);
			
			panel.SuspendLayout();
			panel.Controls.Add(new PictureBox() { Image = picture, Dock = DockStyle.Fill, Margin = new Padding(0), SizeMode = PictureBoxSizeMode.StretchImage }, 0, 0);
			panel.Controls.Add(GetLabelAndText(label, text), 1, 1);
			panel.SetRowSpan(panel.GetControlFromPosition(0,0), 3);
			panel.ResumeLayout();
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

		/// <summary>
		/// конструктор внутренней таблицы главного слайда раздела "ресурсы"
		/// </summary>
		/// <param name="stone"></param>
		/// <param name="wood"></param>
		/// <param name="coal"></param>
		/// <param name="coper"></param>
		/// <param name="iron"></param>
		/// <param name="water"></param>
		/// <param name="oil"></param>
		/// <param name="uranium"></param>
		/// <param name="fish"></param>
		/// <returns></returns>
		private static TableLayoutPanel GetResources(PictureBox stone, PictureBox wood, PictureBox coal, PictureBox coper, PictureBox iron, 
			PictureBox water, PictureBox oil, PictureBox uranium, PictureBox fish)
        {
			var labels = GroupsData.GetResourcesGroupLables();
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

		/// <summary>
		/// конструктор внутренней таблицы главного слайда раздела "транспортировка"
		/// </summary>
		/// <param name="belt"></param>
		/// <param name="manipulator"></param>
		/// <param name="pipe"></param>
		/// <param name="train"></param>
		/// <param name="drone"></param>
		/// <returns></returns>
		private static TableLayoutPanel GetTransport(PictureBox belt, PictureBox manipulator, PictureBox pipe, PictureBox train, PictureBox drone)
        {
			var panel = CreatePanel3_6();
			var labels = GetTransportGroupLabels();
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
