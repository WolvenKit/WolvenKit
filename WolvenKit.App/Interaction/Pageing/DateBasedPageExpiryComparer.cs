using System;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Pageing
{
    /// <summary>
    ///     An implementation of a IPageExiryComparer that uses DateTime to see if the update should be applied
    /// </summary>
    public class DateBasedPageExpiryComparer : IPageExpiryComparer
    {
        /// <summary>
        ///     Gets the default instance.
        /// </summary>
        /// <value>
        ///     The default instance.
        /// </value>
        public static DateBasedPageExpiryComparer DefaultInstance { get; } = new DateBasedPageExpiryComparer();

        /// <summary>
        ///     Determines whether [is update valid] [the specified page based on the updateAt].
        /// </summary>
        /// <param name="pageUpdateAt">The page update at - null or a DateTime.</param>
        /// <param name="updateAt">The update at - null or a DateTime.</param>
        /// <returns></returns>
        public bool IsUpdateValid(object pageUpdateAt, object updateAt)
        {
            if (pageUpdateAt == null || updateAt == null || !(pageUpdateAt is DateTime) || !(updateAt is DateTime))
                return true;

            return ((DateTime) pageUpdateAt) < ((DateTime) updateAt);
        }
    }
}