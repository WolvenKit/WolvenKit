using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRegular1v1FinisherScenario : gameIFinisherScenario
	{
		[Ordinal(0)] 
		[RED("attackerWorkspot")] 
		public CResourceAsyncReference<workWorkspotResource> AttackerWorkspot
		{
			get => GetPropertyValue<CResourceAsyncReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceAsyncReference<workWorkspotResource>>(value);
		}

		[Ordinal(1)] 
		[RED("targetWorkspot")] 
		public CResourceAsyncReference<workWorkspotResource> TargetWorkspot
		{
			get => GetPropertyValue<CResourceAsyncReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceAsyncReference<workWorkspotResource>>(value);
		}

		[Ordinal(2)] 
		[RED("syncData")] 
		public CArray<gameFinisherSyncData> SyncData
		{
			get => GetPropertyValue<CArray<gameFinisherSyncData>>();
			set => SetPropertyValue<CArray<gameFinisherSyncData>>(value);
		}

		[Ordinal(3)] 
		[RED("targetPlaybackDelay")] 
		public CFloat TargetPlaybackDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("targetBlendTime")] 
		public CFloat TargetBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("attackerPlaybackDelay")] 
		public CFloat AttackerPlaybackDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("attackerBlendTime")] 
		public CFloat AttackerBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("pivotSettings")] 
		public CEnum<gameRegular1v1FinisherScenarioPivotSetting> PivotSettings
		{
			get => GetPropertyValue<CEnum<gameRegular1v1FinisherScenarioPivotSetting>>();
			set => SetPropertyValue<CEnum<gameRegular1v1FinisherScenarioPivotSetting>>(value);
		}

		[Ordinal(8)] 
		[RED("attackerIsMaster")] 
		public CBool AttackerIsMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("targetSlotNameToAttachAttackerWeaponLeft")] 
		public CName TargetSlotNameToAttachAttackerWeaponLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameRegular1v1FinisherScenario()
		{
			SyncData = new();
			TargetBlendTime = 0.500000F;
			AttackerBlendTime = 0.500000F;
			AttackerIsMaster = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
