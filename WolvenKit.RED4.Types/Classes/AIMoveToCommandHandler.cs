using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveToCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outIsDynamicMove")] 
		public CHandle<AIArgumentMapping> OutIsDynamicMove
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outMovementTarget")] 
		public CHandle<AIArgumentMapping> OutMovementTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outMovementTargetPos")] 
		public CHandle<AIArgumentMapping> OutMovementTargetPos
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outRotateEntityTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateEntityTowardsFacingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("outIgnoreNavigation")] 
		public CHandle<AIArgumentMapping> OutIgnoreNavigation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("outUseStart")] 
		public CHandle<AIArgumentMapping> OutUseStart
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("outUseStop")] 
		public CHandle<AIArgumentMapping> OutUseStop
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("outDesiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> OutDesiredDistanceFromTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("outFinishWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> OutFinishWhenDestinationReached
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIMoveToCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
