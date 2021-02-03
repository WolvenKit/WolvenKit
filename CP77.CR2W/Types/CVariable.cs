using DotNetHelper.FastMember.Extension.Extension;
using FastMember;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using Catel.Data;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using CP77.CR2W.Reflection;
using ObservableObject = Catel.Data.ObservableObject;

namespace CP77.CR2W.Types
{
    public abstract class CVariable : ObservableObject, IEditableVariable
    {
        protected CVariable()
        {
            this.VarChunkIndex = -1;
            
            accessor = TypeAccessor.Create(this.GetType());
        }

        protected CVariable(CR2WFile cr2w, CVariable parent, string name)
        {
            this.cr2w = cr2w;
            this.ParentVar = parent;
            this.REDName = name;
            this.VarChunkIndex = -1;

            
            accessor = TypeAccessor.Create(this.GetType());
        }


        #region Fields
        [JsonIgnore]
        public readonly TypeAccessor accessor;

        #endregion

        #region Properties

        [JsonIgnore]
        public List<CVariable> UnknownCVariables { get; set; } = new List<CVariable>();

        /// <summary>
        /// Stores the parent cr2w file.
        /// used a lot
        /// </summary>
        [JsonIgnore]
        public CR2WFile cr2w { get; set; }

        /// <summary>
        /// Shows if the CVariable is to be serialized
        /// important because cr2w files only serialize initialized variables
        /// and some types are not null by default
        /// Is set upon read
        /// Must also be set when a variable is edited in the editor
        /// </summary>
        [JsonIgnore]
        public bool IsSerialized { get; set; }
        public void SetIsSerialized()
        {
            IsSerialized = true;

            if (ParentVar != null)
                if (ParentVar is CVariable cparent)
                    cparent.SetIsSerialized();
        }

        private ushort _redFlags;
        /// <summary>
        /// Flags inherited from cr2w export (aka chunk)
        /// 0 means chunk is uncooked (useful for some file types that have 
        /// a different layout in the uncooked and cooked state, e.g. CBitmapTexture)
        /// Is set on file read and should not be modified
        /// </summary>
        public ushort REDFlags => ParentVar?.REDFlags ?? _redFlags;
        public void SetREDFlags(ushort flag) => _redFlags = flag;

        /// <summary>
        /// an internal id that is used to track cvariables 
        /// </summary>
        [JsonIgnore]
        public string UniqueIdentifier => GetFullDependencyStringName();

        /// <summary>
        /// an internal id that is used to track typenames 
        /// </summary>
        [JsonIgnore]
        private string TypeNameWithParents => GetREDTypeNameWithParents();


        /// <summary>
        /// Stores the parent CVariable 
        /// Is set on read,
        /// otherwise must be set manually
        /// Consider moving this to the constructor
        /// </summary>
        public IEditableVariable ParentVar { get; set; }

        /// <summary>
        /// -1 for children CVars, actual chunk index for root cvar aka cr2wexportwrapper.data
        /// </summary>
        public int VarChunkIndex { get; set; }


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
                    //return "<NO NAME SET>";
                }
                else
                    return name;
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
        /// <summary>
        /// Exported to database
        /// </summary>
        public virtual string REDLeanValue() => this.REDValue;
        #endregion

        #region Methods
        private string GetFullDependencyStringName()
        {
            var depstr = this.REDName;
            var par = this.ParentVar;
            // top level chunk variables return the chunk index
            if (par == null)
                return $"{this.VarChunkIndex}.{this.REDName}";

            while (true)
            {
                depstr = $"{par.REDName}.{depstr}";
                
                if (par.ParentVar == null)
                {
                    depstr = $"{par.VarChunkIndex}.{depstr}";
                    break;
                }
                par = par.ParentVar;
            }

            return depstr;
        }

        private string GetREDTypeNameWithParents()
        {
            var t = GetType();
            var s = new List<string>() {t.Name};
            while (true)
            {
                t = t?.BaseType;
                if (t == typeof(CVariable))
                    break;
                s.Add(t.Name);
            }

            s.Reverse();
            return string.Join('.', s);
        }

        public ushort GettypeId() => (ushort)cr2w.GetStringIndex(REDType, true);

        public ushort GetnameId() => (ushort)cr2w.GetStringIndex(REDName, true);

        public string GetFullName()
        {
            var _nam = REDName;
            var c = ParentVar;
            while (c != null)
            {
                _nam = c.REDName + "/" + _nam;
                c = c.ParentVar;
            }
            return _nam;
        }

