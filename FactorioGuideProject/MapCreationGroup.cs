using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FactorioGuideProject.Scheme;
using static FactorioGuideProject.GuideForm;
using System.Drawing;

namespace FactorioGuideProject
{
	public class MapCreationGroup
	{
		public static Label[] GetMapCreationGroup()
		{
			var MapCreationGroupText = new List<Label>();
			MapCreationGroupText.Add(new Label()
			{
				Text = "Генератор карты - это совокупность настроек, с помощью которых определяется, как будет выглядеть ваш мир после создания. " +
				"Для новичков рекомендуется оставлять дефолтные настройки, мы тоже оставили, за исключением некоторых пунктов, о которых расскажем ниже.",
				Dock = DockStyle.Fill,
				ForeColor = Color.White
			});

			MapCreationGroupText.Add(new Label()
			{
				Text = "Ресурсы." +
				Environment.NewLine + "В данном разделе мы оставили все без изменений, но стоит поговорить о некоторых параметрах." +
				Environment.NewLine + "Частота отвечает за то, как часто вы будете находить месторождения руды определенного типа." +
				Environment.NewLine + "Размер отвечает за площадь скоплений руды, а богатство - за количество руды в клетке залежи.",
				Dock = DockStyle.Fill,
				ForeColor = Color.White
			});

			MapCreationGroupText.Add(new Label()
			{
				Text = "Ландшафт." +
				Environment.NewLine + "В данном разделе мы также остались  при заводских настройках, кроме скал." +
				Environment.NewLine + "Они мешают постройке больших систем, и передвижению, а также их невозможно убрать на ранних этапах игры." +
				Environment.NewLine + "Для их разрушения нужна взрывчатка для скал, а после взрыва с них не выпадает никаких ресурсов",
				Dock = DockStyle.Fill,
				ForeColor = Color.White
			});

			MapCreationGroupText.Add(new Label()
			{
				Text = "Враг." +
				Environment.NewLine + "В этом разделе изменений коснулись “Экспансия врагов” и “Эволюция”." +
				Environment.NewLine + 
				Environment.NewLine + "Экспансия." +
				Environment.NewLine + "Если кратко - данный параметр позволяет кусакам кочевать." +
				"В какой - то момент враги могут оставить свое гнездо и уйти на постройки нового," +
				"в настройках мы можем повлиять на время переезда,размер группы и дистанцию." +
				"Чтобы немного упростить себе жизнь мы отключаем такую возможность." +
				Environment.NewLine + 
				Environment.NewLine + "Эволюция" +
				Environment.NewLine + "Эволюция - это развитие врагов, на которое могут влиять три фактора: время, уничтожение ульев, загрязнение." +
				"Мы оставили минимальную скорость эволюции.",
				Dock = DockStyle.Fill,
				ForeColor = Color.White
			});

			return MapCreationGroupText.ToArray();
		}

		public static Label[] GetMapCreationLabels()
        {
			var labels = new List<Label>();
			labels.Add(new Label { Text = "Настройки мира игры", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Ресурсы", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Ландшафт", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Противники", Dock = DockStyle.Fill, ForeColor = Color.White });
			return labels.ToArray();
		}
	}
}
