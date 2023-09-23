using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlatformDevice : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get => GetPropertyValue<CHandle<gameMovingPlatform>>();
			set => SetPropertyValue<CHandle<gameMovingPlatform>>(value);
		}

		[Ordinal(99)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("StartAudioEvent")] 
		public CName StartAudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("StopAudioEvent")] 
		public CName StopAudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(102)] 
		[RED("MovingVFX")] 
		public CName MovingVFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PlatformDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
