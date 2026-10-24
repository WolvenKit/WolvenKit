using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transitionSpeed")] 
		public CFloat TransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("followingSpeedFactorOverride")] 
		public CFloat FollowingSpeedFactorOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(5)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("calculatePositionInParentSpace")] 
		public CBool CalculatePositionInParentSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("additionalParts", 2)] 
		public CStatic<animLookAtPartRequest> AdditionalParts
		{
			get => GetPropertyValue<CStatic<animLookAtPartRequest>>();
			set => SetPropertyValue<CStatic<animLookAtPartRequest>>(value);
		}

		[Ordinal(10)] 
		[RED("invalid")] 
		public CBool Invalid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animLookAtRequest()
		{
			TransitionSpeed = 60.000000F;
			OutTransitionSpeed = 60.000000F;
			FollowingSpeedFactorOverride = -1.000000F;
			Limits = new animLookAtLimits();
			AdditionalParts = new(2);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
