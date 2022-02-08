using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceBraindanceCameraToggle : redEvent
	{
		[Ordinal(0)] 
		[RED("editorState")] 
		public CBool EditorState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
