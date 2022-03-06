
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionCover_Record
	{
		[RED("clearLOSDistanceTolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ClearLOSDistanceTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("commandCoverConditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CommandCoverConditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("coverExposureMethods")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CoverExposureMethods
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("delayExposedInCoverReset")]
		[REDProperty(IsIgnored = true)]
		public CFloat DelayExposedInCoverReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("exposedInCover")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ExposedInCover
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("exposureMethodPriority")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ExposureMethodPriority
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("insideCoverReselectionCooldown")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID InsideCoverReselectionCooldown
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("prioritizeBlindFireAfterHit")]
		[REDProperty(IsIgnored = true)]
		public CFloat PrioritizeBlindFireAfterHit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("setCoverExposureAnim")]
		[REDProperty(IsIgnored = true)]
		public CBool SetCoverExposureAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("setCurrentCover")]
		[REDProperty(IsIgnored = true)]
		public CBool SetCurrentCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("setDesiredCover")]
		[REDProperty(IsIgnored = true)]
		public CInt32 SetDesiredCover
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("setInitialCoverData")]
		[REDProperty(IsIgnored = true)]
		public CBool SetInitialCoverData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useGrenadeThrowMethods")]
		[REDProperty(IsIgnored = true)]
		public CBool UseGrenadeThrowMethods
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useLastAvailableExposureMethodsIfNoneAvailable")]
		[REDProperty(IsIgnored = true)]
		public CBool UseLastAvailableExposureMethodsIfNoneAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
