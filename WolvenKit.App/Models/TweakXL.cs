using System;
using System.Collections.Generic;
using System.IO;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace WolvenKit.Models
{
    public interface IBrowsableType
    {
        public string GetBrowsableName();
        public string GetBrowsableValue();
        public string GetBrowsableType();
    }

    public interface IBrowsableDictionary
    {
        public IEnumerable<string> GetPropertyNames();
        public object GetPropertyValue(string name);
    }

    public class TweakXLFile : List<ITweakXLItem>, IRedType, IBrowsableType
    {
        public string GetBrowsableName() => null;

        public string GetBrowsableValue() => "TweakXLFile";

        public string GetBrowsableType() => null;
    }

    public interface ITweakXLItem : IRedType
    {
        public TweakDBID ID { get; set; }
    }

    public class TweakXL : ITweakXLItem, IBrowsableType, IBrowsableDictionary
    {
        public TweakDBID ID { get; set; }

        public TweakDBID Base { get; set; }

        public CString Type { get; set; }

        // eventually ITweakXLItem
        public RedDictionary<string, IRedType> Properties { get; set; } = new();

        public IRedType Value { get; set; }

        public TweakXL()
        {

        }

        public virtual string GetBrowsableName() => Type;

        //public virtual string GetBrowsableValue() => Value != null ? Value.ToString() : ID.GetResolvedText();
        public virtual string GetBrowsableValue() => ID.GetResolvedText();

        public virtual string GetBrowsableType() => Type;

        public virtual IEnumerable<string> GetPropertyNames()
        {
            if (ID != TweakDBID.Empty)
            {
                yield return "ID";
            }
            if (Value != null)
            {
                yield return "Value";
            }
            if (Base != TweakDBID.Empty)
            {
                yield return "Base";
            }
            if (Type != CString.Empty)
            {
                yield return "Type";
            }
            foreach (var key in Properties.Keys)
            {
                yield return key;
            }
        }

        public virtual object GetPropertyValue(string name)
        {
            if (name == "ID")
            {
                return ID;
            }
            if (name == "Value")
            {
                return Value;
            }
            if (name == "Base")
            {
                return Base;
            }
            if (name == "Type")
            {
                return Type;
            }
            return Properties.GetValueOrDefault(name);
        }
    }

    public class RedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IRedType
    {

    }

    public class TweakXLSequence : IBrowsableType, ITweakXLItem, IBrowsableDictionary
    {
        public TweakDBID ID { get; set; } = new();

        public CString Type { get; set; }

        public CArray<ITweakXLItem> Items { get; set; } = new();

        public string GetBrowsableName() => null;

        public string GetBrowsableValue() => ID.GetResolvedText();

        public string GetBrowsableType() => null;

        public IEnumerable<string> GetPropertyNames()
        {
            if (ID != TweakDBID.Empty)
            {
                yield return "ID";
            }
            if (Type != CString.Empty)
            {
                yield return "Type";
            }
            if (Items != null)
            {
                yield return "Items";
            }
        }

        public object GetPropertyValue(string name)
        {
            if (name == "ID")
            {
                return ID;
            }
            if (name == "Type")
            {
                return Type;
            }
            if (name == "Items")
            {
                return Items;
            }
            return null;
        }
    }

    public enum TweakXLAppendType
    {
        Regular = 0,
        Once,
        From,
    }

    public class TweakXLAppend : TweakXL
    {
        public CEnum<TweakXLAppendType> AppendType { get; set; } = new();

        public override IEnumerable<string> GetPropertyNames()
        {
            yield return "AppendType";
            foreach (var key in base.GetPropertyNames())
            {
                yield return key;
            }
        }

        public override object GetPropertyValue(string name)
        {
            if (name == "AppendType")
            {
                return AppendType;
            }
            return base.GetPropertyValue(name);
        }
    }

    public class TweakXLYamlTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type) => type == typeof(TweakXLFile);

        public object ReadYaml(IParser parser, Type type)
        {
            TweakXLFile result;

            if (parser.Current is not MappingStart)
            {
                throw new InvalidDataException("Invalid YAML content.");
            }

            parser.MoveNext(); // move on from the map start

            result = new TweakXLFile();

            while (!parser.TryConsume<MappingEnd>(out var _))
            {
                if (parser.TryConsume<Scalar>(out var id))
                {
                    var tweak = ReadTweakXL(parser, id.Value);
                    if (tweak != null)
                    {
                        result.Add(tweak);
                    }
                }
                else if (parser.Current is not MappingEnd)
                {
                    parser.MoveNext();
                }

            }

            return result;
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {

        }

        // eventually ITweakXLItem
        public IRedType ReadScalar(Scalar s, Type type = null)
        {
            // TODO get parent type & property name, look-up type if ambiguous?
            // TODO parse type strings
            // TODO Maybe this can be done with some is magic.
            if (type == typeof(TweakDBID))
            {
                return (TweakDBID)s.Value;
            }
            return (CString)s.Value;
        }

        public ITweakXLItem ReadTweakXL(IParser parser, string id = null, Type type = null)
        {
            if (parser.TryConsume<SequenceStart>(out var _))
            {
                var tweak = new TweakXLSequence();
                if (id != null)
                {
                    tweak.ID = id;
                }
                //if (type != null)
                //{
                //    tweak.Type = type.Name;
                //}
                while (!parser.TryConsume<SequenceEnd>(out var _))
                {
                    tweak.Items.Add(ReadTweakXL(parser));
                }
                return tweak;
            }
            else if (parser.TryConsume<MappingStart>(out var _))
            {
                var tweak = new TweakXL();
                if (id != null)
                {
                    tweak.ID = id;
                }
                while (!parser.TryConsume<MappingEnd>(out var _))
                {
                    if (parser.TryConsume<Scalar>(out var pn))
                    {
                        var propertyName = pn.Value;
                        //string propertyID = propertyName;
                        //if (propertyID != null && id != null)
                        //{
                        //    propertyID = id + "." + propertyID;
                        //}
                        // eventually ITweakXLItem

                        IRedType propertyValue = null;

                        // regular property
                        if (parser.TryConsume<Scalar>(out var s))
                        {
                            Type childType = null;
                            if (tweak.Base != TweakDBID.Empty && propertyName != null)
                            {
                                childType = Locator.Current.GetService<TweakDBService>().GetType(tweak.Base + "." + propertyName);
                            }
                            propertyValue = ReadScalar(s, childType);
                        }
                        // embedded record
                        else if (parser.Current is MappingStart)
                        {
                            var childID = id;
                            if (childID != null && propertyName != null)
                            {
                                childID = childID + "." + propertyName;
                            }
                            Type childType = null;
                            if (tweak.Base != TweakDBID.Empty && propertyName != null)
                            {
                                childType = Locator.Current.GetService<TweakDBService>().GetType(tweak.Base + "." + propertyName);
                            }
                            propertyValue = ReadTweakXL(parser, id: childID, type: childType);
                        }
                        // array/list
                        else if (parser.TryConsume<SequenceStart>(out var _))
                        {
                            propertyValue = new TweakXLSequence();
                            if (id != null)
                            {
                                ((TweakXLSequence)propertyValue).ID = id + "." + propertyName;
                            }
                            if (tweak.Base != TweakDBID.Empty && propertyName != null)
                            {
                                ((TweakXLSequence)propertyValue).Type = Locator.Current.GetService<TweakDBService>().GetType(tweak.Base + "." + propertyName).Name;
                            }
                            //if (type != null)
                            //{
                            //    ((TweakXLSequence)propertyValue).Type = type;
                            //}
                            while (!parser.TryConsume<SequenceEnd>(out var _))
                            {
                                ((TweakXLSequence)propertyValue).Items.Add(ReadTweakXL(parser));
                            }
                        }

                        if (propertyName == "$type")
                        {
                            tweak.Type = "gamedata" + propertyValue + "_Record";
                        }
                        else if (propertyName == "$base")
                        {
                            tweak.Base = (TweakDBID)propertyValue.ToString();
                        }
                        else if (propertyName is not null and not "")
                        {
                            tweak.Properties[propertyName] = propertyValue;
                        }
                    }
                    else if (parser.Current is not MappingEnd)
                    {
                        parser.MoveNext();
                        continue;
                    }

                }

                return tweak;
            }
            else if (parser.TryConsume<Scalar>(out var s))
            {
                if (s.Tag == "!append")
                {
                    var tweak = new TweakXLAppend
                    {
                        ID = ReadScalar(s).ToString()
                    };
                    return tweak;
                }
                else
                {
                    //var tweak = new TweakXL();
                    //if (id != null && id.Split(".") is var id_split && id_split.Count() > 1)
                    //{
                    //    tweak.ID = string.Join(".", id_split[..^1]);
                    //    tweak.Properties.Add(id_split[^1], ReadScalar(s).ToString());
                    //}
                    //return tweak;
                    var tweak = new TweakXL();
                    if (id != null)
                    {
                        tweak.ID = id;
                    }
                    tweak.Value = ReadScalar(s);
                    return tweak;
                }
            }
            else
            {
                parser.MoveNext();
            }

            return null;
        }
    }
}
