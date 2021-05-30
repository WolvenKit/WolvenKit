using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W
{
    /// <summary>
    /// How a REDEngine entity is to be serialized
    /// </summary>
    public enum EStringTableMod
    {
        None,
        SkipType,
        SkipName,
        SkipNameAndType,
        TypeFirst
    }

    // Those where before tuples, passed between functions. Got sick of them and made structs.
    // Got lazy and did not rewrite elements in code, hence ItemN attributes. //FIXME unimportant
    public readonly struct SNameArg
    {
        public readonly EStringTableMod Mod;
        public readonly IEditableVariable Var;

        public SNameArg(EStringTableMod mod, IEditableVariable var)
        {
            Mod = mod;
            Var = var;
        }
    }

    // Those where before tuples, passed between functions. Got sick of them and made structs.
    // Got lazy and did not rewrite elements in code, hence ItemN attributes. //FIXME unimportant
    public readonly struct SImportEntry
    {
        public readonly string ClassName;
        public readonly string Path;
        public readonly EImportFlags Flags;

        public SImportEntry(string classname, string path, EImportFlags flags)
        {
            ClassName = classname;
            Path = path;
            Flags = flags;
        }
    }

    public static class Cr2wHelpers
    {
        public static (Dictionary<uint, string>, List<byte>, List<string>, List<SImportEntry>) GenerateStringtable(CR2WFile file)
        {
            Dictionary<uint, string> newstringtable = new Dictionary<uint, string>();

            // Get lists
            (var nameslist, List<SImportEntry> importslist) = GenerateStringtableInner(file);
            var stringlist = new List<string>(nameslist);

            foreach (var emb in file.Embedded)
            {
                if (importslist.All(source => source.Path != emb.ImportPath))
                {
                    importslist.Add(new SImportEntry("", emb.ImportPath, EImportFlags.HashedPath));
                }
            }

            foreach (var import in importslist)
            {
                if (!nameslist.Contains(import.ClassName))
                    nameslist.Add(import.ClassName);
                if (!stringlist.Contains(import.ClassName))
                    stringlist.Add(import.ClassName);
                if (!stringlist.Contains(import.Path))
                    stringlist.Add(import.Path);
            }


            // create new stringslist
            var newstrings = new List<byte>();
            foreach (var str in stringlist)
            {
                if (str != null)
                {
                    var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(str);
                    foreach (var b in bytes)
                    {
                        newstrings.Add(b);
                    }
                }
                newstrings.Add((byte)0);

            }

            // build new stringsDictionary
            var strings = newstrings.ToArray();
            var stringscount = strings.Length;

            StringBuilder sb = new StringBuilder();
            var tempstring = new List<byte>();
            uint offset = 0;
            for (uint i = 0; i < stringscount; i++)
            {
                byte b = strings[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    newstringtable.Add(offset, text);

                    sb.Clear();
                    tempstring.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                    tempstring.Add(b);
                }
            }

            return (newstringtable, newstrings, nameslist, importslist);
        }


        public static (List<string>, List<SImportEntry>) GenerateStringtableInner(CR2WFile file)
        {
            var dbg_trace = new List<string>();
            var newnameslist = new Dictionary<string, string> { { "", "" } };
            var newimportslist = new List<SImportEntry>();
            var newsoftlist = new List<SImportEntry>();
            var idlist = new HashSet<string>();

            foreach (var c in file.Chunks)
            {
                LoopWrapper(new SNameArg(EStringTableMod.SkipName, c.Data));
            }

            newimportslist.AddRange(newsoftlist);

            return (newnameslist.Values.ToList(), newimportslist);

            void LoopWrapper(SNameArg var)
            {
                if (idlist.Contains(var.Var.UniqueIdentifier))
                    return;

                //collection.Add(var);
                dbg_trace.Add($"{var.Var.UniqueIdentifier} - {var.Mod}");
                AddStrings(var);

                List<SNameArg> nextl = GetVariables(var.Var);
                if (nextl == null)
                    return;
                foreach (var l in nextl.Where(l => l.Var != null))
                {
                    LoopWrapper(l);
                }
            }

            List<SNameArg> GetVariables(IEditableVariable ivar)
            {
                //check for looping references
                if (idlist.Contains(ivar.UniqueIdentifier))
                    return null;
                else
                    idlist.Add(ivar.UniqueIdentifier);

                var returnedVariables = new List<SNameArg>();

                // if variable is generic type or some special case
                switch (ivar)
                {
                    case IArrayAccessor a:
                        switch (a)
                        {
                            case CArray<CName> cacn:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, a)); //???
                                break;
                            case CArray<CBool> cacb:
                            case CArray<CUInt16> cacu16:
                            case CArray<CInt16> caci16:
                            case CArray<CUInt32> cacu32:
                            case CArray<CInt32> caci32:
                            case CArray<CUInt64> cacu64:
                            case CArray<CInt64> caci64:
                                break;
                            default:
                                var elements = a.GetEditableVariables();
                                foreach (var item in elements)
                                    returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, item));
                                break;
                        }
                        break;
                    case IHandleAccessor h:
                        if (h.ChunkHandle)
                            if (h.Reference != null)
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, h.Reference.Data));
                        break;
                    case ISoftAccessor s:
                        break;
                    case IBufferVariantAccessor ivariant:
                        var mod = EStringTableMod.None;
                        returnedVariables.Add(new SNameArg(mod, ivariant.Variant));
                        break;
                    case CVariant cVariant:
                        returnedVariables.Add(new SNameArg(EStringTableMod.SkipName, cVariant.Variant));
                        break;
                    // check all other CVariables
                    case CVariable cvar:
                    {
                        // skip some custom buffers
                        if (cvar is gameCookedDeviceDataCompressed)
                        {
                            return null;
                        }


                        // add parent if not already in guidlist
                        // don't add array type parents, don't add IBufferVariantAccessor type parents
                        if (cvar.ParentVar != null
                            && !cvar.ParentVar.GetType().IsGenericType
                            && !(cvar.ParentVar is IBufferVariantAccessor)
                            && !idlist.Contains(cvar.ParentVar.UniqueIdentifier))
                        {
                            returnedVariables.Add(new SNameArg(EStringTableMod.None, cvar.ParentVar));
                        }

                        returnedVariables.AddRange(cvar.UnknownCVariables.Select(_ => new SNameArg(EStringTableMod.None, _)));
                        foreach (var item in cvar.GetREDMembers(true))
                        {
                            var o = cvar.accessor[cvar, item.Name];
                            if (o is CVariable cvar2)
                            {
                                if (cvar2.IsSerialized)
                                {
                                    if (REDReflection.GetREDAttribute(item) is REDBufferAttribute)
                                    {
                                        returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, cvar2));
                                    }
                                    else
                                    {
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, cvar2));
                                    }
                                }
                            }
                        }

                        // custom serialization
                        if (cvar is gameDeviceResourceData gdrd)
                        {
                            returnedVariables.AddRange(gdrd.CookedDeviceData
                                .Select(_ => _.ClassName)
                                .Select(_ => new SNameArg(EStringTableMod.SkipNameAndType, _)));
                        }

                        if (cvar is scnAnimName scnname && scnname.Unk1 != null)
                        {
                            returnedVariables.AddRange(scnname.Unk1
                                .Select(_ => new SNameArg(EStringTableMod.SkipNameAndType, _)));
                        }


                        break;
                    }
                    default:
                        break;
                }

                return returnedVariables;
            }

            void AddStrings(SNameArg tvar)
            {
                var var = tvar.Var;

                // skip some custom buffers
                if (var is gameCookedDeviceDataCompressed)
                {
                    return;
                }

                CheckVarNameAndTypes();

                switch (var)
                {
                    case IHandleAccessor handle:
                    {
                        if (!handle.ChunkHandle)
                        {
                            AddUniqueToTable(handle.ClassName);
                            var flags = EImportFlags.Default;

                            if ((var.Cr2wFile as CR2WFile).Embedded.Any(_ => _.ImportPath == handle.DepotPath))
                                flags = EImportFlags.Inplace;

                            var importtuple = new SImportEntry(handle.ClassName, handle.DepotPath, flags);
                            if (!newimportslist.Contains(importtuple))
                            {
                                newimportslist.Add(importtuple);
                            }
                        }

                        break;
                    }
                    case ISoftAccessor soft:
                    {
                        if (/*!(string.IsNullOrEmpty(s.ClassName) &&*/ !string.IsNullOrEmpty(soft.DepotPath))
                        {
                            //FIXME: calculate this properly
                            //var flags = EImportFlags.Default;
                            //if (s.REDType.StartsWith("raRef:"))
                            //    flags = EImportFlags.Soft;

                            var flags = soft.Flags;

                            var stuple = new SImportEntry("", soft.DepotPath, flags);
                            if (newsoftlist.All(_ => _.Path != soft.DepotPath))
                            {
                                newsoftlist.Add(stuple);
                            }
                        }

                        break;
                    }
                    case CName n:
                        AddUniqueToTable(n.Value);
                        break;
                    case IArrayAccessor when var is IBufferAccessor buffer:
                    {
                        foreach (var ivar in buffer.GetEditableVariables())
                        {
                            if (ivar is not IHandleAccessor ha)
                                continue;
                            if (ha.ChunkHandle)
                                continue;

                            AddUniqueToTable(ha.ClassName);
                            var flags = EImportFlags.Default;
                            if (ha.REDName == "template")
                                flags = EImportFlags.Template;
                            var importtuple = new SImportEntry(ha.ClassName, ha.DepotPath, flags);
                            if (!newimportslist.Contains(importtuple))
                            {
                                newimportslist.Add(importtuple);
                            }

                        }

                        break;
                    }
                    case IArrayAccessor:
                    {
                        CheckVarNameAndTypes();

                        if (var is CArray<CName> aa)
                        {
                            foreach (var element in aa)
                            {
                                AddUniqueToTable(element.Value);
                            }
                        }

                        break;
                    }
                    case IEnumAccessor { IsFlag: true } enumAccessor:
                    {
                        foreach (var enumstring in enumAccessor.EnumValueList)
                            AddUniqueToTable(enumstring);
                        break;
                    }
                    case IEnumAccessor enumAccessor:
                        AddUniqueToTable(enumAccessor.GetAttributeVal());
                        break;
                }


                void CheckVarNameAndTypes()
                {
                    switch (tvar.Mod)
                    {
                        case EStringTableMod.SkipType:
                            AddUniqueToTable(var.REDName);
                            break;
                        case EStringTableMod.SkipName:
                            AddUniqueToTable(var.REDType);
                            break;
                        case EStringTableMod.SkipNameAndType:
                            break;
                        case EStringTableMod.TypeFirst:
                            AddUniqueToTable(var.REDType);
                            AddUniqueToTable(var.REDName);
                            break;
                        case EStringTableMod.None:
                        default:
                            AddUniqueToTable(var.REDName);
                            AddUniqueToTable(var.REDType);
                            break;
                    }
                }
            }

            void AddUniqueToTable(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    // todo
                }
                else
                {

                    if (!newnameslist.ContainsKey(str))
                    {
                        // hack for CApexClothResource *sigh*
                        if (str == "apexMaterialNames")
                        {
                            if (!newnameslist.ContainsKey("apexBinaryAsset"))
                                newnameslist.Add("apexBinaryAsset", "apexBinaryAsset");
                            if (!newnameslist.ContainsKey("array: 95, 0, Uint8"))
                                newnameslist.Add("array:95,0,Uint8", "array:95,0,Uint8");
                        }

                        newnameslist.Add(str, str);
                    }
                }
            }
        }

    }
}
