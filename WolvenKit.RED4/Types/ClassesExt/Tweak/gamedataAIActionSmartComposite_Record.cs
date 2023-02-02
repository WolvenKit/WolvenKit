
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionSmartComposite_Record
	{
		[RED("conditionSuccessDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat ConditionSuccessDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("disableActionsLimit")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableActionsLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("failOnNodeActivationConditionFailure")]
		[REDProperty(IsIgnored = true)]
		public CBool FailOnNodeActivationConditionFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("gracefulInterruptionCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> GracefulInterruptionCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("gracefulInterruptionConditionCheckInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat GracefulInterruptionConditionCheckInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("nodes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Nodes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("repeat")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Repeat
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
