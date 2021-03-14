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
			get
			{
				if (_sequence == null)
				{
					_sequence = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "sequence", cr2w, this);
				}
				return _sequence;
			}
			set
			{
				if (_sequence == value)
				{
					return;
				}
				_sequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("sequenceRecord")] 
		public wCHandle<gamedataAIActionSequence_Record> SequenceRecord
		{
			get
			{
				if (_sequenceRecord == null)
				{
					_sequenceRecord = (wCHandle<gamedataAIActionSequence_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionSequence_Record", "sequenceRecord", cr2w, this);
				}
				return _sequenceRecord;
			}
			set
			{
				if (_sequenceRecord == value)
				{
					return;
				}
				_sequenceRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("sequenceIterator")] 
		public CInt32 SequenceIterator
		{
			get
			{
				if (_sequenceIterator == null)
				{
					_sequenceIterator = (CInt32) CR2WTypeManager.Create("Int32", "sequenceIterator", cr2w, this);
				}
				return _sequenceIterator;
			}
			set
			{
				if (_sequenceIterator == value)
				{
					return;
				}
				_sequenceIterator = value;
				PropertySet(this);
			}
		}

		public TweakAIActionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
