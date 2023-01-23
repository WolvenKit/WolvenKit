
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionPhase_Record
	{
		[RED("animationDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnimationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("changeNPCState")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ChangeNPCState
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("completeActionWithFailureOnCondition")]
		[REDProperty(IsIgnored = true)]
		public CBool CompleteActionWithFailureOnCondition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("conditionSuccessDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat ConditionSuccessDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dynamicDuration")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DynamicDuration
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("movePolicy")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MovePolicy
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("notRepeatPhaseCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> NotRepeatPhaseCondition
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
		
		[RED("toNextPhaseCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ToNextPhaseCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("toNextPhaseConditionCheckInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat ToNextPhaseConditionCheckInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useDurationFromAnimSlot")]
		[REDProperty(IsIgnored = true)]
		public CBool UseDurationFromAnimSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
