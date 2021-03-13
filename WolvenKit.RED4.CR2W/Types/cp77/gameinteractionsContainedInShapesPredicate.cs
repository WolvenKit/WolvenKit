using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsContainedInShapesPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] [RED("useCameraPosition")] public CBool UseCameraPosition { get; set; }

		public gameinteractionsContainedInShapesPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
