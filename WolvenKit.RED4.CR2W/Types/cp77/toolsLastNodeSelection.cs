using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsLastNodeSelection : CVariable
	{
		private CString _editorName;
		private toolsEditorObjectIDPath _selectedNodeIDPath;

		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get => GetProperty(ref _editorName);
			set => SetProperty(ref _editorName, value);
		}

		[Ordinal(1)] 
		[RED("selectedNodeIDPath")] 
		public toolsEditorObjectIDPath SelectedNodeIDPath
		{
			get => GetProperty(ref _selectedNodeIDPath);
			set => SetProperty(ref _selectedNodeIDPath, value);
		}

		public toolsLastNodeSelection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
