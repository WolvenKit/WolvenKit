using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficGlobalPathPosition : ISerializable
	{
		[Ordinal(0)] [RED("worldPosition")] public Vector3 WorldPosition { get; set; }
		[Ordinal(1)] [RED("pathIdx")] public CUInt32 PathIdx { get; set; }

		public worldTrafficGlobalPathPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
