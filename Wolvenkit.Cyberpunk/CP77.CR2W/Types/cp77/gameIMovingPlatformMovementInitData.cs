using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameIMovingPlatformMovementInitData : CVariable
	{
		[Ordinal(0)]  [RED("endNode")] public NodeRef EndNode { get; set; }
		[Ordinal(1)]  [RED("initType")] public CEnum<gameMovingPlatformMovementInitializationType> InitType { get; set; }
		[Ordinal(2)]  [RED("initValue")] public CFloat InitValue { get; set; }
		[Ordinal(3)]  [RED("startNode")] public NodeRef StartNode { get; set; }

		public gameIMovingPlatformMovementInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
