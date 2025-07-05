
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAITargetCond_Record
	{
		[RED("attitude")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Attitude
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("invalidExpectation")]
		[REDProperty(IsIgnored = true)]
		public CInt32 InvalidExpectation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isActive")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsActive
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isAlive")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsAlive
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isCombatTargetVisibleFrom")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID IsCombatTargetVisibleFrom
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("isMoving")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsMoving
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isVisible")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsVisible
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxVisibilityToTargetDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxVisibilityToTargetDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minAccuracySharedValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinAccuracySharedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minAccuracyValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinAccuracyValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDetectionValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDetectionValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