        /// <summary>
        /// Recurses through parents until the root cvariable to find the meaningful chunkindex
        /// </summary>
        /// <returns></returns>
        public int LookUpChunkIndex()
        {
            var currentcvar = this as IEditableVariable;
            while (currentcvar.VarChunkIndex == -1)
            {
                currentcvar = currentcvar.ParentVar;
            }
            return currentcvar.VarChunkIndex;
        }
#if DEBUG
        [JsonIgnore]
        public int GottenVarChunkIndex => LookUpChunkIndex();
#endif

        #region Virtual
        [JsonIgnore]
        public List<IEditableVariable> ChildrEditableVariables => GetEditableVariables();
        [JsonIgnore]
        public List<IEditableVariable> ChildrExistingVariables => GetExistingVariables(false);

        /// <summary>
        /// Gets the list of RED and REDBuffer variables from a CVariable
        /// Can be overwritten by child classes
        /// </summary>
        /// <returns></returns>
        public virtual List<IEditableVariable> GetEditableVariables()
        {
            List<IEditableVariable> redvariables = new List<IEditableVariable>(UnknownCVariables);

            foreach (Member item in this.GetREDMembers(true))
            {
                object o = accessor[this, item.Name];
                if (o is CVariable cvar)
                    redvariables.Add(cvar);
                else // is null
                {
                    REDAttribute att = item.GetMemberAttribute<REDAttribute>();
                    // instantiate
                    string vartype = REDReflection.GetREDTypeString(item.Type, att.Flags);
                    string varname = REDReflection.GetREDNameString(item);

                    var newvar = CR2WTypeManager.Create(vartype, varname, this.cr2w, this);     // create new variable and parent to this 
                    if (newvar != null)
                    {
                        accessor[this, item.Name] = newvar;
                        redvariables.Add(newvar);
                    }
                }
            }

            return redvariables;
        }

        public List<IEditableVariable> GetExistingVariables(bool includeBuffers = true)
        {
            List<IEditableVariable> redvariables = new List<IEditableVariable>(UnknownCVariables);

            foreach (Member item in this.GetREDMembers(includeBuffers))
            {
                // ??
                //if (includeBuffers && item.GetMemberAttribute<REDBufferAttribute>()==null)
                //    continue;

                var o = accessor[this, item.Name];
                if (o is CVariable cvar)
                {
                    if (cvar.IsSerialized)
                        redvariables.Add(cvar);
                }
                else // is null
                {
                    // do nothing
                }
            }

            return redvariables;
        }

        /// <summary>
        /// Reads a CVariable as a fixed size struct
        /// (not in the cr2w custom serialization)
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public virtual void ReadAsFixedSize(BinaryReader file, uint size)
        {
            if (this is IREDPrimitive)
                Read(file, size);
            else
                ReadAllRedVariables<REDAttribute>(file);
        }

