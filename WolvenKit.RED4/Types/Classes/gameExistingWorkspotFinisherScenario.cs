using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameExistingWorkspotFinisherScenario : gameIFinisherScenario
	{
		[Ordinal(0)] 
		[RED("playerWorkspot")] 
		public CResourceAsyncReference<workWorkspotResource> PlayerWorkspot
		{
			get => GetPropertyValue<CResourceAsyncReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceAsyncReference<workWorkspotResource>>(value);
		}

		[Ordinal(1)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("playbackDelay")] 
		public CFloat PlaybackDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameExistingWorkspotFinisherScenario()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
