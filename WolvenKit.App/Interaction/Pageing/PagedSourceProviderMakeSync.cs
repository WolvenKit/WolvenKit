using System;
using System.Threading.Tasks;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Pageing
{
    public class PagedSourceProviderMakeSync<T> : IPagedSourceProviderAsync<T>, IProviderPreReset
    {
        public PagedSourceProviderMakeSync()
        {
        }

        public PagedSourceProviderMakeSync(
            Func<int, int, Task<PagedSourceItemsPacket<T>>> funcGetItemsAtAsync = null,
            Func<Task<int>> funcGetCountAsync = null,
            Func<T, int> funcIndexOf = null,
            Func<T, Task<int>> funcIndexOfAsync = null,
            Func<T, bool> funcContains = null,
            Func<T, Task<bool>> funcContainsAsync = null,
            Action<int> actionOnReset = null,
            Func<int, int, int, T> funcGetPlaceHolder = null,
            Action actionOnBeforeReset = null
        )
        {
            this.FuncGetItemsAtAsync = funcGetItemsAtAsync;
            this.FuncGetCountAsync = funcGetCountAsync;
            this.FuncIndexOf = funcIndexOf;
            this.FuncIndexOfAsync = funcIndexOfAsync;
            this.FuncContains = funcContains;
            this.FuncContainsAsync = funcContainsAsync;
            this.ActionOnReset = actionOnReset;
            this.FuncGetPlaceHolder = funcGetPlaceHolder;
            this.ActionOnBeforeReset = actionOnBeforeReset;
        }

        public Action ActionOnBeforeReset { get; set; }

        public Action<int> ActionOnReset { get; set; }
        public Func<T, bool> FuncContains { get; set; }
        public Func<T, Task<bool>> FuncContainsAsync { get; set; }

        public Func<Task<int>> FuncGetCountAsync { get; set; }

        public Func<int, int, Task<PagedSourceItemsPacket<T>>> FuncGetItemsAtAsync { get; set; }

        public Func<int, int, int, T> FuncGetPlaceHolder { get; set; }

        public Func<T, int> FuncIndexOf { get; set; }

        public Func<T, Task<int>> FuncIndexOfAsync { get; set; }

        public virtual void OnReset(int count)
        {
            this.ActionOnReset?.Invoke(count);
        }

        public bool Contains(T item)
        {
            var ret = false;

            if (this.FuncContains != null)
            {
                ret = this.FuncContains.Invoke(item);
            }
            else if (this.FuncContainsAsync != null)
            {
                ret = Task.Run(() => this.FuncContainsAsync.Invoke(item)).GetAwaiter().GetResult();
            }
            else
            {
                ret = Task.Run(() => this.FuncContainsAsync(item)).GetAwaiter().GetResult();
            }

            return ret;
        }

        public int Count => Task.Run(this.GetCountAsync).GetAwaiter().GetResult();

        public PagedSourceItemsPacket<T> GetItemsAt(int pageoffset, int count, bool usePlaceholder)
        {
            return Task.Run(() => this.GetItemsAtAsync(pageoffset, count, usePlaceholder)).GetAwaiter().GetResult();
        }

        public virtual int IndexOf(T item)
        {
            if (this.FuncIndexOf != null)
            {
                return this.FuncIndexOf.Invoke(item);
            }

            if (this.FuncIndexOfAsync != null)
            {
                return Task.Run(() => this.FuncIndexOfAsync.Invoke(item)).GetAwaiter().GetResult();
            }

            return Task.Run(() => this.IndexOfAsync(item)).GetAwaiter().GetResult();
        }

        public Task<bool> ContainsAsync(T item)
        {
            return this.FuncContainsAsync?.Invoke(item);
        }

        public virtual Task<int> GetCountAsync()
        {
            return this.FuncGetCountAsync?.Invoke();
        }

        public virtual Task<PagedSourceItemsPacket<T>> GetItemsAtAsync(int pageoffset, int count, bool usePlaceholder)
        {
            return this.FuncGetItemsAtAsync?.Invoke(pageoffset, count);
        }

        public virtual T GetPlaceHolder(int index, int page, int offset)
        {
            return this.FuncGetPlaceHolder != null ? this.FuncGetPlaceHolder.Invoke(index, page, offset) : default(T);
        }

        public virtual async Task<int> IndexOfAsync(T item)
        {
            return await Task.FromResult(-1);
        }

        public virtual void OnBeforeReset()
        {
            this.ActionOnBeforeReset?.Invoke();
        }

        /// <summary>
        ///     Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized
        ///     (thread safe).
        /// </summary>
        /// <returns>
        ///     true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise,
        ///     false.
        /// </returns>
        public bool IsSynchronized { get; } = false;

        /// <summary>
        ///     Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        /// <returns>
        ///     An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </returns>
        public object SyncRoot => this;

        /// <summary>
        ///     Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />,
        ///     starting at a particular <see cref="T:System.Array" /> index.
        /// </summary>
        /// <param name="array">
        ///     The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied
        ///     from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based
        ///     indexing.
        /// </param>
        /// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero. </exception>
        /// <exception cref="T:System.ArgumentException">
        ///     <paramref name="array" /> is multidimensional.-or- The number of elements
        ///     in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from
        ///     <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source
        ///     <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination
        ///     <paramref name="array" />.
        /// </exception>
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}