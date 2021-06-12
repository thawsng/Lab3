using System;

namespace Lab3
{
    public class listbox: Window
    {
        public listbox(int top, int left, string contents) : base(top, left)
        {
            listboxContents = contents;
        }

        public override void DrawWidow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}", listboxContents);
        }
        private string listboxContents;
    }
}