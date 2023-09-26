using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TweakAIActionSequence : TweakAIActionAbstract
	{
		[Ordinal(37)] 
		[RED("sequence")] 
		public TweakDBID Sequence
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(38)] 
		[RED("sequenceRecord")] 
		public CWeakHandle<gamedataAIActionSequence_Record> SequenceRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionSequence_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionSequence_Record>>(value);
		}

		[Ordinal(39)] 
		[RED("sequenceIterator")] 
		public CInt32 SequenceIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TweakAIActionSequence()
		{
			LookatEvents = new();
			GeneralSubActionsResults = new(8);
			PhaseSubActionsResults = new(8);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
