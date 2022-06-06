using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("NodeRef")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "NodeRef")]
    public class NodeRef : BaseStringType
    {
        private static readonly ConcurrentDictionary<string, ulong> s_NodeRefStringCache = new();
        private static readonly ConcurrentDictionary<ulong, string> s_NodeRefHashCache = new();

        public delegate string ResolveHash(ulong hash);
        public static ResolveHash ResolveHashHandler;

        private readonly ulong _hash;

        public NodeRef() { }

        private NodeRef(string value) : base(value)
        {
            _hash = CalculateHash();
        }

        private NodeRef(ulong value)
        {
            _hash = value;
        }

        public string GetResolvedText()
        {
            if (!string.IsNullOrEmpty(_value))
            {
                return _value;
            }
            //else if (s_NodeRefHashCache.ContainsKey(_hash))
            //{
            //    return s_NodeRefHashCache[_hash];
            //}
            else
            {
                return ResolveHashHandler?.Invoke(_hash);
            }
        }

        private ulong CalculateHash()
        {
            if (string.IsNullOrEmpty(_value))
            {
                return 0;
            }

            if (!s_NodeRefStringCache.ContainsKey(_value))
            {
                var hash = FNV1A64HashAlgorithm.HashString(_value, Encoding.UTF8, false, true);

                s_NodeRefStringCache.TryAdd(_value, hash);
                s_NodeRefHashCache.TryAdd(hash, _value);
            }

            return s_NodeRefStringCache[_value];
        }

        public ulong GetRedHash() => _hash;
        public uint GetShortRedHash() => (uint)((_hash >> 32) ^ (uint)_hash);

        public static implicit operator NodeRef(string value) => new(value);
        public static implicit operator string(NodeRef value) => value?._value;

        public static implicit operator NodeRef(ulong value) => new(value);
        public static implicit operator ulong(NodeRef value) => value?._hash ?? 0;

        public static bool operator ==(NodeRef a, NodeRef b) => Equals(a, b);
        public static bool operator !=(NodeRef a, NodeRef b) => !(a == b);

        public override int GetHashCode() => _hash.GetHashCode();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((NodeRef)obj);
        }

        public bool Equals(NodeRef other)
        {
            if (!Equals(GetRedHash(), other?.GetRedHash()))
            {
                return false;
            }

            return true;
        }

        public override string ToString() => (GetResolvedText() is var text && !string.IsNullOrEmpty(text)) ? text : _hash.ToString();

        //public NodeRef() {}
        //private NodeRef(string value) : base(value) {}

        //public static implicit operator NodeRef(string value) => new(value);
        //public static implicit operator string(NodeRef value) => value._value;

        //public override string ToString() => $"NodeRef, Text = '{_value}'";
    }
}
