using System.Collections.Generic;

namespace WolvenKit.App.Functionality.Interfaces
{
    //https://gist.github.com/dmitry-pavlov/f3933c937c3520a410ab15c3ebc24d5e
    public interface ITree<T>
    {
        T Data { get; }
        ITree<T> Parent { get; }
        ICollection<ITree<T>> Children { get; }
        bool IsRoot { get; }
        bool IsLeaf { get; }
        int Level { get; }
    }
}
