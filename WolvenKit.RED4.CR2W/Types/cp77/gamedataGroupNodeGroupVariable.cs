using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataGroupNodeGroupVariable : CVariable
	{
		[Ordinal(0)] [RED("node")] public CHandle<gamedataVariableNode> Node { get; set; }
		[Ordinal(1)] [RED("deriveInfo")] public CEnum<gamedataGroupNodeGroupVariableDeriveInfo> DeriveInfo { get; set; }
		[Ordinal(2)] [RED("flattened")] public CBool Flattened { get; set; }
		[Ordinal(3)] [RED("flatId")] public TweakDBID FlatId { get; set; }

		public gamedataGroupNodeGroupVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
