using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    public static class Scheme
    {
		/// <summary>
		/// стандартный макет таблицы слайда
		/// </summary>
		/// <returns></returns>
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
		/// конструктор простых слайдов
		/// </summary>
		/// <param name="panel">таблица</param>
		/// <param name="label">заголовок</param>
		/// <param name="text">текст</param>
		public static void GetSiplePage(TableLayoutPanel panel, Label label, TextBox text)
        {
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
		}

		/// <summary>
		/// Этот метод задает поля таблицы panel для первых слайдов раздела
		/// </summary>
		/// <param name="panel">таблица</param>
		/// <param name="label">заголовок</param>
		/// <param name="text">текст</param>
		/// <param name="nextSlide">кнопка для перехода на следующий слайд</param>
		public static void GetPageWithNextButton(TableLayoutPanel panel, Label label, TextBox text, Button nextSlide)
        {
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
		}

		/// <summary>
		/// Этот метод задает поля таблицы panel для центральных слайдов раздела
		/// </summary>
		/// <param name="panel">таблица</param>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="nextSlide">кнопка перехода на следующий слайд</param>
		/// <param name="prevSlide">кнопка перехода на прошлый слайд</param>
		public static void GetPageWithTwoButtons(TableLayoutPanel panel, Label label, TextBox text, Button nextSlide, Button prevSlide)
		{
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
		}

		/// <summary>
		/// Этот метод задает поля таблицы panel для конечных слайдов раздела
		/// </summary>
		/// <param name="panel">таблица</param>
		/// <param name="label">заголовок слайда</param>
		/// <param name="text">текст слайда</param>
		/// <param name="prevSlide">кнопка для перехода на прошлый слайд</param>
		public static void GetPageWithPrevButtons(TableLayoutPanel panel, Label label, TextBox text, Button prevSlide)
		{
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
		}
	}
}
