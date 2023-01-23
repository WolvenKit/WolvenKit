using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HasPositionFarFromThreat : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("minPathLength")] 
		public CFloat MinPathLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HasPositionFarFromThreat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
