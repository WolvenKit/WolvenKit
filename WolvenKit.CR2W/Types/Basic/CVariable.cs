using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using WolvenKit.Common;
using WolvenKit.CR2W.Editors;
using WolvenKit.Utils;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public abstract class CVariable : ObservableObject, IEditableVariable
    {
        [NonSerialized]
        public CR2WFile cr2w;
        public Guid InternalGuid { get; set; }

        public CVariable(CR2WFile cr2w)
        {
            this.cr2w = cr2w;
            InternalGuid = Guid.NewGuid();
        }


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort typeId
        {
            get { return (ushort)cr2w.GetStringIndex(Type, true); }
            set { Type = cr2w.names[value].Str; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort nameId
        {
            get { return (ushort)cr2w.GetStringIndex(Name, true); }
            set { Name = cr2w.names[value].Str; }
        }

        public IEditableVariable Parent { get; set; }
        public string Value => this.ToString();

        public string FullName
        {
            get
            {
                var name = Name;
                var c = Parent;
                while (c != null)
                {
                    name = c.Name + "/" + name;
                    c = c.Parent;
                }
                return name;
            }
        }

        public CR2WFile CR2WOwner => cr2w;

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }

        public virtual Control GetEditor()
        {
            return null;
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            return null;
        }

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual void RemoveVariable(IEditableVariable child)
        {
        }

        public virtual void AddVariable(CVariable var)
        {
        }

        public abstract void Read(BinaryReader file, uint size);
        public abstract void Write(BinaryWriter file);
        public abstract CVariable Create(CR2WFile cr2w);

        public virtual CVariable SetValue(object val)
        {
            return this;
        }


        public virtual CVariable Copy(CR2WCopyAction context)
        {
            var var = Create(context.DestinationFile);
            var.Type = Type;
            var.Name = Name;
            return var;
        }

        public virtual CVariable CreateDefaultVariable()
        {
            return null;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = Type == null ? hash : hash * 29 + Type.GetHashCode();
                hash = Name == null ? hash : hash * 29 + Name.GetHashCode();
                hash = FullName == null ? hash : hash * 29 + FullName.GetHashCode();
                hash = hash * 29 + ToString().GetHashCode();
                var evars = GetEditableVariables();
                if (evars != null)
                {
                    foreach (var item in evars)
                    {
                        hash = hash * 29 + item.GetHashCode();
                    }
                }
                return hash;
            }
        }

        #region serialization
        //vl: I leave it commented here for it's rareness
        /*
        private static IEnumerable<Type> _variableTypes;

        private static IEnumerable<Type> GetKnownVariableTypes()
        {
            if (_variableTypes == null)
            {
                _variableTypes = Assembly.GetExecutingAssembly()
                                        .GetTypes()
                                        .Where(t => typeof(CVariable).IsAssignableFrom(t))
                                        .ToList();
            }
            return _variableTypes;
        }
        */

        public virtual void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);


                if (GetEditableVariables() != null)
                {
                    foreach (var v in GetEditableVariables())
                    {
                        v.SerializeToXml(xw);
                    }
                }
                ser.WriteEndObject(xw);
            }
        }
        /// <summary>
        /// Transfers bytes array to hex string like 0x00AADD..., TODO: build reverse function
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string HexStr(byte[] p)
        {
            char[] c = new char[p.Length * 2 + 2];
            byte b;
            c[0] = '0'; c[1] = 'x';

            for (int y = 0, x = 2; y < p.Length; ++y, ++x)
            {
                b = ((byte)(p[y] >> 4));
                c[x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
                b = ((byte)(p[y] & 0xF));
                c[++x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
            }
            return new string(c);
        }
        #endregion
    }
}