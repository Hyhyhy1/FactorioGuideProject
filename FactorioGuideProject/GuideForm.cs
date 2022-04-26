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
		TableLayoutPanel Previous;
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
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(new Panel(), 0, 3); 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(initialSlideLabel, 1, 1);//заменить на заголовок(возможно)
			panel.Controls.Add(initialSlideText, 1, 2);//заменить на текст
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(new Panel(), 2, 3);
			panel.Controls.Add(new Panel(), 2, 4);

			panel.Dock = DockStyle.Fill;

			Controls.Add(Chapters);
			Controls.Add(panel);

			Chapters.SelectedIndexChanged += (sender, args) =>
			{
				Controls.Remove(panel);
				panel = Scheme.CreateNewTablePanel();

				switch (Chapters.SelectedIndex)
				{
					case 0://Создание карты
						Scheme.GetSiplePage(panel, mapCreationLabel, mapCreationText);
						Controls.Add(panel);
						break;

					case 1://Первые шаги
						Scheme.GetPageWithNextButton(panel,firstStepsLabel,firstStepsText0,nextSlide)

						Controls.Add(panel);
						break;

					case 2://Электричество
						Scheme.GetPageWithNextButton(panel, electricityLabel, electricityText0, nextSlide)

						Controls.Add(panel);
						break;

					case 3://Первая автоматизация
						Scheme.GetPageWithNextButton(panel, initialAutomationLabel, initialAutomationText0, nextSlide)

						Controls.Add(panel);
						break;

					case 4://Красная наука
						panel.Controls.Add(new Panel(), 0, 0);
						panel.Controls.Add(new Panel(), 0, 1);
						panel.Controls.Add(new Panel(), 0, 2);
						panel.Controls.Add(new Panel(), 0, 3);//заменить на кнопку 
						panel.Controls.Add(new Panel(), 0, 4);
						panel.Controls.Add(new Panel(), 1, 0);
						panel.Controls.Add(mapCreationLabel, 1, 1);//заменить заголовок
						panel.Controls.Add(mapCreationText, 1, 2);//заменить текст
						panel.Controls.Add(new Panel(), 1, 3);
						panel.Controls.Add(new Panel(), 1, 4);
						panel.Controls.Add(new Panel(), 2, 0);
						panel.Controls.Add(new Panel(), 2, 1);
						panel.Controls.Add(new Panel(), 2, 2);
						panel.Controls.Add(new Panel(), 2, 3);//заменить на кнопку
						panel.Controls.Add(new Panel(), 2, 4);

						Controls.Add(panel);
						break;
				}
			};
		}
	}
}
