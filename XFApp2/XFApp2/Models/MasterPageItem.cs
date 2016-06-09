using System;

namespace XFApp2.Views
{
    public class MasterPageItem
    {
        public string Title { get; internal set; }
        public Type TargetType { get; internal set; }

        public MasterPageItem() { }

        public MasterPageItem(string title, Type targetType)
        {
            Title = title;
            TargetType = targetType;
        }
    }
}