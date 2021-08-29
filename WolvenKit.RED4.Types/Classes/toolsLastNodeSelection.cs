using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsLastNodeSelection : RedBaseClass
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
	}
}
