using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSelector : TweakAIActionAbstract
	{
		[Ordinal(0)]  [RED("nodeIterator")] public CInt32 NodeIterator { get; set; }
		[Ordinal(1)]  [RED("selector")] public TweakDBID Selector { get; set; }
		[Ordinal(2)]  [RED("selectorRecord")] public wCHandle<gamedataAIActionSelector_Record> SelectorRecord { get; set; }

		public TweakAIActionSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
