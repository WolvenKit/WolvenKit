using System;

namespace AlphaChiTech.Virtualization.Pageing
{
    internal class PageDelta
    {
        private int _page;

        public int Delta { get; set; }

        public int Page
        {
            get => this._page;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        $"Page number value for PageDelta must be >= 0, but {value} was provided.");
                this._page = value;
            }
        }
    }
}