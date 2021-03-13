using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCMetanodeIfDefinition : LibTreeCMetanodeDefinition
	{
		[Ordinal(0)] [RED("ifCondition")] public LibTreeDefBool IfCondition { get; set; }
		[Ordinal(1)] [RED("ifBranch")] public CHandle<LibTreeINodeDefinition> IfBranch { get; set; }
		[Ordinal(2)] [RED("elseBranch")] public CHandle<LibTreeINodeDefinition> ElseBranch { get; set; }

		public LibTreeCMetanodeIfDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
