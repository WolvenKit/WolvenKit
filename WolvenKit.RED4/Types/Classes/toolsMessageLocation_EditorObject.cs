using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageLocation_EditorObject : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("path")] 
		public toolsEditorObjectIDPath Path
		{
			get => GetPropertyValue<toolsEditorObjectIDPath>();
			set => SetPropertyValue<toolsEditorObjectIDPath>(value);
		}

		public toolsMessageLocation_EditorObject()
		{
			Path = new toolsEditorObjectIDPath { Elements = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
