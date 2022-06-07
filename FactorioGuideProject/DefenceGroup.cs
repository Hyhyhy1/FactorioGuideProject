﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    public class DefenceGroup
    {
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
    }
}
