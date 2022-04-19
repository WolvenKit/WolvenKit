using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAnimationTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("animVariation")] 
		public CHandle<AIArgumentMapping> AnimVariation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataAIAction_Record> ActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIAction_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("animVariationValue")] 
		public CInt32 AnimVariationValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("phaseRecord")] 
		public CWeakHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionPhase_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionPhase_Record>>(value);
		}

		[Ordinal(6)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get => GetPropertyValue<CEnum<EAIActionPhase>>();
			set => SetPropertyValue<CEnum<EAIActionPhase>>(value);
		}

		[Ordinal(7)] 
		[RED("phaseActivationTime")] 
		public CFloat PhaseActivationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIAnimationTask()
		{
			AnimVariationValue = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
