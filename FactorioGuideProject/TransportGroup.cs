﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    public class TransportGroup
    {
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
    }
}