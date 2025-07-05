
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectAIData_Record
	{
		[RED("activationPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ActivationPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("allowDelayStatusEffectSignalIfSamePriorityExecuting")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowDelayStatusEffectSignalIfSamePriorityExecuting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("behaviorEventFlag")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BehaviorEventFlag
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("behaviorSignalResendDelay")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BehaviorSignalResendDelay
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("behaviorType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BehaviorType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("behaviourName")]
		[REDProperty(IsIgnored = true)]
		public CName BehaviourName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sensePreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SensePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("shouldDelayStatusEffectApplication")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldDelayStatusEffectApplication
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldProcessAIDataOnReapplication")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldProcessAIDataOnReapplication
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stimRangeMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat StimRangeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stimulis")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stimulis
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("updateSenses")]
		[REDProperty(IsIgnored = true)]
		public CBool UpdateSenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
