using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.Functionality.Interfaces;

namespace WolvenKit.Functionality.Extensions
{
    //https://gist.github.com/dmitry-pavlov/f3933c937c3520a410ab15c3ebc24d5e
    public static class TreeExtensions
    {
        /// <summary> Converts given collection to tree. </summary>
        /// <typeparam name="T">Custom data type to associate with tree node.</typeparam>
        /// <param name="items">The collection items.</param>
        /// <param name="parentSelector">Expression to select parent.</param>
        public static ITree<T> ToTree<T>(this IList<T> items, Func<T, T, bool> parentSelector)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            var lookup = items.ToLookup(item => items.FirstOrDefault(parent => parentSelector(parent, item)),
                child => child);

            return Tree<T>.FromLookup(lookup);
        }

        /// <summary> Internal implementation of <see cref="ITree{T}" /></summary>
        /// <typeparam name="T">Custom data type to associate with tree node.</typeparam>
        internal class Tree<T> : ITree<T>
        {
            public T Data { get; }

            public ITree<T> Parent { get; private set; }

            public ICollection<ITree<T>> Children { get; }

            public bool IsRoot => Parent == null;

            public bool IsLeaf => Children.Count == 0;

            public int Level => IsRoot ? 0 : Parent.Level + 1;

            private Tree(T data)
            {
                Children = new LinkedList<ITree<T>>();
                Data = data;
            }

            public static Tree<T> FromLookup(ILookup<T, T> lookup)
            {
                var rootData = lookup.Count == 1 ? lookup.First().Key : default;
                var root = new Tree<T>(rootData);
                root.LoadChildren(lookup);
                return root;
            }

            private void LoadChildren(ILookup<T, T> lookup)
            {
                foreach (var data in lookup[Data])
                {
                    var child = new Tree<T>(data) { Parent = this };
                    Children.Add(child);
                    child.LoadChildren(lookup);
                }
            }
        }
    }
}
