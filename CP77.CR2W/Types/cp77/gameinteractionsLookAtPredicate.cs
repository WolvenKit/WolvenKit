using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLookAtPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)]  [RED("stopOnTransparent")] public CBool StopOnTransparent { get; set; }
		[Ordinal(1)]  [RED("testTarget")] public CEnum<gameinteractionsELookAtTarget> TestTarget { get; set; }
		[Ordinal(2)]  [RED("testType")] public CEnum<gameinteractionsELookAtTest> TestType { get; set; }

		public gameinteractionsLookAtPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
