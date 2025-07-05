using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalDistanceToLastKnownPosition : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("desiredDistanceArgument")] 
		public CHandle<AIArgumentMapping> DesiredDistanceArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("preventionSystem")] 
		public CHandle<PreventionSystem> PreventionSystem
		{
			get => GetPropertyValue<CHandle<PreventionSystem>>();
			set => SetPropertyValue<CHandle<PreventionSystem>>(value);
		}

		public MinimalDistanceToLastKnownPosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
