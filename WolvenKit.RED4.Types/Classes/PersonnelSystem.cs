using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PersonnelSystem : DeviceSystemBase
	{
		private CBool _enableE3QuickHacks;

		[Ordinal(97)] 
		[RED("EnableE3QuickHacks")] 
		public CBool EnableE3QuickHacks
		{
			get => GetProperty(ref _enableE3QuickHacks);
			set => SetProperty(ref _enableE3QuickHacks, value);
		}
	}
}
