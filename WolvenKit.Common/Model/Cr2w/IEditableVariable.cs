using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using FastMember;
using Newtonsoft.Json;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Model.Cr2w
{
    [Editor(typeof(IExpandableObjectEditor), typeof(IPropertyEditorBase))]
    public interface IEditableVariable : IEditorBindable
    {
        #region Properties

        [Browsable(false)] public TypeAccessor accessor { get; }
        [JsonIgnore] [Browsable(false)] List<IEditableVariable> ChildrEditableVariables { get; }
        [JsonIgnore] [Browsable(false)] IWolvenkitFile Cr2wFile { get; set; }
        [JsonIgnore] [Browsable(false)] bool IsSerialized { get; set; }
        [JsonIgnore] [Browsable(false)] IEditableVariable ParentVar { get; }
        [JsonIgnore] [Browsable(false)] ushort REDFlags { get; }
        [Browsable(false)] string REDName { get; }
        [Browsable(false)] string REDType { get; }
        [JsonIgnore] [Browsable(false)] string REDValue { get; }
        [JsonIgnore] [Browsable(false)] string UniqueIdentifier { get; }
        [JsonIgnore] [Browsable(false)] int VarChunkIndex { get; set; }

        #endregion Properties

        #region Methods

        void AddVariable(IEditableVariable var);

        bool CanAddVariable(IEditableVariable newvar);

        bool CanRemoveVariable(IEditableVariable child);

        IEditableVariable Copy(ICR2WCopyAction context);

        [Browsable(false)] List<IEditableVariable> GetEditableVariables();

        [Browsable(false)] List<IEditableVariable> GetExistingVariables(bool includebuffers);

        int LookUpChunkIndex();

        void Read(BinaryReader file, uint size);

        bool RemoveVariable(IEditableVariable child);

        void SetREDName(string val);

        void Write(BinaryWriter file);

        #endregion Methods
    }
}
