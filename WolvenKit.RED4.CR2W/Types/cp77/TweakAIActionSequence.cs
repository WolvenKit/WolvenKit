using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSequence : TweakAIActionAbstract
	{
		[Ordinal(27)] [RED("sequence")] public TweakDBID Sequence { get; set; }
		[Ordinal(28)] [RED("sequenceRecord")] public wCHandle<gamedataAIActionSequence_Record> SequenceRecord { get; set; }
		[Ordinal(29)] [RED("sequenceIterator")] public CInt32 SequenceIterator { get; set; }

		public TweakAIActionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
