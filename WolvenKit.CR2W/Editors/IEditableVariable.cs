using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.Common;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Editors
{
    public interface IEditableVariable
    {
        string REDName { get; set; }
        string REDType { get; }
        string REDValue { get; }

        Guid InternalGuid { get; set; }
        IEditableVariable Parent { get; set; }
        bool IsSerialized { get; set; }

        CR2WFile cr2w { get; set; }


        Control GetEditor();
        List<IEditableVariable> GetEditableVariables();
        bool CanRemoveVariable(IEditableVariable child);
        CVariable CreateDefaultVariable();
        bool CanAddVariable(IEditableVariable newvar);
        void AddVariable(CVariable var);
        void RemoveVariable(IEditableVariable child);
        void SerializeToXml(XmlWriter xw);


    }
}