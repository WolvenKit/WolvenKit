using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ManageSirensAndLightsInPoliceCar : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("turnOnLights")] 
		public CHandle<AIArgumentMapping> TurnOnLights
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("turnOnSirens")] 
		public CHandle<AIArgumentMapping> TurnOnSirens
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public ManageSirensAndLightsInPoliceCar()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
