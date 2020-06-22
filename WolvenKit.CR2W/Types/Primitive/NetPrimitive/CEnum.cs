using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public interface IEnumAccessor
    {
        string Value { get; set; }
    }


    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CEnum<T> : CVariable, IEnumAccessor where T : Enum
    {
        #region Properties
        public T WrappedEnum { get; set; }
        [DataMember]
        public string Value { get; set; }
        #endregion

        public CEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }



        public override string REDType => WrappedEnum.GetType().Name;



        public override void Read(BinaryReader file, uint size)
        {
            var idx = file.ReadUInt16();
            Value = cr2w.names[idx].Str;

            //handle EnumValues with Spaces in them. facepalm
            string finalvalue = Value.Replace(" ", string.Empty);
            finalvalue = finalvalue.Replace("'", string.Empty);
            finalvalue = finalvalue.Replace("/", string.Empty);
            finalvalue = finalvalue.Replace(".", string.Empty);

            try
            {
                T e = (T)Enum.Parse(WrappedEnum.GetType(), finalvalue);
                WrappedEnum = e;
            }
            catch (Exception)
            {
                Debug.WriteLine($"{Value} not found in {WrappedEnum.GetType().Name}");
                throw;
            }
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            try
            {
                var nw = cr2w.names.First(_ => _.Str == Value);
                val = (ushort)cr2w.names.IndexOf(nw);
            }
            catch (Exception)
            {
            }

            file.Write(val);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEnum<T>)base.Copy(context);
            var.Value = Value;
            var.WrappedEnum = WrappedEnum;
            return var;
        }

        public override Control GetEditor()
        {
            ComboBox cb = new ComboBox();
            cb.Items.AddRange(WrappedEnum.GetType().GetEnumNames());

            var s = WrappedEnum.ToString();


            cb.SelectedValue = WrappedEnum.ToString();
            cb.SelectedValueChanged += HandleEnumPick;
            return cb;
        }

        private void HandleEnumPick(object sender, System.EventArgs e)
        {
            SetValue((sender as ComboBox).SelectedItem);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string)val;
            }

            return this;
        }

        public override string ToString() => Value;

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnum<T>(cr2w, parent, name);
    }
}