using System.Windows.Forms;

namespace FactorioGuideProject
{
    public static class Scheme
    {
		/// <summary>
		/// стандартный макет таблицы слайда
		/// </summary>
		/// <returns>стандартный макет таблицы</returns>
		public static TableLayoutPanel CreateNewTablePanel()
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
		/// этот метод создает простой слайд без кнопок
		/// </summary>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <returns></returns>
		public static TableLayoutPanel GetSiplePage(Label label, TextBox text)
        {
			var panel = CreateNewTablePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(new Panel(), 0, 3);//заменить на кнопку 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(new Panel(), 2, 3);//заменить на кнопку
			panel.Controls.Add(new Panel(), 2, 4);
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
			var panel = CreateNewTablePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(new Panel(), 0, 3);//заменить на кнопку 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(nextSlide, 2, 3);//заменить на кнопку
			panel.Controls.Add(new Panel(), 2, 4);
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
			var panel = CreateNewTablePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(prevSlide, 0, 3);//заменить на кнопку 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(nextSlide, 2, 3);//заменить на кнопку
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
			var panel = CreateNewTablePanel();
			panel.Controls.Add(new Panel(), 0, 0);
			panel.Controls.Add(new Panel(), 0, 1);
			panel.Controls.Add(new Panel(), 0, 2);
			panel.Controls.Add(prevSlide, 0, 3);//заменить на кнопку 
			panel.Controls.Add(new Panel(), 0, 4);
			panel.Controls.Add(new Panel(), 1, 0);
			panel.Controls.Add(label, 1, 1);
			panel.Controls.Add(text, 1, 2);
			panel.Controls.Add(new Panel(), 1, 3);
			panel.Controls.Add(new Panel(), 1, 4);
			panel.Controls.Add(new Panel(), 2, 0);
			panel.Controls.Add(new Panel(), 2, 1);
			panel.Controls.Add(new Panel(), 2, 2);
			panel.Controls.Add(new Panel(), 2, 3);//заменить на кнопку
			panel.Controls.Add(new Panel(), 2, 4);
			return panel;
		}
	}
}
