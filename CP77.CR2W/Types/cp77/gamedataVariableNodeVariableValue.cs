using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedataVariableNodeVariableValue : CVariable
	{
		[Ordinal(0)] [RED("node")] public CHandle<gamedataValueNode> Node { get; set; }
		[Ordinal(1)] [RED("deriveInfo")] public CEnum<gamedataVariableNodeVariableValueDeriveInfo> DeriveInfo { get; set; }

		public gamedataVariableNodeVariableValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
