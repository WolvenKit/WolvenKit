using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPhotoModeCursorStateChangedEvent : redEvent
	{
		private CBool _cursorEnabled;

		[Ordinal(0)] 
		[RED("cursorEnabled")] 
		public CBool CursorEnabled
		{
			get => GetProperty(ref _cursorEnabled);
			set => SetProperty(ref _cursorEnabled, value);
		}
	}
}
