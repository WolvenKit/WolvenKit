using FastMember;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using WolvenKit.Utils;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public abstract class CVariable : ObservableObject, IEditableVariable
    {

        public CVariable(CR2WFile cr2w, CVariable parent, string name)
        {
            this.cr2w = cr2w;
            this.Parent = parent;
            this.REDName = name;

            InternalGuid = Guid.NewGuid();
            accessor = TypeAccessor.Create(this.GetType());
        }


        #region Fields
        private TypeAccessor accessor;
        #endregion

        #region Properties
        /// <summary>
        /// Stores the parent cr2w file.
        /// used a lot
        /// </summary>
        public CR2WFile cr2w { get; set; }

        /// <summary>
        /// Shows if the CVariable is to be serialized
        /// important because cr2w files only serialize initialized variables
        /// and some types are not null by default
        /// Is set upon read
        /// Must also be set when a variable is edited in the editor
        /// </summary>
        public bool IsSerialized { get; set; }


        /// <summary>
        /// an internal guid that is used to track cvariables 
        /// should be replaced by a better hashing algorithm
        /// or the Fullname method
        /// </summary>
        public Guid InternalGuid { get; set; }

        /// <summary>
        /// Stores the parent CVariable 
        /// Is set on read,
        /// otherwise must be set manually
        /// Consider moving this to the constructor
        /// </summary>
        public IEditableVariable Parent { get; private set; }




        private string name;
        /// <summary>
        /// AspectName in frmChunkProperties
        /// Name of the Variable, is set upon read
        /// otherwise has to be set manually
        /// Consider moving this to the constructor
        /// </summary>
        public string REDName
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new NotImplementedException();
                    return "<NO NAME SET>";
                }
                else
                    return  name;
            }
            private set => name = value;
        }

        /// <summary>
        /// !! Must ONLY be called from CArray type variables!!
        /// </summary>
        /// <param name="val"></param>
        public void SetREDName(string val) => REDName = val;

        /// <summary>
        /// AspectName in frmChunkProperties
        /// Gets the RedEngine Typename from the WkitType
        /// e.g. Color from CColor, or Uint64 from CUInt64
        /// Can be overwritten (e.g. in Array, Ptr and other generic types)
        /// </summary>
        public virtual string REDType => REDReflection.GetREDTypeString(this.GetType());

        /// <summary>
        /// AspectName in frmChunkProperties
        /// </summary>
        public string REDValue => this.ToString();
        #endregion

        #region Methods
        public ushort GettypeId() => (ushort)cr2w.GetStringIndex(REDType, true);

        public ushort GetnameId() => (ushort)cr2w.GetStringIndex(REDName, true);

        public string GetFullName()
        {
            var name = REDName;
            var c = Parent;
            while (c != null)
            {
                name = c.REDName + "/" + name;
                c = c.Parent;
            }
            return name;
        }


        #region Virtual

        /// <summary>
        /// Gets the list of RED and REDBuffer variables from a CVariable
        /// Can be overwritten by child classes
        /// </summary>
        /// <returns></returns>
        public virtual List<IEditableVariable> GetEditableVariables()
        {
            List<IEditableVariable> redvariables = new List<IEditableVariable>();
            List<PropertyInfo> redprops = REDReflection.GetREDProperties<REDAttribute>(this.GetType()).ToList();
            foreach (PropertyInfo pi in redprops)
            {
                // gets instantiated variables
                if (pi.GetValue(this) is CVariable cvar)
                {
                    redvariables.Add(cvar);
                }
                else
                {
                    // what if they're null? 
                    var cv = pi.GetValue(this);
                    if (cv is null)
                    {
                        // instantiate
                        var redname = REDReflection.GetREDNameString(pi);                           // get redname from attribute
                        var redtype = REDReflection.GetREDTypeString(pi.PropertyType);              // get redtype from type

                        

                        var newvar = CR2WTypeManager.Create(redtype, redname, this.cr2w, this);     // create new variable and parent to this 

                        if (newvar != null)
                            pi.SetValue(this, newvar);  // set value
                        else
                            throw new NotImplementedException();
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            return redvariables;
        }

        public List<IEditableVariable> GetExistingVariables(bool includeBuffers = true, bool includeInherited = true)
        {
            List<IEditableVariable> redvariables = new List<IEditableVariable>();
            var bindingFlags = BindingFlags.Public | BindingFlags.Instance;
            if (!includeInherited)
                bindingFlags |= BindingFlags.DeclaredOnly;


            /// From msdn:
            /// The GetProperties method does not return properties in a particular order, such as alphabetical or declaration order. 
            /// Your code must not depend on the order in which properties are returned, because that order varies.
            /// solutions: an order attribute, or built-in into REDAttribute
            List<PropertyInfo> redprops = REDReflection.GetREDProperties<REDAttribute>(this.GetType(), bindingFlags).ToList();

            foreach (PropertyInfo pi in redprops)
            {
                if (pi.GetCustomAttribute<REDAttribute>() is REDBufferAttribute && !includeBuffers )
                    continue;

                // gets instantiated variables
                if (pi.GetValue(this) is CVariable cvar)
                {
                    if (cvar.IsSerialized)
                        redvariables.Add(cvar);
                }
            }

            return redvariables;
        }


        

        /// <summary>
        /// Reads a Cvariable from a binaryreader stream
        /// Can be overwritten by child classes
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public virtual void Read(BinaryReader file, uint size)
        {
            REDMetaAttribute meta = (REDMetaAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(REDMetaAttribute));
            EREDMetaInfo[] tags = meta?.Keywords;

            var startpos = file.BaseStream.Position;

            // fixed class/struct (no leading null byte), read all properties in order
            if (tags.Contains(EREDMetaInfo.REDStruct))
            {
                //fields.AddRange(ReadAllRedVariables<REDAttribute>(file));
                ReadAllRedVariables<REDAttribute>(file);
            }
            // CVectors
            else
            {
                // CClipmapcookeddata has no trailing 0 ???
                if (this is CClipMapCookedData cClip)
                {
                    cClip.Data.Bytes = file.ReadBytes((int)size);
                    return;
                }
                


                sbyte zero = file.ReadSByte();
                //var dzero = file.ReadBit6();

                // quests\minor_quests\skellige\mq2008_lured_into_drowners.w2phase
                // in a CVariant for class "@SItem"
                // ... okay CDPR, is that a joke or what?
                if (zero != 0)
                {
                    if (zero == 1)
                    {
                        int joke = file.ReadInt32();
                    }
                    else if (zero == -128)
                    {
                        var dzero2 = file.ReadBit6();
                        return;
                    }
                    else
                    {
                        throw new InvalidParsingException($"Tried parsing a CVariable: zero read {zero}.");
                    }
                }

                List<string> dbg_varnames = new List<string>();
                while (true)
                {
                    var cvar = cr2w.ReadVariable(file, this);
                    if (cvar == null)
                        break;

                    cvar.IsSerialized = true;

                    // dbg
                    dbg_varnames.Add($"[{cvar.REDType}] {cvar.REDName}");

                    TryAddVariable(cvar);
                }

                // parse buffers
                ReadAllRedVariables<REDBufferAttribute>(file);

                var endpos = file.BaseStream.Position;
                var bytesread = endpos - startpos;
                if (bytesread != size)
                {

                }
            }
        }

        /// <summary>
        /// Instantiates and reads all REDVariables and REDBuffers in a CVariable 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="br"></param>
        /// <returns></returns>
        private List<CVariable> ReadAllRedVariables<T>(BinaryReader br) where T : REDAttribute
        {
            var parsedvars = new List<CVariable>();

            List<PropertyInfo> redprops = REDReflection.GetREDProperties<T>(this.GetType()).ToList();
            foreach (var pi in redprops)
            {
                if (pi.GetCustomAttribute<REDAttribute>() is REDBufferAttribute bufferAttribute
                    && bufferAttribute.IsIgnored)
                        continue;

                // Get
                // get redname from attribute
                var redname = REDReflection.GetREDNameString(pi);
                // get redtype from type
                var redtype = REDReflection.GetREDTypeString(pi.PropertyType);

                var parsedvar = CR2WTypeManager.Create(redtype, redname, this.cr2w, this);
                if (parsedvar == null)
                    throw new InvalidParsingException($"Variable {redtype}:{redname} was not read in class {this.GetType().Name}");

                // Read
                parsedvar.Read(br, 0); //FIXME size?
                parsedvar.IsSerialized = true;

                // add in class
                TryAddVariable(parsedvar);

                //parsedvars.Add(parsedvar);
            }

            return parsedvars;
        }

        /// <summary>
        /// Tries to set a Cvariable in the class
        /// </summary>
        /// <param name="value"></param>
        private bool TryAddVariable(CVariable value)
        {
            #region RedReflection
            //List<PropertyInfo> redprops = REDReflection.GetREDProperties<REDAttribute>(this.GetType()).ToList();
            //foreach (var p in redprops)
            //{
            //    if (p.GetCustomAttribute<REDAttribute>().Name == value.Name)
            //    {
            //        if (value is CEnum cenum)
            //        {
            //            p.SetValue(this, cenum.Enum);
            //        }
            //        else
            //        {
            //            p.SetValue(this, value);
            //        }
            //        break;
            //    }
            //}
            #endregion

            // not sure which is faster
            #region FastAccessor
            
            string varname = value.REDName.FirstCharToUpper();
            varname = NormalizeName(varname);
            //if!((this is SBufferWaypoints || this is SWayPointsCollectionsSetData))
            
            try
            {
                accessor[this, varname] = value;
            }
            catch (Exception)
            {
                try
                {
                    varname = varname.FirstCharToLower();
                    accessor[this, varname] = value;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"({value.REDType}){varname} not found in ({this.REDType}){this.REDName}");
                    throw ex;
                    return false;
                }
            }

            return true;

            string NormalizeName(string name)
            {
                var nname = name.Replace('.', '_')
                    .Replace(' ', '_')
                    .Replace('/', '_')
                    .Replace('\'', '_')
                    .Replace('-', '_')
                    .Replace('?', '_')
                    .Replace('(', '_')
                    .Replace(')', '_')
                    .Replace('[', '_')
                    .Replace(']', '_');
                if (Regex.IsMatch(nname, @"^\d+"))
                    nname = $"_{nname}";
                return nname;
            }
            #endregion

        }

        /// <summary>
        /// Writes a CVariable to a binarywriter stream
        /// Can be overwritten by child classes
        /// </summary>
        /// <param name="file"></param>
        public virtual void Write(BinaryWriter file)
        {
            //REDMetaAttribute meta = (REDMetaAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(REDMetaAttribute));
            //EREDMetaInfo[] tags = meta?.Keywords;

            // write leading null byte
            file.Write((byte)0);

            // write all initialized CVariables
            List<PropertyInfo> redprops = REDReflection.GetREDProperties<REDAttribute>(this.GetType()).ToList();
            foreach (PropertyInfo pi in redprops)
            {
                if (pi.GetCustomAttribute<REDAttribute>() is REDBufferAttribute bufferAttribute
                    && bufferAttribute.IsIgnored)
                    continue;

                // try get value
                if (pi?.GetValue(this) is CVariable cvar)
                {
                    if (cvar != null)
                    {
                        // only write values that are instantiated AND edited
                        if (cvar.IsSerialized)
                        {
                            // check if healthy? don't know how

                            // finally: write to stream
                            CR2WFile.WriteVariable(file, cvar);
                        }
                        else
                        {

                        }
                    }
                    else
                        throw new SerializationException();

                }
                // proper enums
                else if (pi?.GetValue(this) is Enum @enum)
                {

                }
            }

            // write trailing null byte
            file.Write((ushort)0);
        }







        /// <summary>
        /// Copies this CVariable
        /// Can be overwritten by child classes
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual CVariable Copy(CR2WCopyAction context)
        {
            // creates a new instance of the CVariable
            var copy = Create(context.DestinationFile, null , REDName); //FIXME

            // copy all REDProperties and REDBuffers
            foreach (IEditableVariable item in GetEditableVariables())
            {
                if (item is CVariable cvar)
                {
                    var innercontext = new CR2WCopyAction();
                    copy.TryAddVariable(cvar.Copy(innercontext));
                }
            }

            return copy;
        }



        public virtual void AddVariable(CVariable var)
        {
            throw new NotImplementedException();
        }

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual bool RemoveVariable(IEditableVariable child)
        {
            return false;
        }



        public virtual CVariable SetValue(object val)
        {
            return this;
        }

        public virtual Control GetEditor()
        {
            return null;
        }
        #endregion

        #region Abstract
        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            throw new NotImplementedException();
        }




        #endregion

        #region Override
        public override string ToString()
        {
            return $"<{REDType}>{REDName}";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = REDType == null ? hash : hash * 29 + REDType.GetHashCode();
                hash = REDName == null ? hash : hash * 29 + REDName.GetHashCode();
                hash = GetFullName() == null ? hash : hash * 29 + GetFullName().GetHashCode();
                var tos = ToString();
                hash = hash * 29 + tos.GetHashCode();
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

        #endregion

        #endregion

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