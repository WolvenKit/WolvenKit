using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSequence : TweakAIActionAbstract
	{
		[Ordinal(0)]  [RED("sequence")] public TweakDBID Sequence { get; set; }
		[Ordinal(1)]  [RED("sequenceIterator")] public CInt32 SequenceIterator { get; set; }
		[Ordinal(2)]  [RED("sequenceRecord")] public wCHandle<gamedataAIActionSequence_Record> SequenceRecord { get; set; }

		public TweakAIActionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
