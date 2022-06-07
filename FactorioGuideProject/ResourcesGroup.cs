using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    class ResourcesGroup
    {
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
            group.Add(new Label() { Text = "Угольная руда",Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Медная руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Железная руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Вода", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Нефть", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Урановая руда", Dock = DockStyle.Fill, ForeColor = Color.White, });
            group.Add(new Label() { Text = "Рыба", Dock = DockStyle.Fill, ForeColor = Color.White, });
            return group.ToArray();
        }
    }
}
