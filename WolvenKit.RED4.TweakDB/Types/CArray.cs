using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public interface IArray
    {
        public void SetItems(object o);
        public IList GetItems();
    } 

    public class CArray<T> : IType, IArray
        where T : IType
    {
        private string _name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    var obj = Activator.CreateInstance<T>();
                    _name = $"array:{obj.Name}";
                }

                return _name;
            }
        }

        public IList<T> Items = new List<T>();

        public override string ToString() => $"{Name}, Items = {Items.Count}";

        public void SetItems(object o)
        {
            if (o is IList<T> list)
            {
                Items = list;
            }
        }

        public IList GetItems() => (IList)Items;

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Items.Count);
            foreach(var item in Items)
            {
                item.Serialize(writer);
            }
        }
    }
}
