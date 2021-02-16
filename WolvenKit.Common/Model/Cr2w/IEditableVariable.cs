using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using FastMember;
using Newtonsoft.Json;

namespace WolvenKit.Common.Model.Cr2w
{
    public interface IEditableVariable
    {
        string REDName { get; }
        string REDType { get; }
        [JsonIgnore]
        string REDValue { get; }
        [JsonIgnore]
        ushort REDFlags { get; }

        [JsonIgnore] string UniqueIdentifier { get; }

        [JsonIgnore]
        IEditableVariable ParentVar { get; }
        [JsonIgnore]
        bool IsSerialized { get; set; }
        [JsonIgnore]
        int VarChunkIndex { get; set; }
        

        [JsonIgnore]
        IWolvenkitFile Cr2wFile { get; set; }

        public TypeAccessor accessor { get; }

        [JsonIgnore]
        List<IEditableVariable> ChildrEditableVariables { get; }



        List<IEditableVariable> GetExistingVariables(bool includebuffers);
        List<IEditableVariable> GetEditableVariables();
        void SetREDName(string val);
        int LookUpChunkIndex();
        bool CanRemoveVariable(IEditableVariable child);
        bool CanAddVariable(IEditableVariable newvar);
        void AddVariable(IEditableVariable var);
        bool RemoveVariable(IEditableVariable child);

        void Read(BinaryReader file, uint size);
        void Write(BinaryWriter file);
        IEditableVariable Copy(ICR2WCopyAction context);


    }
}