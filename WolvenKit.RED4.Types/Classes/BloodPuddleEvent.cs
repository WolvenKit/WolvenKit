using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BloodPuddleEvent : redEvent
	{
		private CName _slotName;
		private CBool _cyberBlood;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("cyberBlood")] 
		public CBool CyberBlood
		{
			get => GetProperty(ref _cyberBlood);
			set => SetProperty(ref _cyberBlood, value);
		}
	}
}
