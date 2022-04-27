using System.Windows.Forms;
using static FactorioGuideProject.Scheme;

namespace FactorioGuideProject
{
    public static class GroupConstructor
    {
        public static DoubleSideLinkedList<TableLayoutPanel> CreateGroupMapCreation
            ( Label label, TextBox[] text, Button nextSlide, Button prevSlide)
        {
            var group = new DoubleSideLinkedList<TableLayoutPanel>();
            group.Add(GetPageWithNextButton(label, text[0], nextSlide));
                for (int i = 1; i < text.Length-1; i++)
                {
                    group.Add(GetPageWithTwoButtons(label, text[i], nextSlide, prevSlide));
                }
            group.Add(GetPageWithPrevButton(label,text[text.Length-1],prevSlide));
            return group;
        }
    }
}
