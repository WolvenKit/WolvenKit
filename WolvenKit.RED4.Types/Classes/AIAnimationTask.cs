using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAnimationTask : AIbehaviortaskScript
	{
		private TweakDBID _record;
		private CHandle<AIArgumentMapping> _animVariation;
		private CWeakHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;
		private CInt32 _animVariationValue;
		private CWeakHandle<gamedataAIActionPhase_Record> _phaseRecord;
		private CEnum<EAIActionPhase> _actionPhase;
		private CFloat _phaseActivationTime;
		private CFloat _phaseDuration;

		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(1)] 
		[RED("animVariation")] 
		public CHandle<AIArgumentMapping> AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(2)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataAIAction_Record> ActionRecord
		{
			get => GetProperty(ref _actionRecord);
			set => SetProperty(ref _actionRecord, value);
		}

		[Ordinal(3)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetProperty(ref _actionDebugName);
			set => SetProperty(ref _actionDebugName, value);
		}

		[Ordinal(4)] 
		[RED("animVariationValue")] 
		public CInt32 AnimVariationValue
		{
			get => GetProperty(ref _animVariationValue);
			set => SetProperty(ref _animVariationValue, value);
		}

		[Ordinal(5)] 
		[RED("phaseRecord")] 
		public CWeakHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get => GetProperty(ref _phaseRecord);
			set => SetProperty(ref _phaseRecord, value);
		}

		[Ordinal(6)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get => GetProperty(ref _actionPhase);
			set => SetProperty(ref _actionPhase, value);
		}

		[Ordinal(7)] 
		[RED("phaseActivationTime")] 
		public CFloat PhaseActivationTime
		{
			get => GetProperty(ref _phaseActivationTime);
			set => SetProperty(ref _phaseActivationTime, value);
		}

		[Ordinal(8)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get => GetProperty(ref _phaseDuration);
			set => SetProperty(ref _phaseDuration, value);
		}

		public AIAnimationTask()
		{
			_animVariationValue = -1;
		}
	}
}
