using System;
using System.Collections.Generic;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Pageing
{
    public class SourcePage<T> : ISourcePage<T>
    {
        private readonly List<int> _replaceNeededList = new List<int>();
        protected List<T> Items = new List<T>();

        /// <summary>
        ///     Appends the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="updatedAt"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public int Append(T item, object updatedAt, IPageExpiryComparer comparer)
        {
            this.Items.Add(item);

            this.LastTouch = DateTime.Now;

            return this.Items.IndexOf(item);
            //TODO<-return this.Items.Count;
        }

        /// <summary>
        ///     Gets a value indicating whether [can reclaim page].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [can reclaim page]; otherwise, <c>false</c>.
        /// </value>
        public bool CanReclaimPage => this.PageFetchState != PageFetchStateEnum.Placeholders;

        /// <summary>
        ///     Gets at.
        /// </summary>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        public T GetAt(int offset)
        {
            var ret = default(T);

            if (this.PageFetchState == PageFetchStateEnum.Placeholders) this._replaceNeededList.Add(offset);

            if (this.Items.Count > offset) ret = this.Items[offset];

            this.LastTouch = DateTime.Now;

            return ret;
        }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            this.LastTouch = DateTime.Now;

            return this.Items.IndexOf(item);
        }

        /// <summary>
        ///     Inserts at.
        /// </summary>
        /// <param name="offset">The offset.</param>
        /// <param name="item">The item.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="comparer"></param>
        public void InsertAt(int offset, T item, object updatedAt, IPageExpiryComparer comparer)
        {
            if (!this.IsSafeToUpdate(comparer, updatedAt)) return;

            if (this.Items.Count > offset)
            {
                this.Items.Insert(offset, item);
            }
            else
            {
                this.Items.Add(item);
            }
        }

        public int ItemsCount => this.Items.Count;

        /// <summary>
        ///     Gets or sets the items per page.
        /// </summary>
        /// <value>
        ///     The items per page.
        /// </value>
        public int ItemsPerPage { get; set; }

        /// <summary>
        ///     Gets or sets the last touch.
        /// </summary>
        /// <value>
        ///     The last touch.
        /// </value>
        public object LastTouch { get; set; }


        /// <summary>
        ///     Gets or sets the page.
        /// </summary>
        /// <value>
        ///     The page.
        /// </value>
        public int Page { get; set; }

        /// <summary>
        ///     Gets or sets the state of the page fetch state.
        /// </summary>
        /// <value>
        ///     The state of the page fetch.
        /// </value>
        public PageFetchStateEnum PageFetchState { get; set; } = PageFetchStateEnum.Placeholders;

        public List<SourcePagePendingUpdates> PendingUpdates { get; } = new List<SourcePagePendingUpdates>();

        /// <summary>
        ///     Removes at.
        /// </summary>
        /// <param name="offset">The offset.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public bool RemoveAt(int offset, object updatedAt, IPageExpiryComparer comparer)
        {
            if (this.IsSafeToUpdate(comparer, updatedAt))
            {
                this.Items.RemoveAt(offset);
            }

            return true;
        }


        /// <summary>
        ///     Replaces at.
        /// </summary>
        /// <param name="offset">The offset.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="comparer"></param>
        public T ReplaceAt(int offset, T newValue, object updatedAt, IPageExpiryComparer comparer)
        {
            var oldValue = this.Items[offset];
            if (!this.IsSafeToUpdate(comparer, updatedAt))
            {
                if (this.Items.Count > offset) this.Items[offset] = newValue;
                return oldValue;
            }

            this.Items[offset] = newValue;
            return oldValue;
        }

        /// <summary>
        ///     Replaces at.
        /// </summary>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="comparer"></param>
        public T ReplaceAt(T oldValue, T newValue, object updatedAt, IPageExpiryComparer comparer)
        {
            if (!this.IsSafeToUpdate(comparer, updatedAt))
            {
                return oldValue;
            }

            var offset = this.Items.IndexOf(oldValue);
            this.Items[offset] = newValue;
            return oldValue;
        }

        public bool ReplaceNeeded(int offset)
        {
            return this._replaceNeededList.Contains(offset);
        }

        /// <summary>
        ///     Gets or sets the wired date time.
        /// </summary>
        /// <value>
        ///     The wired date time.
        /// </value>
        public object WiredDateTime { get; set; } = DateTime.MinValue;

        /// <summary>
        ///     Determines whether it is safe to update into a page where the pending update was generated at a given time.
        /// </summary>
        /// <param name="comparer"></param>
        /// <param name="updatedAt">The updated happened at this datetime.</param>
        /// <returns></returns>
        public bool IsSafeToUpdate(IPageExpiryComparer comparer, object updatedAt)
        {
            return comparer == null || comparer.IsUpdateValid(this.WiredDateTime, updatedAt);
        }
    }
}