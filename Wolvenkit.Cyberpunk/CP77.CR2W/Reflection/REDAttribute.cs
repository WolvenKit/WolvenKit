using System;

namespace WolvenKit.CR2W.Reflection
{
    /// <summary>
    /// Marks a field as serializable for redengine files.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class REDAttribute : Attribute
    {
        public string Name { get; private set; }
        public int[] Flags { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDAttribute"/> class.
        /// </summary>
        /// <param name="flags">
        /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
        /// </param>
        public REDAttribute(params int[] flags)
        {
            Flags = flags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// Custom name to use in place of the default name.
        /// </param>
        /// <param name="flags">
        /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
        /// </param>
        public REDAttribute(string name, params int[] flags)
        {
            Name = name;
            Flags = flags;
        }

        public override string ToString()
        {
            //return $"{Name} [{string.Join(",", Flags)}]";
            return $"{Name}";
        }
    }

    /// <summary>
    /// Marks a field as a compressed buffer for cr2w IO.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class REDBufferAttribute : REDAttribute
    {
        public bool IsIgnored { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDBufferAttribute"/> class.
        /// </summary>
        public REDBufferAttribute(bool isIgnored = false)
        {
            IsIgnored = isIgnored;
        }

        public override string ToString()
        {
            return String.Format($"{IsIgnored}");
        }
    }


    /// <summary>
    /// Marks a class as serializable for redengine files.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class REDMetaAttribute : Attribute
    {
        public EREDMetaInfo[] Keywords { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDMetaAttribute"/> class.
        /// </summary>
        /// <param name="keywords">
        /// Meta values registered in the rtti and additional information for parsing such as enumtype, fixedlayout classes etc.
        /// </param>
        public REDMetaAttribute(params EREDMetaInfo[] keywords)
        {
            Keywords = keywords;
        }

        public override string ToString()
        {
            return String.Format("{0}", String.Join(",", Keywords));
        }
    }





    public enum EREDMetaInfo
    {
        REDStruct,
        //REDComplex,
    }

}