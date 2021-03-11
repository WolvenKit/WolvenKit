using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using FastMember;
using Newtonsoft.Json;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Model.Cr2w
{
    [Editor(typeof(IExpandableObjectEditor), typeof(IPropertyEditorBase))]
    public interface IEditableVariable : IEditorBindable
    {
        [Browsable(false)] string REDName { get; }
        [Browsable(false)] string REDType { get; }
        [JsonIgnore] [Browsable(false)] string REDValue { get; }
        [JsonIgnore] [Browsable(false)] ushort REDFlags { get; }

        [JsonIgnore] [Browsable(false)] string UniqueIdentifier { get; }

        [JsonIgnore] [Browsable(false)] IEditableVariable ParentVar { get; }
        
        [JsonIgnore] [Browsable(false)] int VarChunkIndex { get; set; }
        

        

        [Browsable(false)] public TypeAccessor accessor { get; }

        [JsonIgnore] [Browsable(false)] List<IEditableVariable> ChildrEditableVariables { get; }



        [Browsable(false)] List<IEditableVariable> GetExistingVariables(bool includebuffers);
        [Browsable(false)] List<IEditableVariable> GetEditableVariables();

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
