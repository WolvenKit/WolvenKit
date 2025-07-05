using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsLastNodeSelection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("selectedNodeIDPath")] 
		public toolsEditorObjectIDPath SelectedNodeIDPath
		{
			get => GetPropertyValue<toolsEditorObjectIDPath>();
			set => SetPropertyValue<toolsEditorObjectIDPath>(value);
		}

		public toolsLastNodeSelection()
		{
			SelectedNodeIDPath = new toolsEditorObjectIDPath { Elements = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
