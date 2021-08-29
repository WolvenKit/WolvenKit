using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VRoomFeed : redEvent
	{
		private CBool _on;

		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get => GetProperty(ref _on);
			set => SetProperty(ref _on, value);
		}
	}
}
