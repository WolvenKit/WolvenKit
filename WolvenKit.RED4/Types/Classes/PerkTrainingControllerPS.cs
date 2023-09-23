using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkTrainingControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("interactionTweakDBID")] 
		public TweakDBID InteractionTweakDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(108)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(109)] 
		[RED("jackinStartTime")] 
		public CFloat JackinStartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("isCorePerk")] 
		public CBool IsCorePerk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("perkGranted")] 
		public CBool PerkGranted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("wasDetected")] 
		public CBool WasDetected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PerkTrainingControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
