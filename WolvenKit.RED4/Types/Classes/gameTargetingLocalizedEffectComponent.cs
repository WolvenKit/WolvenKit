using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTargetingLocalizedEffectComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("visibleTargetRange")] 
		public CFloat VisibleTargetRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTargetingLocalizedEffectComponent()
		{
			Name = "Component";
			StreamingDistance = 50.000000F;
			VisibleTargetRange = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
