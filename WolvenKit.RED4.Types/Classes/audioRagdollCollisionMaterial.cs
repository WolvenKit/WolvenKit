using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRagdollCollisionMaterial : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("lightCollisionEventName")] 
		public CName LightCollisionEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("heavyCollisionEventName")] 
		public CName HeavyCollisionEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("dismemberedLimbCollisionEventName")] 
		public CName DismemberedLimbCollisionEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioRagdollCollisionMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
