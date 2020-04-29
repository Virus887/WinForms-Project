using System;
using System.Drawing;

namespace DamianBisWinFormsTask
{
    [Serializable()]
    public abstract class Element
    {
        protected string Name { get; }
        public bool selected;
        public Point position;
        public int alfa = 0;

        protected Element(string name)
        {
            Name = name;
            selected = false;
        }
        public Element() { }

        //https://docs.microsoft.com/pl-pl/dotnet/api/system.drawing.imaging.imageattributes?view=netframework-4.8
        public abstract void DrawImage(Graphics bitmap);
        public abstract bool IsPointInsideElementSet(Point point, ref Element e);
        public abstract bool IsPointInsideElement(Point point);
    }

}
