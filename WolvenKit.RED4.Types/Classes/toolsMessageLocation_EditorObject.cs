using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessageLocation_EditorObject : toolsIMessageLocation
	{
		private toolsEditorObjectIDPath _path;

		[Ordinal(0)] 
		[RED("path")] 
		public toolsEditorObjectIDPath Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}
	}
}
