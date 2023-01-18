
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLookAtPreset_Record
	{
		[RED("attachLeftHandtoRightHand")]
		[REDProperty(IsIgnored = true)]
		public CBool AttachLeftHandtoRightHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("attachRightHandtoLeftHand")]
		[REDProperty(IsIgnored = true)]
		public CBool AttachRightHandtoLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("backLimitDegrees")]
		[REDProperty(IsIgnored = true)]
		public CFloat BackLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bodyPart")]
		[REDProperty(IsIgnored = true)]
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("calculatePositionInParentSpace")]
		[REDProperty(IsIgnored = true)]
		public CBool CalculatePositionInParentSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("followingSpeedFactorOverride")]
		[REDProperty(IsIgnored = true)]
		public CFloat FollowingSpeedFactorOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hardLimitDegrees")]
		[REDProperty(IsIgnored = true)]
		public CFloat HardLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hardLimitDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat HardLimitDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hasOutTransition")]
		[REDProperty(IsIgnored = true)]
		public CBool HasOutTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("lookAtParts")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LookAtParts
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("mode")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Mode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("outTransitionSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat OutTransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("softLimitDegrees")]
		[REDProperty(IsIgnored = true)]
		public CFloat SoftLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("suppress")]
		[REDProperty(IsIgnored = true)]
		public CFloat Suppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("transitionSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
