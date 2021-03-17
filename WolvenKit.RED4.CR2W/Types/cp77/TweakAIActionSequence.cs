using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSequence : TweakAIActionAbstract
	{
		private TweakDBID _sequence;
		private wCHandle<gamedataAIActionSequence_Record> _sequenceRecord;
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
		public wCHandle<gamedataAIActionSequence_Record> SequenceRecord
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

		public TweakAIActionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
