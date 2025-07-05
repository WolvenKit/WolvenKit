using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFinisherSyncData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameFinisherSyncData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
