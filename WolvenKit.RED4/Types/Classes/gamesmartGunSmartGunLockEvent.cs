using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamesmartGunSmartGunLockEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("lockedOnByPlayer")] 
		public CBool LockedOnByPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamesmartGunSmartGunLockEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
