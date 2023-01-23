using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIBackgroundCombatStep : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<EAIBackgroundCombatStep> Type
		{
			get => GetPropertyValue<CEnum<EAIBackgroundCombatStep>>();
			set => SetPropertyValue<CEnum<EAIBackgroundCombatStep>>(value);
		}

		[Ordinal(3)] 
		[RED("argument")] 
		public gameEntityReference Argument
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("exposureMethod")] 
		public CEnum<AICoverExposureMethod> ExposureMethod
		{
			get => GetPropertyValue<CEnum<AICoverExposureMethod>>();
			set => SetPropertyValue<CEnum<AICoverExposureMethod>>(value);
		}

		public AIBackgroundCombatStep()
		{
			Argument = new() { Names = new() };
			ExposureMethod = Enums.AICoverExposureMethod.Stand_Up;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
