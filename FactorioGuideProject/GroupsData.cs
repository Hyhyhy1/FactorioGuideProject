using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FactorioGuideProject.Scheme;
using static FactorioGuideProject.GuideForm;
using System.Drawing;

namespace FactorioGuideProject
{
	public class GroupsData
	{
		public static Label[] GetMapCreationGroupText()
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

		public static Label[] GetMapCreationGroupLabels()
        {
			var labels = new List<Label>();
			labels.Add(new Label { Text = "Настройки мира игры", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Ресурсы", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Ландшафт", Dock = DockStyle.Fill, ForeColor = Color.White });
			labels.Add(new Label { Text = "Противники", Dock = DockStyle.Fill, ForeColor = Color.White });
			return labels.ToArray();
		}

        public static Label[] GetTransportGroupLabels()
        {
            var group = new List<Label>();
            group.Add(new Label() { Text = "Конвейер", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Манипуляторы", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Трубы", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Поезд", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Дроны", Dock = DockStyle.Fill, ForeColor = Color.White, });
            return group.ToArray();
        }

        public static Label[] GetTransportGroupTexts()
        {
            var group = new List<Label>();
            group.Add(new Label()
            {
                Text = "Система транспортировки конвейером - это первый механизм, который позволяет автоматизировать доставку в начале игры. " +
                "Пропускная способность самой простой ленты - 15 предметов в секунду. " +
                "Есть более быстрые конвейеры, их скорость достигает 40 предметов в секунду. " +
                "Также есть подземные конвейеры позволяющие перемещать предметы под препятствиями или другими постройками.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Перемещают предметы на небольшие расстояния. Например, с конвейера в печь. Игрок может менять направление подачи нажатием клавиш R. " +
                "Существует несколько видов манипуляторов: твердотопливный, электрический, быстрый, длинный, фильтрующий и пакетный. " +
                "Тведотопливный манипулятор для своей работы потребляет топливо, электрический требует подключения к сети. " +
                "Быстрый манипулятор отличается повышенной скоростью работы. " +
                "Длинный манипулятор позволяет передавать ресурсы на большее расстояние, а также, он немного быстрее электрического. " +
                "Пакетный манипулятор позволяет переносить большое количество предметов за раз. " +
                "Быстрый фильтрующиий и пакетный манипуляторы отличаются только наличием черного/белого списка для передаваемых предметов. " +
                "Из - за особенностей отображения в некоторых чертежах используются в качестве указателя типа входящего/выходящего ресурса.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Трубы позволяют транспортировать жидкости и пар, причем только одного типа, то есть одна труба = один вид жидкости или газа. " +
                "Скорость подачи зависит от разностей уровня вода в разных сегментах сети.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Железная дорога - эффективное транспортировочное средство. " +
                "Несмотря на ее громоздкость при сторительстве, она лучше по многим парметрам конвейеров и логистических сетей. " +
                "Также, грузовыу вагоны могут быть использованы в качестве буффера на производстве, т.к. к одному такому вагону можно подсоединить до 12 манипуляторов.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Логистическая сеть работает за счет дронстанций и на определенном расстоянии. " +
                "Например, площадь постройки 100х100 клеток, а площадь доставки 50х50 клеток. " +
                "Если в этих диапозонах расположить еще станцию, то их рабочаие зоны будут объединены. " +
                "Также дроны могут работать вне зоны станций, но только на близком расстоянии от игрока в модульной броне с персональной дронстанцией.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });
            return group.ToArray();
        }

        public static Label[] GetResourcesGroupTexts()
        {
            var group = new List<Label>();
            group.Add(new Label()
            {
                Text = "Камень может быть добыт из месторождений или валунов. " +
                "Используется для создания каменых печей, рельс, отсыпки территории. " +
                "При обработки в печи можно получить каменный блок.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Древесину можно добыть либо вручную, либо при помощи строительных дронов." +
                Environment.NewLine + "Она подходит в качестве дешевого топлива для всеx твердотопливных устройств." +
                Environment.NewLine + "Также используется в некоторых начальных рецептах рецептах.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Уголь- эффективное топливо в начале игры. Можно добывать вручную или при помощи бура." +
                "Подходит для питания: паровой шахты, парового манипулятора, бойлера, каменной и стальной плавильни а также транспорта.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Медь можно добывать вручную или с помощью бура." +
                "Нужна для выплавки медных пластин.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Железную руду можно добывать вручную или с помощью бура. " +
                "Обрабатывается во всех плавильнях. " +
                "Применяется для выплавки железных пластин или изготовления бетона. ",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Для добычи воды нужен насос. Используется В теплообменниках или бойлере, для создания электричества. " +
                "Участвует в процессе продвинутой обработки нефти.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Нефть добывается с помощью нефтяной вышки из месторождений. " +
                "Обрабатывается на нефтеперерабатывающем заводе. " +
                "Из нее можно получить нефтяной газ, диезльное топливо и мазут.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Для добычи урана потребуется подвести серную кислоту к электрическому буру. " +
                "Для последующей обработки руды потребуется центрифуга. " +
                "После получаем изотопы: уран - 235 и уран - 238, из которых можно создать топливо для ядерного реактора а также мощные боеприпасы." +
                "С развитием технологий открывается возможность обогащения урана для стабильного получения более редкого 235 изотопа.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Рыба не участвуют в производстве, но она может быстро восстановить немного здоровья. " +
                "Это не раз спасет вас во время нападений жуков на вас и во время ваших нападений на жуков в первые часы прохождения" +
                "Чтобы поймать рыбу, нужно подойти к ней поближе и зажать ПКМ.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });
            return group.ToArray();
        }

        public static Label[] GetResourcesGroupLables()
        {
            var group = new List<Label>();
            group.Add(new Label() { Text = "Камень", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Древесина", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Угольная руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Медная руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Железная руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Вода", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Нефть", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Урановая руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Рыба", Dock = DockStyle.Fill, ForeColor = Color.White, });
            return group.ToArray();
        }

        public static Label[] GetDefenceGroupTexts()
        {
            var group = new List<Label>();
            group.Add(new Label()
            {
                Text = "Кусаки- это местные жители планеты. Они могут быть 4 размеров. " +
                "В начале игры они маленькие, затем кусаки эволюционируют из-за загрязнений. " +
                "Их привлекают источники загрязнений, и они всегда стремятся их разрушить. Живут в ульях. " +
                "Также они опасны для игроков, тк наносят физический урон. " +
                "Помимо кусак существуют плеваки и черви, они атакуют на расстоянии едким раствором.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Огнестрельное оружие можно разделить на три вида:пистолеты, дробовики и огнемет. " +
                "Пистолеты имееют более высокую скорость стрельбы, а у дробовиков более высокий урон. " +
                "Огнемет отлично подходит для уничтожения больших групп врагов, нанося урон по площади.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Существуют три вида турелей: пулеметная, лазерная и огнеметная. " +
                "Пулементая - базовая турель, использует магазины с патронами. " +
                "Не требует энергии и может размещаться в любом месте. " +
                "Лазерная турель стреляет дальше, но требует электричество. " +
                "Огнеметная поджигает врагов и в качестве боеприпасов использует нефть,мазут или дизель.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Гранаты подходят для уничтожения ульев, тк наносят урон по площади. " +
                "Различают два вида гранат: обычные и кислотные. " +
                "Кислотные гранаты создают ядовитое облако,которое наносит урон всем в области действия." +
                "Игрок не будет получать урон,если находится в машине.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Есть два вида брони: обычная и модульная. " +
                "Обычная легкая броня понижает урон от слабых врагов, а тяжелая броня с установленными щитами сводит его на нет. " +
                "В модульную броню можно вставить модули, которые улучшают параметры игрока или открывают для него новые возможности. " +
                "Например,прибор ночного видения облегчает передвижение ночью или портативная дронстанция. " +
                "Модульная броня питается от солнечной панели или от портативного реактора." +
                "Более продвинутые экземпляры модульной брони имеют большую сетку для модулей, что позволяет использовать большее число модулей. " +
                "Также любая модульная броня увеличивает размер инвентаря.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            return group.ToArray();
        }

        public static Label[] GetDefenceGroupLabels()
        {
            var group = new List<Label>();

            group.Add(new Label() { Text = "Оборона", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Оружие", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Турели", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Гранаты", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Броня", Dock = DockStyle.Fill, ForeColor = Color.White, });

            return group.ToArray();
        }

        public static Label GetFirstStepsText()
        {
            var text = new Label()
            {
                Text = "Вы попали на планету. " +
                Environment.NewLine + "Сначала вам предстоит заняться ручным крафтом.Вам понадобятся уголь и камень. " +
                Environment.NewLine + "Найдите их месторождения и по правой кнопке мыши колотите, пока не будет нужного количества. " +
                Environment.NewLine + "Создайте твердотопливную печь. " +
                "Для ее создания отройте инвентарь по кнопке E. Печь сделает пластины и шестерни для твердотопливного бура. Он будет добывать ресурсы за вас. Ура, первая автоматизация готова. " +
                Environment.NewLine + "Далее приходят на помощь манипуляторы и конвейры: манипуляторы складывают руду на конвейер, он доставляет ее к печкам и манипуляторы их загружают. Готовый продукт храните в сундуках. ",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            };
            return text;
        }

        public static Label GetFirstStepsLabel()
        {
            return new Label() { Text = "Первые шаги", Dock = DockStyle.Fill, ForeColor = Color.White, };
        }

        public static Label GetElectricityText()
        {
            var text = new Label()
            {
                Text = "На одном угле вы долго не протянете - пора переходить к электричеству. Вам понадобится водоем. Сделайте и установите насос на берегу, он будет качать воду. " +
                Environment.NewLine + "Далее вам нужно проложить трубы.В зависимости от ресурсов и месторасположения, выбери надземную или подземную планировку.Трубы доставят воду к бойлерам.Они превращают воду в пар. " +
                "Бойлеру необходимо топливо, поэтому нужно наладить поставку угля. Следующий компонент в электрической сети - паровой двигатель. Он преобразует пар из бойлера в электричество. " +
                Environment.NewLine + "И наконец - опоры ЛЭП. Они доставляюи электричество к необходимым устройствам на вашей фабрике. Они бывают нескольких видов и различаются по площади покрытия и дальности соединения. " +
                Environment.NewLine +
                Environment.NewLine + "Вот и все, пора осваивать новые технологии.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            };
            return text;
        }

        public static Label GetElectricityLabel()
        {
            return new Label() { Text = "Электричество", Dock = DockStyle.Fill, ForeColor = Color.White, };
        }

        public static Label GetInitialScienceText()
        {
            var text = new Label()
            {
                Text = "Первое, что вам понадобится- лаборатория. Там проводятся ислледование новых технологий. " +
                "Скорость исследований напрямую зависит от количества лабораторий, поэтому в будущем вам понадобится далеко не одна. " +
                Environment.NewLine + "Начальный исследовательский пакет - это красыне колбочки, имеено они проложат путь к автоматизации вашего производства." +
                "C такими колбочками вы сможете изучить сборочный автомат." +
                Environment.NewLine + "Сборочный автомат может за вас создавать необоходимые предметы. " +
                "Например, в сборочном автомате вы можете производить конвейеры или красные колбочки. Наладьте производство красных колбочек,чтобы они автоматически поставлялись в лаборатории." +
                Environment.NewLine + "Следующий этап исследования - зеленые колбочки. Изучите их при помощи красных колбочек. " +
                "Для производства зеленых колбочек вам понадобятся манипуляторы и конвейры. Также наладльте их производство. Первая автоматизация готова!" +
                Environment.NewLine + "Таким образом, вы можете ислледовать новые технологии, чтобы улучшить ваше производство.",
                
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            };
            return text;
        }

        public static Label GetInitialScienceLabel()
        {
            return new Label() { Text = "Начальная наука", Dock = DockStyle.Fill, ForeColor = Color.White, };
        }

        public static Label[] GetTipsTexts()
        {
            var group = new List<Label>();

            group.Add(new Label()
            {
                Text = "Сохраняйте чертежи: например, железнодорожные модули или кластер буров. " +
                Environment.NewLine + "На панели быстрого доступа держите часто используемые предметы(конвееры, манипуляторы, опоры, чертежи, расходники)",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Не истребляйте кусак лишний раз, это провоцирует их развитие. " +
                Environment.NewLine + "При передвижении на машине не забывайте ее забирать, иначе потом придется долго до нее идти." +
                Environment.NewLine + "Не бойтесь логических сетей, с их помощью можно делать множество интересных вещей. Она также полезна для оптимизации производства.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            group.Add(new Label()
            {
                Text = "Стремитесь к автоматизации - на поздних этапах игры вы должны тратить время только на развитие, забудьте о ручном крафте. " +
                Environment.NewLine + "Не бойтесь экспрериментировать: порой даже самые странные идеи приводят к решению проблем.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            });

            return group.ToArray();
        }

        public static Label GetTipsLabel()
        {
            return new Label() { Text = "СОВЕТЫ", Dock = DockStyle.Fill, ForeColor = Color.White, };
        }

    }
}
