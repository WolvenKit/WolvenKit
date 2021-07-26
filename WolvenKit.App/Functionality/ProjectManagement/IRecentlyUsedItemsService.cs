using System;
using System.Collections.Generic;

namespace WolvenKit.Functionality.ProjectManagement
{
    public interface IRecentlyUsedItemsService
    {
        List<RecentlyUsedItem> Items { get; }
        IEnumerable<RecentlyUsedItem> PinnedItems { get; }

        void AddItem(RecentlyUsedItem recentlyUsedItem);
        void RemoveItem(RecentlyUsedItem item);
        void PinItem(string parameter);
        void UnpinItem(string parameter);
    }

    public class RecentlyUsedItemsService : IRecentlyUsedItemsService   
    {
        public List<RecentlyUsedItem> Items { get; } = new List<RecentlyUsedItem>();

        public IEnumerable<RecentlyUsedItem> PinnedItems => throw new NotImplementedException();

        public void AddItem(RecentlyUsedItem recentlyUsedItem) => Items.Add(recentlyUsedItem);
        public void PinItem(string parameter) => throw new NotImplementedException();
        public void RemoveItem(RecentlyUsedItem item) => Items.Remove(item);
        public void UnpinItem(string parameter) => throw new NotImplementedException();
    }

    public class RecentlyUsedItem
    {
       

        public RecentlyUsedItem(string parameter, DateTime dateTime)
        {
            Name = parameter;
            DateTime = dateTime;
        }

        public string Name { get; set; }
        public DateTime DateTime { get; internal set; }
    }


}
