
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICoverCond_Record
	{
		[RED("checkChosenExposureMethod")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CheckChosenExposureMethod
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("checkIfCoverTransitionRequired")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckIfCoverTransitionRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cover")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Cover
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("coverExposureMethods")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CoverExposureMethods
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("coverType")]
		[REDProperty(IsIgnored = true)]
		public CInt32 CoverType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("desiredCover")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DesiredCover
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("desiredCoverChanged")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DesiredCoverChanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hasAnyLastAvailableExposureMethods")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HasAnyLastAvailableExposureMethods
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isOwnerCrouching")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsOwnerCrouching
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isOwnerExposed")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsOwnerExposed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isProtectingHorizontallyAgainstTarget")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsProtectingHorizontallyAgainstTarget
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxCoverToTargetAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxCoverToTargetAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minCoverHealth")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinCoverHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("owner")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Owner
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("predictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PredictionTime
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
