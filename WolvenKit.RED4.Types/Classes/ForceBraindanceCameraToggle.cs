using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceBraindanceCameraToggle : redEvent
	{
		private CBool _editorState;

		[Ordinal(0)] 
		[RED("editorState")] 
		public CBool EditorState
		{
			get => GetProperty(ref _editorState);
			set => SetProperty(ref _editorState, value);
		}
	}
}
