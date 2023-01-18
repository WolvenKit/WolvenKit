using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveOnSplineCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outRotateTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateTowardsFacingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("outSnapToTerrain")] 
		public CHandle<AIArgumentMapping> OutSnapToTerrain
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIMoveOnSplineCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
