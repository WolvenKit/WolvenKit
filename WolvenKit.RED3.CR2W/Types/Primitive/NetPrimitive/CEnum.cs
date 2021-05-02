using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CEnum<T> : CVariable, IEnumAccessor<T> where T : Enum
    {
        public CEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        private T _value;
        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateStringList();
            }
        }

        [DataMember]
        public List<string> EnumValueList { get; set; } = new List<string>();

        public bool IsFlag => Value.GetType().IsDefined(typeof(FlagsAttribute), false);

        private void UpdateStringList()
        {
            var strings = new List<string>();
            if (IsFlag)
            {
                // TODO: not implemented
            }
            else
            {
                strings.Add(Value.ToString());
            }

            EnumValueList = strings;
        }

        public Type GetEnumType() => Value.GetType();
        public string EnumToString() => Value.ToString();

        public override string REDType => Value.GetType().Name;

        private static void SetFlag<T1>(ref T1 value, T1 flag) where T1 : Enum
        {
            ulong numericValue = Convert.ToUInt64(value);
            numericValue |= Convert.ToUInt64(flag);
            value = (T1)Enum.ToObject(typeof(T1), numericValue);
        }
        private static void ClearFlag<T1>(ref T1 value, T1 flag) where T1 : Enum
        {
            ulong numericValue = Convert.ToUInt64(value);
            numericValue &= ~Convert.ToUInt64(flag);
            value = (T1)Enum.ToObject(typeof(T1), numericValue);
        }

        public override void Read(BinaryReader file, uint size)
        {
            List<string> strings = new List<string>();
            if (IsFlag)
            {
                while (true)
                {
                    var idx = file.ReadUInt16();
                    if (idx == 0)
                        break;

                    string s = cr2w.Names[idx].Str;

                    strings.Add(s);
                }
            }
            else
            {
                var idx = file.ReadUInt16();

                string s = cr2w.Names[idx].Str;

                strings.Add(s);
            }

            SetValue(strings);
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            foreach (var item in EnumValueList)
            {
                var nw = cr2w.Names.First(_ => _.Str == item);
                val = (ushort)cr2w.Names.IndexOf(nw);

                file.Write(val);
            }
            if (IsFlag)
                file.Write((ushort)0x00);
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CEnum<T>)base.Copy(context);
            var.EnumValueList = EnumValueList;
            var.Value = Value;
            return var;
        }

        public override IEditableVariable SetValue(object val)
        {
            if (!(val is List<string> l)) return this;

            EnumValueList = l;

            if (IsFlag)
            {
                foreach (var item in Value.GetType().GetEnumNames())
                {
                    //handle EnumValues with Spaces in them. facepalm.
                    string finalvalue = item.Replace(" ", string.Empty);
                    finalvalue = finalvalue.Replace("'", string.Empty);
                    finalvalue = finalvalue.Replace("/", string.Empty);
                    finalvalue = finalvalue.Replace(".", string.Empty);
                    var en = (T)Enum.Parse(Value.GetType(), finalvalue);

                    // flag is set
                    if (EnumValueList.Contains(item))
                        SetFlag<T>(ref _value, en);
                    // flag is not set
                    else
                        ClearFlag<T>(ref _value, en);
                }
            }
            else
            {
                var s = EnumValueList.Last();

                //handle EnumValues with Spaces in them. facepalm.
                string finalvalue = s.Replace(" ", string.Empty);
                finalvalue = finalvalue.Replace("'", string.Empty);
                finalvalue = finalvalue.Replace("/", string.Empty);
                finalvalue = finalvalue.Replace(".", string.Empty);

                // set enum
                T en = (T)Enum.Parse(Value.GetType(), finalvalue);
                Value = en;
            }

            return this;
        }

        public override string ToString() => string.Join(",", this.EnumValueList);

        public string GetAttributeVal()
        {

            if (IsFlag)
            {
                throw new NotImplementedException("CEnum - GetAttributeVal");
            }

            var type = typeof(T);
            var memInfo = type.GetMember(Value.ToString());
            if (memInfo.Length < 1)
            {

            }
            var att = memInfo[0].GetCustomAttributes(typeof(REDAttribute), false);

            if (att.Length < 1)
                return Value.ToString();

            if (!(att.First() is REDAttribute attribute) || string.IsNullOrWhiteSpace(attribute.Name))
                return Value.ToString();
            else
                return attribute.Name;
        }
    }
}