        /// <summary>
        /// Reads a CVariable from a binaryreader stream
        /// Can be overwritten by child classes
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public virtual void Read(BinaryReader file, uint size)
        {
            var meta = (REDMetaAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(REDMetaAttribute));
            EREDMetaInfo[] tags = meta?.Keywords;

            var startpos = file.BaseStream.Position;

            // fixed class/struct (no leading null byte), read all properties in order
            if ((tags ?? throw new InvalidOperationException()).Contains(EREDMetaInfo.REDStruct))
            {
                // parse all RED variables (normal + buffers)
                ReadAllRedVariables<REDAttribute>(file);
            }
            // CVectors
            else
            {
                #region initial checks
                sbyte zero = file.ReadSByte();
                //var dzero = file.ReadBit6();

                // ... okay CDPR, is that a joke or what?
                if (zero != 0)
                {
                    switch (zero)
                    {
                        case 1:
                            int joke = file.ReadInt32();
                            break;
                        case -128:
                            var dzero2 = file.ReadBit6();
                            return;
                        case -1:
                            return;
                        default:
                            throw new InvalidParsingException($"Tried parsing a CVariable: zero read {zero}.");
                    }
                }
                #endregion

                #region parse sequential variables
                List<string> dbg_varnames = new List<string>();
                while (true)
                {

                    //cvar is a "children variable" : a property of a class.
                    var cvar = cr2w.ReadVariable(file, this);
                    if (cvar == null)
                        break;

                    cvar.IsSerialized = true;

#if DEBUG
                    dbg_varnames.Add($"[{cvar.REDType}] {cvar.REDName}");
#endif

                    // unknown types
                    if (cvar.REDName.Contains("UNKNOWN:"))
                        UnknownCVariables.Add(cvar);
                    else
                        TrySettingFastMemberAccessor(cvar);
                }
                #endregion

                //dbg
                var endpos1 = file.BaseStream.Position;
                var bytesread1 = endpos1 - startpos;
                var bytesleft = size - bytesread1;

                // parse only buffers
                ReadAllRedVariables<REDBufferAttribute>(file);

                // checks
                var endpos = file.BaseStream.Position;
                var bytesread = endpos - startpos;
                if (bytesread > size)
                {
                    if (size > 0)
                    {

                    }
                    // parsed to far: possible file corruption
                    // BUT: this check is impossible for elements of an array.
                    // in this case, passed size is 0, so we can check for that
                    //if (size != 0)
                    //    throw new InvalidParsingException($"Read bytes not equal to expected bytes. Difference: {bytesread - size}");
                }
                else if (bytesread < size)
                {
                    // parsed too few bytes: add to unknown bytes later
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
            var redproperties = typeof(T) == typeof(REDBufferAttribute) 
                ? this.GetREDBuffers() 
                : this.GetREDMembers(true);

            foreach (Member item in redproperties)
            {
                var att = item.GetMemberAttribute<T>();
                if (att is REDBufferAttribute {IsIgnored: true})
                {
                    // add IsSerialized?
                    continue;
                }

                string vartype = REDReflection.GetREDTypeString(item.Type, att.Flags);
                string varname = REDReflection.GetREDNameString(item);

                var parsedvar = CR2WTypeManager.Create(vartype, varname, this.cr2w, this);     // create new variable and parent to this 
                if (parsedvar == null)
                    throw new InvalidParsingException($"Variable {vartype}:{varname} was not read in class {this.GetType().Name}");

                // Read
                parsedvar.Read(br, 0); //FIXME size?
                parsedvar.IsSerialized = true;

                // add in class
                TrySettingFastMemberAccessor(parsedvar);

            }
            return parsedvars;
        }

        /// <summary>
        /// Tries to set a Cvariable in the class
        /// </summary>
        /// <param name="value"></param>
        private bool TrySettingFastMemberAccessor(IEditableVariable value)
        {
            foreach (var member in this.accessor.GetMembers())
            {
                try
                {
                    var redname = REDReflection.GetREDNameString(member);
                    if (redname != value.REDName)
                        continue;
                    accessor[this, member.Name] = value;
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            throw new InvalidParsingException($"({value.REDType}){value.REDName} not found in ({this.TypeNameWithParents}){this.REDName}");
            //Console.WriteLine($"({value.REDType}){value.REDName} not found in ({this.TypeNameWithParents}){this.REDName}");
            //return false;

            
        }

        /// <summary>
        /// Writes a CVariable to a binarywriter stream
        /// Can be overwritten by child classes
        /// </summary>
        /// <param name="file"></param>
        public virtual void Write(BinaryWriter file)
        {
            REDMetaAttribute meta = (REDMetaAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(REDMetaAttribute));
            EREDMetaInfo[] tags = meta?.Keywords;

            // fixed class/struct (no leading null byte), write all properties in order
            if ((tags ?? throw new InvalidOperationException()).Contains(EREDMetaInfo.REDStruct))
            {
                // write all CVariables
                foreach (Member item in this.GetREDMembers(true))
                {
                    var att = item.GetMemberAttribute<REDAttribute>();
                    // don't write ignored buffers, they get written in the class
                    if (att is REDBufferAttribute bufferAttribute && bufferAttribute.IsIgnored)
                    {
                        // add IsSerialized?
                        continue;
                    }

                    // just write the RedBuffer without variable id
                    if (this.accessor[this, item.Name] is CVariable av)
                        av.Write(file);

                    //if (pi?.GetValue(this) is CVariable cbuf)
                    //{
                    //    cbuf.Write(file);
                    //}
                }
            }
            // CVectors
            else
            {
                // write leading null byte
                file.Write((byte)0);

                // write all initialized CVariables (no buffers!)
                foreach (Member item in this.GetREDMembers(false))
                {
                    var att = item.GetMemberAttribute<REDAttribute>();
                    if (this.accessor[this, item.Name] is CVariable av)
                    {
                        if (av != null)
                        {
                            // only write values that are instantiated AND edited
                            if (av.IsSerialized)
                            {
                                // check if healthy? don't know how

                                // finally: write to stream
                                CR2WFile.WriteVariable(file, av);
                            }
                            else
                            {

                            }
                        }
                        else
                            throw new SerializationException();
                    }
                    // proper enums
                    // never happens
                    else if (this.accessor[this, item.Name] is Enum @enum)
                    {
                        throw new NotImplementedException();
                    }
                }

                // write trailing null bytes
                file.Write((ushort)0);

                // write all Buffers
                foreach (Member item in this.GetREDBuffers())
                {
                    var att = item.GetMemberAttribute<REDBufferAttribute>();

                    // ignore some RedBuffers (formerly unknown bytes)
                    if (att.IsIgnored)
                        continue;
                    else
                    {
                        var b = this.accessor[this, item.Name];
                        if (b == null)
                        {
                            // buffers always need to be written
                            // so if they are null, we still need to instantiate an empty variable
                            string vartype = REDReflection.GetREDTypeString(item.Type, att.Flags);
                            string varname = REDReflection.GetREDNameString(item);
                            var parsedvar = CR2WTypeManager.Create(vartype, varname, this.cr2w, this);     // create new variable and parent to this 
                            if (parsedvar == null)
                                throw new InvalidParsingException($"Variable {vartype}:{varname} was not read in class {this.GetType().Name}");
                            parsedvar.Write(file);
                        }
                        else
                        {
                            if (b is CVariable cbuf)
                            {
                                cbuf.Write(file);
                            }
                        }
                        

                        continue;
                        //throw new NotImplementedException();
                    }
                }
            }
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
            // with a new destination cr2wFile and a new parent CVariable if needed
            var copy = CR2WTypeManager.Create(this.REDType, this.REDName, context.DestinationFile, context.Parent, false);
            //copy.REDFlags = this.REDFlags;
            copy.IsSerialized = this.IsSerialized;

            // don't try to set children with reflection, it aint gonna work
            if (this is IArrayAccessor || this is IVariantAccessor)
                return copy;

            // copy all REDProperties and REDBuffers
            foreach (var item in GetEditableVariables())
            {
                if (!(item is CVariable cvar)) continue;
                context.Parent = copy;
                copy.TrySettingFastMemberAccessor(cvar.Copy(context));
            }

            return copy;
        }

        public virtual CVariable SetValue(object val)
        {
            if (val is CVariable cvar)
            {
                // set all REDProperties and REDBuffers
                foreach (IEditableVariable item in cvar.GetEditableVariables())
                {
                    if (item is CVariable citem)
                        this.TrySettingFastMemberAccessor(citem);
                }
            }

            return this;
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
        #endregion

        #region Abstract
        //public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        //{
        //    throw new NotImplementedException();
        //}




        #endregion

        #region Override
        public override string ToString()
        {
            // check first if there is a property called "Name"
            var dbg = this.accessor.GetMembers();
            foreach (var member in this.accessor.GetMembers())
            {
                if (member.Name == "Name")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.Name;
                    if (cnam != null)
                        return cnam.ToString();
                }
                if (member.Name == "InstanceName")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.InstanceName;
                    if (cnam != null)
                        return cnam.ToString();
                }
                if (member.Name == "AppearanceName")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.AppearanceName;
                    if (cnam != null)
                        return cnam.ToString();
                }
                if (member.Name == "Appearance")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.Appearance;
                    if (cnam != null)
                        return cnam.ToString();
                }
                if (member.Name == "ChildName")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.ChildName;
                    if (cnam != null)
                        return cnam.ToString();
                }
                if (member.Name == "OldName")
                {
                    dynamic dyn = this;
                    dynamic cnam = dyn.OldName;
                    if (cnam != null)
                        return cnam.ToString();
                }
            }

            return $"<{REDType}>{REDName}";
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

        //public virtual void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);


        //        if (GetEditableVariables() != null)
        //        {
        //            foreach (var v in GetEditableVariables())
        //            {
        //                v.SerializeToXml(xw);
        //            }
        //        }
        //        ser.WriteEndObject(xw);
        //    }
        //}
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
        
        /// <summary>
        /// Normalizes enum names with special characters.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="normalizeChar"></param>
        /// <returns></returns>
        public static string NormalizeName(string s, char normalizeChar = '_' )
        {
            var specialCharList = new[] {'.',' ', ':', '?', '/', '\'', '-', '(', ')', '[', ']'};
            var finalvalue = s;
            if (specialCharList.Any(s.Contains))
            {
                finalvalue = specialCharList
                    .Aggregate(finalvalue, (_, c) => _.Replace(c.ToString(),
                        normalizeChar.ToString()));
            }

            if (finalvalue.Length > 0 &&  char.IsDigit(finalvalue[0]))
                finalvalue = $"_{finalvalue}";
            finalvalue = finalvalue switch
            {
                "true" => $"_{finalvalue}",
                "false" => $"_{finalvalue}",
                _ => finalvalue
            };

            return finalvalue;
        }
        #endregion
    }
}
