using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPhotoModeCursorStateChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("cursorEnabled")] 
		public CBool CursorEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
