using System;
using System.Collections.Generic;
using System.Linq;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Pageing
{
    /// <summary>
    ///     PageReclainOnTouched is a Page Reclaimer implementation that releases pages based on when
    ///     they where last touched.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageReclaimOnTouched<T> : IPageReclaimer<T>
    {
        /// <inheritdoc />
        /// <summary>
        ///     Makes the page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public ISourcePage<T> MakePage(int page, int size)
        {
            return new SourcePage<T> {Page = page, ItemsPerPage = size};
        }

        /// <inheritdoc />
        /// <summary>
        ///     Called when [page released].
        /// </summary>
        /// <param name="page">The page.</param>
        public void OnPageReleased(ISourcePage<T> page)
        {
        }

        /// <inheritdoc />
        /// <summary>
        ///     Called when [page touched].
        /// </summary>
        /// <param name="page">The page.</param>
        public void OnPageTouched(ISourcePage<T> page)
        {
            page.LastTouch = DateTime.Now;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Reclaims the pages.
        /// </summary>
        /// <param name="pages">The pages.</param>
        /// <param name="pagesNeeded">The pages needed.</param>
        /// <param name="sectionContext">The section context.</param>
        /// <returns></returns>
        public IEnumerable<ISourcePage<T>> ReclaimPages(IEnumerable<ISourcePage<T>> pages, int pagesNeeded,
            string sectionContext)
        {
            return (from p in pages where p.CanReclaimPage orderby p.LastTouch select p).Take(pagesNeeded).ToList();
        }
    }
}