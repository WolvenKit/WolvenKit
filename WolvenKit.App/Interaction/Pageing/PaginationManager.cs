using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AlphaChiTech.Virtualization.Actions;
using AlphaChiTech.VirtualizingCollection;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Pageing
{
    public class PaginationManager<T> : IItemSourceProvider<T>, INotifyImmediately, IEditableProvider<T>,
        IEditableProviderIndexBased<T>, IEditableProviderItemBased<T>, IReclaimableService,
        IAsyncResetProvider, IProviderPreReset, INotifyCountChanged, INotifyCollectionChanged,
        ICollection where T : class
    {
        private readonly Dictionary<int, PageDelta> _deltas = new Dictionary<int, PageDelta>();
        private readonly Dictionary<int, ISourcePage<T>> _pages = new Dictionary<int, ISourcePage<T>>();
        private readonly IPageReclaimer<T> _reclaimer;

        private readonly Dictionary<int, CancellationTokenSource> _tasks =
            new Dictionary<int, CancellationTokenSource>();

        protected object PageLock = new object();
        private int _basePage;
        private bool _hasGotCount;

        private int _localCount;
        private int _pageSize = 100;


        /// <summary>
        ///     Initializes a new instance of the <see cref="PaginationManager{T}" /> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="reclaimer">The reclaimer.</param>
        /// <param name="expiryComparer">The expiry comparer.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="maxPages">The maximum pages.</param>
        /// <param name="maxDeltas">The maximum deltas.</param>
        /// <param name="maxDistance">The maximum distance.</param>
        /// <param name="sectionContext">The section context.</param>
        public PaginationManager(
            IPagedSourceProvider<T> provider,
            IPageReclaimer<T> reclaimer = null,
            IPageExpiryComparer expiryComparer = null,
            int pageSize = 100,
            int maxPages = 100,
            int maxDeltas = -1,
            int maxDistance = -1,
            string sectionContext = "")
        {
            this.PageSize = pageSize;
            this.MaxPages = maxPages;
            this.MaxDeltas = maxDeltas;
            this.MaxDistance = maxDistance;
            if (provider is IPagedSourceProviderAsync<T> async)
            {
                this.ProviderAsync = async;
            }
            else
            {
                this.Provider = provider;
            }

            this._reclaimer = reclaimer ?? new PageReclaimOnTouched<T>();

            this.ExpiryComparer = expiryComparer;

            VirtualizationManager.Instance.AddAction(new ReclaimPagesWA(this, sectionContext));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PaginationManager{T}" /> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="reclaimer">The reclaimer.</param>
        /// <param name="expiryComparer">The expiry comparer.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="maxPages">The maximum pages.</param>
        /// <param name="maxDeltas">The maximum deltas.</param>
        /// <param name="maxDistance">The maximum distance.</param>
        /// <param name="sectionContext">The section context.</param>
        public PaginationManager(
            IPagedSourceObservableProvider<T> provider,
            IPageReclaimer<T> reclaimer = null,
            IPageExpiryComparer expiryComparer = null,
            int pageSize = 100,
            int maxPages = 100,
            int maxDeltas = -1,
            int maxDistance = -1,
            string sectionContext = "") : this(provider as IPagedSourceProvider<T>, reclaimer, expiryComparer, pageSize,
            maxPages, maxDeltas, maxDistance, sectionContext)
        {
            provider.CollectionChanged += this.OnProviderCollectionChanged;
        }

        public IPageExpiryComparer ExpiryComparer { get; set; }

        /// <summary>
        ///     Gets or sets the maximum deltas.
        /// </summary>
        /// <value>
        ///     The maximum deltas.
        /// </value>
        public int MaxDeltas { get; set; } = -1;

        /// <summary>
        ///     Gets or sets the maximum distance.
        /// </summary>
        /// <value>
        ///     The maximum distance.
        /// </value>
        public int MaxDistance { get; set; } = -1;

        /// <summary>
        ///     Gets or sets the maximum pages.
        /// </summary>
        /// <value>
        ///     The maximum pages.
        /// </value>
        public int MaxPages { get; set; } = 100;

        /// <summary>
        ///     Gets or sets the size of the page.
        /// </summary>
        /// <value>
        ///     The size of the page.
        /// </value>
        public int PageSize
        {
            get => this._pageSize;
            set
            {
                this.DropAllDeltasAndPages();
                this._pageSize = value;
            }
        }

        /// <summary>
        ///     Gets or sets the provider.
        /// </summary>
        /// <value>
        ///     The provider.
        /// </value>
        public IPagedSourceProvider<T> Provider { get; set; }

        /// <summary>
        ///     Gets or sets the provider asynchronous.
        /// </summary>
        /// <value>
        ///     The provider asynchronous.
        /// </value>
        public IPagedSourceProviderAsync<T> ProviderAsync { get; set; }

        public int StepToJumpThreashold { get; set; } = 10;

        private int AddNotificationsCount { get; set; }

        private int LocalCount
        {
            get => this._localCount;
            set => this._localCount = value;
        }

        public async Task<int> GetCountAsync()
        {
            this._hasGotCount = true;
            if (!this.IsAsync)
            {
                return this.Provider.Count;
            }

            return await this.ProviderAsync.GetCountAsync();
        }


        /// <summary>
        ///     Resets the specified count.
        /// </summary>
        /// <param name="count">The count.</param>
        public void OnReset(int count)
        {
            this.CancelAllRequests();

            lock (this.PageLock)
            {
                this.DropAllDeltasAndPages();
            }

            if (count < 0)
            {
                this._hasGotCount = false;
            }
            else
            {
                //TODO <-lock (this.SyncRoot)
                lock (this.SyncRoot)
                {
                    this.LocalCount = count;
                    this._hasGotCount = true;
                }
            }

            if (!this.IsAsync)
            {
                this.Provider.OnReset(count);
            }
            else
            {
                this.ProviderAsync.OnReset(count);
            }

            if (count >= -1)
            {
                this.RaiseCountChanged(true, count);
            }
        }


        #region Implementation of IEnumerable

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        public bool Contains(T item)
        {
            // Attempt to get the item from the pages, else call  the provider to get it..
            lock (this.PageLock)
            {
                foreach (var p in this._pages)
                {
                    var o = p.Value.IndexOf(item);
                    if (o >= 0)
                    {
                        return true;
                    }
                }
            }

            return !this.IsAsync
                ? this.Provider.Contains(item)
                : this.ProviderAsync.ContainsAsync(item).GetAwaiter().GetResult();
        }

        public T GetAt(int index, object voc, bool usePlaceholder = true)
        {
            return this.GetAt(index, voc, usePlaceholder, 10);
        }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>
        ///     The count.
        /// </value>
        public int GetCount(bool asyncOk)
        {
            if (this._hasGotCount) return this.LocalCount;

            //TODO<-lock(this.SyncRoot)
            lock (this)
            {
                if (!this.IsAsync)
                {
                    this.LocalCount = this.Provider.Count;
                }
                else if (!asyncOk)
                {
                    this.LocalCount = this.ProviderAsync.GetCountAsync().GetAwaiter().GetResult();
                }
                else
                {
                    var cts = this.StartPageRequest(int.MinValue);
                    this.GetCountAsync(cts);
                }
            }

            this._hasGotCount = true;
            return this.LocalCount;
        }

        /// <summary>
        ///     Gets the Index of item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>the index of the item, or -1 if not found</returns>
        public int IndexOf(T item)
        {
            // Attempt to get the item from the pages, else call  the provider to get it..
            lock (this.PageLock)
            {
                foreach (var p in this._pages)
                {
                    var o = p.Value.IndexOf(item);
                    if (o >= 0)
                    {
                        return o + ((p.Key - this._basePage) * this.PageSize) + (from d in this._deltas.Values
                                   where d.Page < p.Key
                                   select d.Delta).Sum();
                    }
                }
            }

            return !this.IsAsync
                ? this.Provider.IndexOf(item)
                : this.ProviderAsync.IndexOfAsync(item).GetAwaiter().GetResult();

            //return this.ProviderAsync.IndexOf(item);
        }

        #region Implementation of INotifyCollectionChanged

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

        /// <summary>
        ///     Occurs when [count changed].
        /// </summary>
        public event OnCountChanged CountChanged;

        #region Implementation of INotifyImmediately

        public bool IsNotifyImmidiately
        {
            get => this.Provider is INotifyImmediately iNotifyImmediatelyProvider &&
                   iNotifyImmediatelyProvider.IsNotifyImmidiately;
            set
            {
                if (this.Provider is INotifyImmediately iNotifyImmediatelyProvider)
                {
                    iNotifyImmediatelyProvider.IsNotifyImmidiately = value;
                }
            }
        }

        #endregion


        public void OnBeforeReset()
        {
            if (!this.IsAsync)
            {
                (this.Provider as IProviderPreReset)?.OnBeforeReset();
            }
            else
            {
                (this.ProviderAsync as IProviderPreReset)?.OnBeforeReset();
            }
        }

        public void RunClaim(string sectionContext = "")
        {
            if (this._reclaimer == null) return;
            lock (this.PageLock)
            {
                var needed = Math.Max(0, this._pages.Count - this.MaxPages);
                if (needed == 0) return;
                var reclaimedPages = this._reclaimer.ReclaimPages(this._pages.Values, needed, sectionContext).ToList();

                foreach (var reclaimedPage in reclaimedPages)
                {
                    if (reclaimedPage.Page == this._basePage) continue;
                    lock (this._pages)
                    {
                        if (!this._pages.ContainsKey(reclaimedPage.Page)) continue;
                        this._pages.Remove(reclaimedPage.Page);
                        this._reclaimer.OnPageReleased(reclaimedPage);
                    }
                }
            }
        }

        /// <summary>
        ///     Adds the or update adjustment.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="offsetChange">The offset change.</param>
        public int AddOrUpdateAdjustment(int page, int offsetChange)
        {
            var ret = 0;

            lock (this.PageLock)
            {
                if (!this._deltas.ContainsKey(page))
                {
                    if (this.MaxDeltas == -1 || this._deltas.Count < this.MaxDeltas)
                    {
                        ret = offsetChange;
                        this._deltas.Add(page, new PageDelta {Page = page, Delta = offsetChange});
                    }
                    else
                    {
                        this.DropAllDeltasAndPages();
                    }
                }
                else
                {
                    var adjustment = this._deltas[page];
                    adjustment.Delta += offsetChange;

                    if (adjustment.Delta == 0)
                    {
                        this._deltas.Remove(page);
                    }

                    ret = adjustment.Delta;
                }
            }

            return ret;
        }

        /// <summary>
        ///     Gets at.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="voc">The voc.</param>
        /// <param name="usePlaceholder">if set to <c>true</c> [use placeholder].</param>
        /// <returns></returns>
        public T GetAt(int index, object voc, bool usePlaceholder = true, int nullTryCount = 10)
        {
            var ret = default(T);

            this.CalculateFromIndex(index, out var page, out var offset);

            var datapage = this.SafeGetPage(page, usePlaceholder, voc, index);

            if (datapage != null)
            {
                ret = datapage.GetAt(offset);
            }

            if (ret == null)
            {
                //return this.ProviderAsync.GetPlaceHolder(0, 0,0);
                //Debugger.Break();
                //TODO <-
                if (nullTryCount <= 0) //inconsistency, notify reset collection
                {
                    this.OnProviderCollectionChanged(this.Provider,
                        new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                    return ret;
                }

                Thread.Sleep(100);
                return this.GetAt(index, voc, usePlaceholder, --nullTryCount);
            }

            return ret;
        }


        protected void CalculateFromIndex(int index, out int page, out int inneroffset)
        {
            // First work out the base page from the index and the offset inside that page
            var basepage = page = (index / this.PageSize) + this._basePage;
            inneroffset = (index + (this._basePage * this.PageSize)) - (page * this.PageSize);

            // We only need to do the rest if there have been modifications to the page sizes on pages (deltas)
            if (this._deltas.Count <= 0) return;

            // Get the adjustment BEFORE checking for a short page, because we are going to adjust for that first..
            var adjustment = 0;

            lock (this.PageLock)
            {
                // First, get the total adjustments for any pages BEFORE the current page..
                adjustment = (from d in this._deltas.Values
                    where d.Page < basepage
                    select d.Delta).Sum();
            }

            // Now check to see if we are currently in a short page - in which case we need to adjust for that
            if (this._deltas.ContainsKey(page))
            {
                var delta = this._deltas[page].Delta;

                if (delta < 0)
                {
                    // In a short page, are we over the edge ?
                    if (inneroffset >= this.PageSize + delta)
                    {
                        var step = inneroffset - (this.PageSize + delta - 1);
                        inneroffset -= step;
                        this.DoStepForward(ref page, ref inneroffset, step);
                    }
                }
            }

            // If we do have adjustments...
            if (adjustment == 0) return;

            if (adjustment > 0)
            {
                // items have been added to earlier pages, so we need to step back
                this.DoStepBackwards(ref page, ref inneroffset, adjustment);
            }
            else
            {
                // items have been removed from earlier pages, so we need to step forward
                this.DoStepForward(ref page, ref inneroffset, Math.Abs(adjustment));
            }
        }

        protected void CancelAllRequests()
        {
            lock (this.PageLock)
            {
                var cancellationTokenSources = this._tasks.Values.ToList();
                foreach (var cancellationTokenSource in cancellationTokenSources)
                {
                    try
                    {
                        cancellationTokenSource.Cancel(false);
                    }
                    catch (Exception)
                    {
                        Debugger.Break();
                    }
                }

                this._tasks.Clear();
            }
        }


        protected void CancelPageRequest(int page)
        {
            lock (this.PageLock)
            {
                if (!this._tasks.ContainsKey(page))
                {
                    return;
                }

                try
                {
                    this._tasks[page].Cancel();
                }
                catch (Exception)
                {
                    Debugger.Break();
                }

                try
                {
                    this._tasks.Remove(page);
                }
                catch (Exception)
                {
                    Debugger.Break();
                }
            }
        }

        /// <summary>
        ///     Drops all deltas and pages.
        /// </summary>
        protected void DropAllDeltasAndPages()
        {
            lock (this.PageLock)
            {
                this._deltas.Clear();
                this._pages.Clear();
                this._basePage = 0;
                this.CancelAllRequests();
            }
        }


        /// <summary>
        ///     Gets the provider as editable.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException"></exception>
        protected IEditableProvider<T> GetProviderAsEditable()
        {
            if (this.Provider != null)
            {
                return this.Provider as IEditableProvider<T>;
            }

            return this.ProviderAsync as IEditableProvider<T>;
        }


        /// <summary>
        ///     Raises the count changed.
        /// </summary>
        /// <param name="count">The count.</param>
        protected void RaiseCountChanged(bool needsReset, int count)
        {
            //TODO<-this._hasGotCount = false;
            var evnt = this.CountChanged;
            evnt?.Invoke(this, new CountChangedEventArgs
            {
                NeedsReset = needsReset,
                Count = count
            });
        }

        protected void RemovePageRequest(int page)
        {
            lock (this.PageLock)
            {
                if (!this._tasks.ContainsKey(page)) return;
                try
                {
                    this._tasks.Remove(page);
                }
                catch (Exception)
                {
                    Debugger.Break();
                }
            }
        }

        protected CancellationTokenSource StartPageRequest(int page)
        {
            var cts = new CancellationTokenSource();

            this.CancelPageRequest(page);

            lock (this.PageLock)
            {
                if (!this._tasks.ContainsKey(page))
                {
                    this._tasks.Add(page, cts);
                }
                else
                {
                    this._tasks[page] = cts;
                }
            }

            return cts;
        }


        private void DoStepBackwards(ref int page, ref int offset, int stepAmount)
        {
            var done = false;
            var ignoreSteps = -1;
            //TODO <-lock (this.PageLock)
            //{
            while (!done)
            {
                if (stepAmount > this.PageSize * this.StepToJumpThreashold && ignoreSteps <= 0)
                {
                    var targetPage = page - stepAmount / this.PageSize;
                    var sourcePage = page;
                    var adj = (from a in this._deltas.Values
                        where a.Page >= targetPage && a.Page <= sourcePage
                        orderby a.Page
                        select a).ToArray();
                    if (!adj.Any())
                    {
                        page = targetPage;
                        stepAmount -= (sourcePage - targetPage) * this.PageSize;

                        if (stepAmount == 0)
                        {
                            done = true;
                        }
                    }
                    else if (adj.Last().Page < page - 2)
                    {
                        targetPage = adj.Last().Page + 1;
                        page = targetPage;
                        stepAmount -= (sourcePage - targetPage) * this.PageSize;

                        if (stepAmount == 0)
                        {
                            done = true;
                        }
                    }
                    else
                    {
                        ignoreSteps = sourcePage - adj.Last().Page;
                    }
                }

                if (done) continue;

                if (offset - stepAmount < 0)
                {
                    stepAmount -= (offset + 1);
                    page--;
                    var items = this.PageSize;
                    if (this._deltas.ContainsKey(page))
                    {
                        items += this._deltas[page].Delta;
                    }

                    offset = items - 1;
                }
                else
                {
                    offset -= stepAmount;
                    done = true;
                }

                ignoreSteps--;
            }

            // }
        }

        private void DoStepForward(ref int page, ref int offset, int stepAmount)
        {
            var done = false;
            var ignoreSteps = -1;
            //TODO <-lock (this.PageLock)
            //{
            while (!done)
            {
                if (stepAmount > this.PageSize * this.StepToJumpThreashold && ignoreSteps <= 0)
                {
                    var targetPage = page + stepAmount / this.PageSize;
                    var sourcePage = page;
                    var adj = (from a in this._deltas.Values
                        where a.Page <= targetPage && a.Page >= sourcePage
                        orderby a.Page
                        select a).ToArray();
                    if (!adj.Any())
                    {
                        page = targetPage;
                        stepAmount -= (targetPage - sourcePage) * this.PageSize;

                        if (stepAmount == 0)
                        {
                            done = true;
                        }
                    }
                    else if (adj.Last().Page > page - 2)
                    {
                        targetPage = adj.Last().Page - 1;
                        page = targetPage;
                        stepAmount -= (targetPage - sourcePage) * this.PageSize;

                        if (stepAmount == 0)
                        {
                            done = true;
                        }
                    }
                    else
                    {
                        ignoreSteps = adj.Last().Page - sourcePage;
                    }
                }

                if (done) continue;

                var items = this.PageSize;
                if (this._deltas.ContainsKey(page))
                {
                    items += this._deltas[page].Delta;
                }

                if (items <= offset + stepAmount)
                {
                    stepAmount -= (items) - offset;
                    offset = 0;
                    page++;
                }
                else
                {
                    offset += stepAmount;
                    done = true;
                }

                ignoreSteps--;
            }

            //}
        }

        /// <summary>
        ///     Fills the page.
        /// </summary>
        /// <param name="newPage">The new page.</param>
        /// <param name="pageOffset">The page offset.</param>
        private void FillPage(ISourcePage<T> newPage, int pageOffset)
        {
            var data = this.Provider.GetItemsAt(pageOffset, newPage.ItemsPerPage, false);
            newPage.WiredDateTime = data.LoadedAt;
            foreach (var o in data.Items)
            {
                newPage.Append(o, null, this.ExpiryComparer);
            }

            newPage.PageFetchState = PageFetchStateEnum.Fetched;
        }

        /// <summary>
        ///     Fills the page from asynchronous provider.
        /// </summary>
        /// <param name="newPage">The new page.</param>
        /// <param name="pageOffset">The page offset.</param>
        private void FillPageFromAsyncProvider(ISourcePage<T> newPage, int pageOffset)
        {
            var data = this.ProviderAsync.GetItemsAt(pageOffset, newPage.ItemsPerPage, false);
            newPage.WiredDateTime = data.LoadedAt;
            foreach (var o in data.Items)
            {
                newPage.Append(o, null, this.ExpiryComparer);
            }

            newPage.PageFetchState = PageFetchStateEnum.Fetched;
        }

        private async void GetCountAsync(CancellationTokenSource cts)
        {
            if (!cts.IsCancellationRequested)
            {
                var ret = await this.ProviderAsync.GetCountAsync();

                if (!cts.IsCancellationRequested)
                {
                    //TODO<-lock (this.SyncRoot)
                    lock (this)
                    {
                        this._hasGotCount = true;
                        this.LocalCount = ret;
                    }
                }

                if (!cts.IsCancellationRequested)
                {
                    this.RaiseCountChanged(true, this.LocalCount);
                }
            }

            this.RemovePageRequest(int.MinValue);
        }


        private void OnProviderCollectionChanged(object sender,
            NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
            //lock(this._addLock)
            //{
            switch (notifyCollectionChangedEventArgs.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (var item in notifyCollectionChangedEventArgs.NewItems)
                    {
                        if (!(item is T newItem)) continue;

                        this.AddNotificationsCount++;
                        this.OnAppend(newItem, DateTime.Now, true, true);
                    }

                    this.CollectionChanged?.Invoke(sender,
                        notifyCollectionChangedEventArgs); // check if this.OnAppend does not raise collection change as well
                    //this.RaiseCountChanged(true, this._localCount);
                    break;
                case NotifyCollectionChangedAction.Reset:
                case NotifyCollectionChangedAction.Remove: //TODO
                    lock (this.PageLock)
                    {
                        this._hasGotCount = false;
                        this.CancelAllRequests();
                        this.DropAllDeltasAndPages();
                    }

                    this.CollectionChanged?.Invoke(sender, notifyCollectionChangedEventArgs);
                    break;

                case NotifyCollectionChangedAction.Replace: //TODO
                case NotifyCollectionChangedAction.Move: //TODO
                default:
                    break;
            }

            //}
        }


        #region IEditableProvider<T> Implementation

        /// <summary>
        ///     Called when [append].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="isAlreadyInSourceCollection"></param>
        /// <param name="createPageIfNotExist"></param>
        /// <returns></returns>
        public int OnAppend(T item, object timestamp, bool isAlreadyInSourceCollection = false,
            bool createPageIfNotExist = false)
        {
            var index = this.LocalCount;

            if (!this._hasGotCount)
            {
                lock (this.SyncRoot)
                {
                    this.EnsureCount();
                    if (isAlreadyInSourceCollection)
                    {
                        Interlocked.Decrement(ref this._localCount);
                    }
                }
            }

            this.CalculateFromIndex(index, out var page, out _);

            if (this.IsPageWired(page))
            {
                var shortpage = false;
                var dataPage = this.SafeGetPage(page, false, null, index);
                if (dataPage.ItemsPerPage < this.PageSize)
                {
                    shortpage = true;
                }

                dataPage.Append(item, timestamp, this.ExpiryComparer);

                if (shortpage)
                {
                    dataPage.ItemsPerPage++;
                }
                else
                {
                    this.AddOrUpdateAdjustment(page, 1);
                }
            }
            else if (createPageIfNotExist)
            {
                var dataPage = this.CreateNewPage(page, out _, out _);
                dataPage.Append(item, timestamp, this.ExpiryComparer);
            }

            Interlocked.Increment(ref this._localCount);

            if (this.IsAsync)
            {
                var test = this.GetAt(index, this, false);
            }

            var edit = this.GetProviderAsEditable();
            if (edit != null && !isAlreadyInSourceCollection)
            {
                //==>edit.OnInsert(index, item, timestamp);
                //TODO<-edit.OnAppend(item, timestamp);
                edit.OnAppend(item, timestamp);
            }
            else if (!isAlreadyInSourceCollection)
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index);
                this.CollectionChanged?.Invoke(this, args);
            }

            return index;
        }

        /// <summary>
        ///     Gets the page, if use placeholders is false - then gets page sync else async.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="allowPlaceholders">if set to <c>true</c> [allow placeholders].</param>
        /// <param name="voc">The voc.</param>
        /// <param name="index">The index that this page refers to (effectively the pageoffset.</param>
        /// <returns></returns>
        protected ISourcePage<T> SafeGetPage(int page, bool allowPlaceholders, object voc, int index)
        {
            ISourcePage<T> ret = null;

            lock (this.PageLock)
            {
                if (this._pages.ContainsKey(page))
                {
                    ret = this._pages[page];
                    this._reclaimer.OnPageTouched(ret);
                }
                else
                {
                    var newPage = this.CreateNewPage(page, out var pageSize, out var pageOffset);

                    if (!this.IsAsync)
                    {
                        this.FillPage(newPage, pageOffset);

                        ret = newPage;
                    }
                    else
                    {
                        if (allowPlaceholders && voc != null)
                        {
                            // Fill with placeholders
                            for (var loop = 0; loop < pageSize; loop++)
                            {
                                var placeHolder = this.ProviderAsync.GetPlaceHolder(newPage.Page * pageSize + loop,
                                    newPage.Page, loop);
                                newPage.Append(placeHolder, null, this.ExpiryComparer);
                            }

                            ret = newPage;

                            var cts = this.StartPageRequest(newPage.Page);
                            Task.Run(() => this.DoRealPageGet(voc, newPage, pageOffset, index, cts), cts.Token)
                                .ConfigureAwait(false);
                        }
                        else
                        {
                            this.FillPageFromAsyncProvider(newPage, pageOffset);
                            ret = newPage;
                        }
                    }
                }
            }

            return ret;
        }

        private ISourcePage<T> CreateNewPage(int page, out int pageSize, out int pageOffset)
        {
            PageDelta delta = null;
            if (this._deltas.ContainsKey(page))
            {
                delta = this._deltas[page];
            }

            pageOffset = (page - this._basePage) * this.PageSize + (from d in this._deltas.Values
                             where d.Page < page
                             select d.Delta).Sum();
            pageSize = Math.Min(this.PageSize, this.GetCount(false) - pageOffset);
            if (delta != null)
            {
                pageSize += delta.Delta;
            }

            var newPage = this._reclaimer.MakePage(page, pageSize);
            this._pages.Add(page, newPage);
            return newPage;
        }

        private async Task DoRealPageGet(object voc, ISourcePage<T> page, int pageOffset, int index,
            CancellationTokenSource cts)
        {
            var realVoc = (VirtualizingObservableCollection<T>) voc;
            var listOfReplaces = new List<PlaceholderReplaceWA<T>>();

            if (realVoc != null)
            {
                if (cts.IsCancellationRequested)
                {
                    return;
                }

                var data = await this.ProviderAsync.GetItemsAtAsync(pageOffset, page.ItemsPerPage, false);

                if (cts.IsCancellationRequested)
                {
                    return;
                }

                page.WiredDateTime = data.LoadedAt;

                var i = 0;
                foreach (var item in data.Items)
                {
                    if (cts.IsCancellationRequested)
                    {
                        this.RemovePageRequest(page.Page);
                        return;
                    }

                    if (page.ReplaceNeeded(i))
                    {
                        var oldItem = page.ReplaceAt(i, item, null, null);
                        listOfReplaces.Add(new PlaceholderReplaceWA<T>(realVoc, oldItem, item, pageOffset + i));
                    }
                    else
                    {
                        page.ReplaceAt(i, item, null, null);
                    }

                    i++;
                }
            }

            page.PageFetchState = PageFetchStateEnum.Fetched;

            foreach (var replace in listOfReplaces)
            {
                if (cts.IsCancellationRequested)
                {
                    this.RemovePageRequest(page.Page);
                    return;
                }

                VirtualizationManager.Instance.RunOnUi(replace);
            }

            this.RemovePageRequest(page.Page);
        }

        protected bool IsPageWired(int page)
        {
            var wired = false;

            lock (this.PageLock)
            {
                if (this._pages.ContainsKey(page))
                {
                    wired = true;
                }
            }

            return wired;
        }

        public int OnAppend(T item, object timestamp) => this.OnAppend(item, timestamp, false, false);

        public void OnInsert(int index, T item, object timestamp)
        {
            if (!this._hasGotCount)
            {
                this.EnsureCount();
            }

            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                dataPage.InsertAt(offset, item, timestamp, this.ExpiryComparer);
            }

            var adj = this.AddOrUpdateAdjustment(page, 1);

            if (page == this._basePage && adj == this.PageSize * 2)
            {
                lock (this.PageLock)
                {
                    if (this.IsPageWired(page))
                    {
                        var dataPage = this.SafeGetPage(page, false, null, index);
                        ISourcePage<T> newdataPage = null;
                        if (this.IsPageWired(page - 1))
                        {
                            newdataPage = this.SafeGetPage(page - 1, false, null, index);
                        }
                        else
                        {
                            newdataPage = this._reclaimer.MakePage(page - 1, this.PageSize);
                            this._pages.Add(page - 1, newdataPage);
                        }

                        for (var loop = 0; loop < this.PageSize; loop++)
                        {
                            var i = dataPage.GetAt(0);

                            dataPage.RemoveAt(0, null, null);
                            newdataPage.Append(i, null, null);
                        }
                    }

                    this.AddOrUpdateAdjustment(page, -this.PageSize);

                    this._basePage--;
                }
            }

            if (this.IsAsync)
            {
                var test = this.GetAt(index, this, false);
            }

            var edit = this.GetProviderAsEditable();
            if (edit != null)
            {
                edit.OnInsert(index, item, timestamp);
            }
            else
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index);
                this.CollectionChanged?.Invoke(this, args);
            }

            Interlocked.Increment(ref this._localCount);
        }

        public void OnReplace(int index, T oldItem, T newItem, object timestamp)
        {
            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                dataPage.ReplaceAt(offset, newItem, timestamp, this.ExpiryComparer);
            }
            else
            {
                oldItem = this.Provider.GetItemsAt(index, 1, false).Items.FirstOrDefault();
                if (oldItem != default(T)) Debugger.Break();
            }

            if (this.Provider is IEditableProvider<T> editableProvider)
            {
                editableProvider.OnReplace(index, oldItem, newItem, timestamp);
            }
            else
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem,
                    index);
                this.CollectionChanged?.Invoke(this, args);
            }
        }

        private void EnsureCount()
        {
            this.GetCount(false);
        }

        protected bool IsAsync => this.ProviderAsync != null ? true : false;

        #endregion IEditableProvider<T> Implementation

        #region Implementation of ICollection

        /// <inheritdoc />
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

        /// <inheritdoc />
        /// <summary>
        ///     Gets the number of elements contained in the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        /// <returns>
        ///     The number of elements contained in the <see cref="T:System.Collections.ICollection" />.
        /// </returns>
        public int Count => this.GetCount(false);

        /// <inheritdoc cref="" />
        /// <summary>
        ///     Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        /// <returns>
        ///     An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </returns>
        public object SyncRoot => this.Provider?.SyncRoot ?? this.ProviderAsync.SyncRoot;
        //public object SyncRoot => this.PageLock ?? this.ProviderAsync.SyncRoot;

        /// <summary>
        ///     Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized
        ///     (thread safe).
        /// </summary>
        /// <returns>
        ///     true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise,
        ///     false.
        /// </returns>
        public bool IsSynchronized => this.Provider.IsSynchronized;

        #endregion

        #region Implementation of IEditableProviderIndexBased<in T>

        public T OnRemove(int index, object timestamp)
        {
            T item;

            if (!this._hasGotCount)
            {
                this.EnsureCount();
            }

            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                dataPage.RemoveAt(offset, timestamp, this.ExpiryComparer);
            }

            this.AddOrUpdateAdjustment(page, -1);

            if (page == this._basePage)
            {
                var items = this.PageSize;
                if (this._deltas.ContainsKey(page))
                {
                    items += this._deltas[page].Delta;
                }

                if (items == 0)
                {
                    this._deltas.Remove(page);
                    this._basePage++;
                }
            }

            if (this.IsAsync)
            {
                var test = this.GetAt(index, this, false);
            }

            if (this.Provider is IEditableProviderIndexBased<T> editableProvider)
            {
                item = editableProvider.OnRemove(index, timestamp);
            }
            else
            {
                item = this.GetAt(index, this.Provider, false);
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index);
                this.CollectionChanged?.Invoke(this, args);
            }

            Interlocked.Decrement(ref this._localCount);

            return item;
        }

        public T OnReplace(int index, T newItem, object timestamp)
        {
            T oldItem;

            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                oldItem = dataPage.ReplaceAt(offset, newItem, timestamp, this.ExpiryComparer);
            }
            else
            {
                oldItem = this.Provider.GetItemsAt(index, 1, false).Items.FirstOrDefault();
                if (oldItem != default(T)) Debugger.Break();
            }

            if (this.Provider is IEditableProviderIndexBased<T> editableProvider)
            {
                editableProvider.OnReplace(index, newItem, timestamp);
            }
            else
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem,
                    index);
                this.CollectionChanged?.Invoke(this, args);
            }

            return oldItem;
        }

        #endregion

        #region Implementation of IEditableProviderItemBased<in T>

        public int OnRemove(T item, object timestamp)
        {
            if (!this._hasGotCount)
            {
                this.EnsureCount();
            }

            var index = this.Provider.IndexOf(item);
            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                dataPage.RemoveAt(offset, timestamp, this.ExpiryComparer);
            }

            this.AddOrUpdateAdjustment(page, -1);

            if (page == this._basePage)
            {
                var items = this.PageSize;
                if (this._deltas.ContainsKey(page))
                {
                    items += this._deltas[page].Delta;
                }

                if (items == 0)
                {
                    this._deltas.Remove(page);
                    this._basePage++;
                }
            }

            if (this.IsAsync)
            {
                var test = this.GetAt(index, this, false);
            }

            if (this.Provider is IEditableProviderItemBased<T> editableProvider)
            {
                editableProvider.OnRemove(item, timestamp);
            }
            else
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index);
                this.CollectionChanged?.Invoke(this, args);
            }

            Interlocked.Decrement(ref this._localCount);

            return index;
        }

        public int OnReplace(T oldItem, T newItem, object timestamp)
        {
            var index = this.Provider.IndexOf(oldItem);

            this.CalculateFromIndex(index, out var page, out var offset);

            if (this.IsPageWired(page))
            {
                var dataPage = this.SafeGetPage(page, false, null, index);
                dataPage.ReplaceAt(offset, newItem, timestamp, this.ExpiryComparer);
            }


            if (this.Provider is IEditableProviderItemBased<T> editableProvider)
            {
                editableProvider.OnReplace(oldItem, newItem, timestamp);
            }
            else
            {
                var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem,
                    index);
                this.CollectionChanged?.Invoke(this, args);
            }

            return index;
        }

        #endregion
    }
}
