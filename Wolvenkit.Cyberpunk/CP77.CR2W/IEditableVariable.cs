using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public interface IEditableVariable
    {
        string REDName { get; }
        string REDType { get; }
        [JsonIgnore]
        string REDValue { get; }
        [JsonIgnore]
        ushort REDFlags { get; }

        [JsonIgnore]
        Guid InternalGuid { get; set; }
        [JsonIgnore]
        IEditableVariable ParentVar { get; }
        [JsonIgnore]
        bool IsSerialized { get; set; }
        [JsonIgnore]
        int VarChunkIndex { get; set; }
        

        [JsonIgnore]
        CR2WFile cr2w { get; set; }



        [JsonIgnore]
        List<IEditableVariable> ChildrEditableVariables { get; }



        List<IEditableVariable> GetExistingVariables(bool includebuffers);
        List<IEditableVariable> GetEditableVariables();
        void SetREDName(string val);
        int LookUpChunkIndex();
        bool CanRemoveVariable(IEditableVariable child);
        bool CanAddVariable(IEditableVariable newvar);
        void AddVariable(CVariable var);
        bool RemoveVariable(IEditableVariable child);

        void Read(BinaryReader file, uint size);
        void Write(BinaryWriter file);
        CVariable Copy(CR2WCopyAction context);
    }
}