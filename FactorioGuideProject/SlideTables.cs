using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    internal class SlideTables
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

		internal static TableLayoutPanel CreateSettingsPanel()
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

		internal static TableLayoutPanel CreateResourcesMainPanel()
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

		internal static TableLayoutPanel CreateTipsPanel()
		{
			var panel = new TableLayoutPanel();
			panel.RowCount = 5;
			panel.ColumnCount = 4;

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
			panel.Dock = DockStyle.Fill;

			return panel;
		}

		/// <summary>
		/// таблица для слайдов ресурсов
		/// </summary>
		/// <returns></returns>
		internal static TableLayoutPanel CreateResourcePanel()
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

		internal static TableLayoutPanel CreateDefencePanel()
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

		internal static TableLayoutPanel CreatePanel4_1()
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
		/// таблица с 2мя строками и 1й колонкой
		/// </summary>
		/// <param name="first">ширина первой строки</param>
		/// <param name="second">ширина второй строки</param>
		/// <returns></returns>
		internal static TableLayoutPanel CreatePanel2_1(int first, int second)
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
		internal static TableLayoutPanel CreatePanel5_6()
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
		internal static TableLayoutPanel CreatePanel3_6()
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
	}
}
