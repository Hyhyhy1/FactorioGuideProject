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


		/// <summary>
		/// таблица с 1й строкой и 3мя колонками
		/// </summary>
		/// <returns></returns>
		public static TableLayoutPanel CreatePanel1_3()
        {
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 1й строкой и 2мя колонками
		/// </summary>
		/// <returns></returns>
		public static TableLayoutPanel CreatePanel1_2()
		{
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// таблица с 3мя строками и 2мя колонками
		/// </summary>
		/// <returns></returns>
		public static TableLayoutPanel CreatePanel3_2()
		{
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 40));
			panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 60));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
			panel.Dock = DockStyle.Fill;
			return panel;
		}

		/// <summary>
		/// этот метод создает простой слайд без кнопок
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <returns></returns>
		public static TableLayoutPanel GetSiplePage(Label label, TextBox text)
        {
			var panel = CreateSimplePanel();
			panel.Controls.Add(GetPlaceholder(), 0, 0);
			panel.Controls.Add(GetPlaceholder(), 0, 1);
			panel.Controls.Add(GetPlaceholder(), 0, 2);
			panel.Controls.Add(GetPlaceholder(), 0, 3); 
			panel.Controls.Add(GetPlaceholder(), 0, 4);
			panel.Controls.Add(GetPlaceholder(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(GetPlaceholder(), 1, 3);
			panel.Controls.Add(GetPlaceholder(), 1, 4);
			panel.Controls.Add(GetPlaceholder(), 2, 0);
			panel.Controls.Add(GetPlaceholder(), 2, 1);
			panel.Controls.Add(GetPlaceholder(), 2, 2);
			panel.Controls.Add(GetPlaceholder(), 2, 3);
			panel.Controls.Add(GetPlaceholder(), 2, 4);
			return panel;
		}

		/// <summary>
		/// Конструктор начальный слайдов в разделе
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="nextSlide">кнопка перехода вперед</param>
		/// <returns></returns>
		public static TableLayoutPanel GetPageWithNextButton(Label label, TextBox text, Button nextSlide)
        {
			var panel = CreateSimplePanel();
			panel.Controls.Add(GetPlaceholder(), 0, 0);
			panel.Controls.Add(GetPlaceholder(), 0, 1);
			panel.Controls.Add(GetPlaceholder(), 0, 2);
			panel.Controls.Add(GetPlaceholder(), 0, 3);
			panel.Controls.Add(GetPlaceholder(), 0, 4);
			panel.Controls.Add(GetPlaceholder(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(GetPlaceholder(), 1, 3);
			panel.Controls.Add(GetPlaceholder(), 1, 4);
			panel.Controls.Add(GetPlaceholder(), 2, 0);
			panel.Controls.Add(GetPlaceholder(), 2, 1);
			panel.Controls.Add(GetPlaceholder(), 2, 2);
			panel.Controls.Add(nextSlide, 2, 3);
			panel.Controls.Add(GetPlaceholder(), 2, 4);
			return panel;
		}

		/// <summary>
		/// конструктор центральных слайдов в разделе
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="nextSlide">кнопка перехода вперед</param>
		/// <param name="prevSlide">кнопка перехода назад</param>
		/// <returns></returns>
		public static TableLayoutPanel GetPageWithTwoButtons(Label label, TextBox text, Button nextSlide, Button prevSlide)
		{
			var panel = CreateSimplePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(prevSlide, 0, 3); 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(nextSlide, 2, 3);
			panel.Controls.Add(new Panel(), 2, 4);
			return panel;
		}

		/// <summary>
		/// конструктор конечных слайдов разделов
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="prevSlide">кнопка перехода назад</param>
		/// <returns></returns>
		public static TableLayoutPanel GetPageWithPrevButton(Label label, TextBox text, Button prevSlide)
		{
			var panel = CreateSimplePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(prevSlide, 0, 3);
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(new Panel(), 2, 3);
			panel.Controls.Add(new Panel(), 2, 4);
			return panel;
		}

		public static TableLayoutPanel GetDificultSlide(Label label, Label text, Button nextButton, Button prevButton, Button first, Button second, Button third)
        {
			var panel = CreateSimplePanel();
			panel.Controls.Add(GetPlaceholder(), 0, 0);
			panel.Controls.Add(GetPlaceholder(), 0, 1);
			panel.Controls.Add(GetPlaceholder(), 0, 2);
			panel.Controls.Add(GetPlaceholder(), 0, 3);
			panel.Controls.Add(GetPlaceholder(), 0, 4);
			panel.Controls.Add(GetPlaceholder(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(GetTextAndThreeButtons(text, first, second, third), 1, 2);
			panel.Controls.Add(GetTwoButtonsRow(nextButton,prevButton), 1, 3);
			panel.Controls.Add(GetPlaceholder(), 1, 4);
			panel.Controls.Add(GetPlaceholder(), 2, 0);
			panel.Controls.Add(GetPlaceholder(), 2, 1);
			panel.Controls.Add(GetPlaceholder(), 2, 2);
			panel.Controls.Add(GetPlaceholder(), 2, 3);
			panel.Controls.Add(GetPlaceholder(), 2, 4);
			return panel;
		}

		private static TableLayoutPanel GetTwoButtonsRow(Button nextButton, Button prevButton)
        {
			var panel = CreatePanel1_3();
			panel.Controls.Add(prevButton, 0, 0);
			panel.Controls.Add(new Panel(),1,0);
			panel.Controls.Add(nextButton, 2, 0);
			return panel;
		}

		private static TableLayoutPanel GetTextAndThreeButtons(Label text, Button first, Button second, Button third)
        {
			var panel = CreatePanel1_2();
			panel.Controls.Add(GetThreeButtons(first,second,third), 0, 0);
			panel.Controls.Add(text, 1, 0);
			return panel;
		}

		private static TableLayoutPanel GetThreeButtons(Button first, Button second, Button third)
        {
			var panel = CreatePanel3_2();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(first, 1, 0);
			panel.Controls.Add(second, 1, 1);
			panel.Controls.Add(third, 1, 2);
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
