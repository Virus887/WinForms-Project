using System;
using System.ComponentModel;


namespace DamianBisWinFormsTask
{
    //This class help us to cope with serialization
    [Serializable()]
    public class AllDataToSave
    {
            public BindingList<Element> projectElements;
            public int MaxHeight;
            public int MaxWidth;

            public AllDataToSave(BindingList<Element> projectElements, int maxHeight, int maxWidth)
            {
                this.projectElements = projectElements;
                MaxHeight = maxHeight;
                MaxWidth = maxWidth;
            }
    }
}

