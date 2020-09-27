using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public interface IEditableVariable
    {
        string REDName { get; }
        string REDType { get; }
        string REDValue { get; }
        ushort REDFlags { get; }

        Guid InternalGuid { get; set; }
        IEditableVariable ParentVar { get; }
        bool IsSerialized { get; set; }
        int VarChunkIndex { get; set; }
        CR2WFile cr2w { get; set; }


        void SetREDName(string val);

        //Control GetEditor();
        List<IEditableVariable> GetEditableVariables();
        List<IEditableVariable> GetExistingVariables(bool includebuffers);

        bool CanRemoveVariable(IEditableVariable child);
        bool CanAddVariable(IEditableVariable newvar);
        void AddVariable(CVariable var);
        bool RemoveVariable(IEditableVariable child);

        //void SerializeToXml(XmlWriter xw);

        void Read(BinaryReader file, uint size);
        void Write(BinaryWriter file);
        CVariable Copy(CR2WCopyAction context);
    }
}