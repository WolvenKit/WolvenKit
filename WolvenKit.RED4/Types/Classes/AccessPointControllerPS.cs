using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AccessPointControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("rewardNotificationIcons")] 
		public CArray<CString> RewardNotificationIcons
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(106)] 
		[RED("rewardNotificationString")] 
		public CString RewardNotificationString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(107)] 
		[RED("accessPointSkillChecks")] 
		public CHandle<HackingContainer> AccessPointSkillChecks
		{
			get => GetPropertyValue<CHandle<HackingContainer>>();
			set => SetPropertyValue<CHandle<HackingContainer>>(value);
		}

		[Ordinal(108)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("moneyAwarded")] 
		public CBool MoneyAwarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("isVirtual")] 
		public CBool IsVirtual
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("pingedSquads")] 
		public CArray<CName> PingedSquads
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AccessPointControllerPS()
		{
			RevealDevicesGrid = false;
			HasNetworkBackdoor = true;
			DeviceName = "LocKey#138";
			TweakDBRecord = "Devices.AccessPoint";
			TweakDBDescriptionRecord = 134736165949;
			HasPersonalLinkSlot = true;
			ShouldScannerShowNetwork = false;
			RewardNotificationIcons = new();
			PingedSquads = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
