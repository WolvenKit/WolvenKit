using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleStreamFeed : ActionBool
	{
		private CBool _vRoomFake;

		[Ordinal(25)] 
		[RED("vRoomFake")] 
		public CBool VRoomFake
		{
			get => GetProperty(ref _vRoomFake);
			set => SetProperty(ref _vRoomFake, value);
		}
	}
}
