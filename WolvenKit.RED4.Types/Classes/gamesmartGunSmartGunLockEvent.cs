using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamesmartGunSmartGunLockEvent : redEvent
	{
		private CBool _locked;
		private CBool _lockedOnByPlayer;

		[Ordinal(0)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetProperty(ref _locked);
			set => SetProperty(ref _locked, value);
		}

		[Ordinal(1)] 
		[RED("lockedOnByPlayer")] 
		public CBool LockedOnByPlayer
		{
			get => GetProperty(ref _lockedOnByPlayer);
			set => SetProperty(ref _lockedOnByPlayer, value);
		}
	}
}
