using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLookAtPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] [RED("testTarget")] public CEnum<gameinteractionsELookAtTarget> TestTarget { get; set; }
		[Ordinal(1)] [RED("testType")] public CEnum<gameinteractionsELookAtTest> TestType { get; set; }
		[Ordinal(2)] [RED("stopOnTransparent")] public CBool StopOnTransparent { get; set; }

		public gameinteractionsLookAtPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
