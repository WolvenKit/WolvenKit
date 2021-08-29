using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionSequence : TweakAIActionAbstract
	{
		private TweakDBID _sequence;
		private CWeakHandle<gamedataAIActionSequence_Record> _sequenceRecord;
		private CInt32 _sequenceIterator;

		[Ordinal(27)] 
		[RED("sequence")] 
		public TweakDBID Sequence
		{
			get => GetProperty(ref _sequence);
			set => SetProperty(ref _sequence, value);
		}

		[Ordinal(28)] 
		[RED("sequenceRecord")] 
		public CWeakHandle<gamedataAIActionSequence_Record> SequenceRecord
		{
			get => GetProperty(ref _sequenceRecord);
			set => SetProperty(ref _sequenceRecord, value);
		}

		[Ordinal(29)] 
		[RED("sequenceIterator")] 
		public CInt32 SequenceIterator
		{
			get => GetProperty(ref _sequenceIterator);
			set => SetProperty(ref _sequenceIterator, value);
		}
	}
}
