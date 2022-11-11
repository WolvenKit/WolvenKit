using System;
using System.Collections.Generic;
using System.IO;
using Splat;
using Syncfusion.Windows.Shared;
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

    public interface ITweakXLItem : IRedType
    {
        public TweakDBID ID { get; set; }
    }

    public class TweakXLFile : List<ITweakXLItem>, IRedType, IBrowsableType
    {
        public string GetBrowsableName() => null;

        public string GetBrowsableValue() => "TweakXLFile";

        public string GetBrowsableType() => null;
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

        private void WriteCName(IEmitter emitter, CName cName, string property = "")
        {
            if (!cName.Equals(CName.Empty))
            {
                if (!property.IsNullOrWhiteSpace())
                {
                    emitter.Emit(new Scalar(property));
                }

                emitter.Emit(new Scalar(cName.GetResolvedText()));
            }
        }

        private void WriteTweakDBID(IEmitter emitter, TweakDBID tweakDBID, string property = "")
        {
            if (tweakDBID.Length > 0)
            {
                if (!property.IsNullOrWhiteSpace())
                {
                    emitter.Emit(new Scalar(property));
                }

                emitter.Emit(new Scalar(tweakDBID.GetResolvedText()));
            }
        }
        private void WriteREDRaRef(IEmitter emitter, IRedResourceAsyncReference raRef, string property = "")
        {
            if (!property.IsNullOrWhiteSpace())
            {
                emitter.Emit(new Scalar(property));
            }

            if (raRef.IsSet)
            {
                emitter.Emit(new Scalar(raRef.DepotPath));
            }
            else
            {
                emitter.Emit(new Scalar(string.Empty));
            }
        }

        private void WriteLocKey(IEmitter emitter, gamedataLocKeyWrapper locKeyWrapper, string property = "")
        {
            if (locKeyWrapper.Key != 0)
            {
                var loc = Locator.Current.GetService<LocKeyService>().GetEntry(locKeyWrapper.Key);

                if (!property.IsNullOrWhiteSpace())
                {
                    emitter.Emit(new Scalar(property));
                }

                emitter.Emit(new Scalar($"LocKey#{loc.PrimaryKey}"));
            }
        }

        private void WriteVector2(IEmitter emitter, Vector2 vector2, string property = "")
        {
            if (!property.IsNullOrWhiteSpace())
            {
                emitter.Emit(new Scalar(property));
            }

            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Flow));
            emitter.Emit(new Scalar("x"));
            emitter.Emit(new Scalar(vector2.X.ToString()));
            emitter.Emit(new Scalar("y"));
            emitter.Emit(new Scalar(vector2.Y.ToString()));
            emitter.Emit(new MappingEnd());
        }

        private void WriteVector3(IEmitter emitter, Vector3 vector3, string property = "")
        {
            if (!property.IsNullOrWhiteSpace())
            {
                emitter.Emit(new Scalar(property));
            }

            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Flow));
            emitter.Emit(new Scalar("x"));
            emitter.Emit(new Scalar($"{vector3.X}"));
            emitter.Emit(new Scalar("y"));
            emitter.Emit(new Scalar($"{vector3.Y}"));
            emitter.Emit(new Scalar("z"));
            emitter.Emit(new Scalar($"{vector3.Z}"));
            emitter.Emit(new MappingEnd());
        }

        private void WriteREDArray(IEmitter emitter, IRedArray redArray, string property)
        {
            emitter.Emit(new Scalar(property));
            if (redArray.Count > 0)
            {
                emitter.Emit(new SequenceStart(null, null, false, SequenceStyle.Block));
                foreach (var redType in redArray)
                {
                    switch (redType)
                    {
                        case CName cName:
                            WriteCName(emitter, cName);
                            break;
                        case TweakDBID tweakDBID:
                            WriteTweakDBID(emitter, tweakDBID);
                            break;
                        case IRedResourceAsyncReference raRef:
                            WriteREDRaRef(emitter, raRef);
                            break;
                        case Vector2 vector2:
                            WriteVector2(emitter, vector2);
                            break;
                        case Vector3 vector3:
                            WriteVector3(emitter, vector3);
                            break;
                        case gamedataLocKeyWrapper locKeyWrapper:
                            WriteLocKey(emitter, locKeyWrapper);
                            break;
                        default:
                            emitter.Emit(new Scalar(redType.ToString()));
                            break;
                    }
                }
                emitter.Emit(new SequenceEnd());
            }
            else
            {
                // emit an empty array
                emitter.Emit(new SequenceStart(null, null, false, SequenceStyle.Flow));
                emitter.Emit(new SequenceEnd());
            }
        }

        // TODO: Write a ChainedEventEmitter for the style switching
        // TODO: Maybe consider using WithTagMapping for "!append", "!append-once", etc.
        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            foreach (var txlEntry in (TweakXLFile)value)
            {
                // for now we're only assuming one "tweak" per file during serialization. is this correct?
                // TODO: ViewModel probably needs to build ITweakXLItem for appends, etc.
                if (txlEntry is TweakXL txl)
                {
                    if (txl.Properties.Count > 0)
                    {
                        emitter.Emit(new Scalar(null, txlEntry.ID));
                        emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));
                    }

                    // iterate over the properties
                    foreach (var property in txl.GetPropertyNames())
                    {
                        var propertyToWrite = property;
                        // skip ID since it's already written as the map start
                        if (property == "ID")
                        {
                            continue;
                        }

                        if (property == "Type")
                        {
                            emitter.Emit(new Scalar("$type"));
                            emitter.Emit(new Scalar(txl.GetPropertyValue(property).ToString()));
                            continue;
                        }

                        if (property == "Value")
                        {
                            propertyToWrite = txl.ID.ResolvedText;
                        }

                        var propertyValue = txl.GetPropertyValue(property);
                        switch (propertyValue)
                        {
                            case CName cName:
                                WriteCName(emitter, cName, propertyToWrite);
                                break;
                            case TweakDBID tweakDBID:
                                WriteTweakDBID(emitter, tweakDBID, propertyToWrite);
                                break;
                            case IRedResourceAsyncReference raRef:
                                WriteREDRaRef(emitter, raRef, propertyToWrite);
                                break;
                            case Vector2 vector2:
                                WriteVector2(emitter, vector2, propertyToWrite);
                                break;
                            case Vector3 vector3:
                                WriteVector3(emitter, vector3, propertyToWrite);
                                break;
                            case gamedataLocKeyWrapper locKeyWrapper:
                                WriteLocKey(emitter, locKeyWrapper, propertyToWrite);
                                break;
                            // CArray of the types
                            case IRedArray redArray:
                                WriteREDArray(emitter, redArray, propertyToWrite);
                                break;
                            // TODO: EulerAngles & Quaterion
                            // CString, CFloat, CBool, CInt32
                            default:
                                emitter.Emit(new Scalar(propertyToWrite));
                                emitter.Emit(new Scalar(propertyValue.ToString()));
                                break;
                        }

                    }
                    if (txl.Properties.Count > 0)
                    {
                        emitter.Emit(new MappingEnd());
                    }
                }
            }
            emitter.Emit(new MappingEnd());
        }

        // eventually ITweakXLItem
        public IRedType ReadScalar(Scalar s, TweakDBService tdbs, Type type = null)
        {
            // TODO get parent type & property name, look-up type if ambiguous?
            // TODO parse type strings
            // TODO Maybe this can be done with some is magic.
            //
            //Value = tdbs.GetFlat(tdb);
            //Value ??= tdbs.GetRecord(tdb);
            //

            if (type == typeof(TweakDBID))
            {
                return (TweakDBID)s.Value;
            }
            return (CString)s.Value;
        }

        public ITweakXLItem ReadTweakXL(IParser parser, string id = null, Type type = null)
        {
            var _tdbs = Locator.Current.GetService<TweakDBService>();
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
                                childType = _tdbs.GetType(tweak.Base + "." + propertyName);
                            }
                            propertyValue = ReadScalar(s, _tdbs, childType);
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
                                childType = _tdbs.GetType(tweak.Base + "." + propertyName);
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
                                ((TweakXLSequence)propertyValue).Type = _tdbs.GetType(tweak.Base + "." + propertyName).Name;
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
                            // handle the various forms of "$type"
                            var recordTypeStr = propertyValue.ToString();
                            if (!recordTypeStr.EndsWith("_Record"))
                            {
                                recordTypeStr += "_Record";
                            }

                            if (!recordTypeStr.StartsWith("gamedata"))
                            {
                                recordTypeStr = "gamedata" + recordTypeStr;
                            }

                            tweak.Type = recordTypeStr;
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
                var tag = s.Tag.ToString();
                if (tag.StartsWith("!append"))
                {
                    var tweak = new TweakXLAppend
                    {
                        ID = ReadScalar(s, _tdbs).ToString()
                    };
                    if (tag.EndsWith("-once"))
                    {
                        tweak.AppendType = TweakXLAppendType.Once;
                    }
                    else if (tag.EndsWith("-from"))
                    {
                        tweak.AppendType = TweakXLAppendType.From;
                    }

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
                    tweak.Value = ReadScalar(s, _tdbs);
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
