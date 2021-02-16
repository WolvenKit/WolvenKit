using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCookedDeviceData : CVariable
	{
		[Ordinal(0)] [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)] [RED("parents")] public CArray<CUInt64> Parents { get; set; }
		[Ordinal(2)] [RED("children")] public CArray<CUInt64> Children { get; set; }
		[Ordinal(3)] [RED("nodePosition")] public Vector3 NodePosition { get; set; }

		public gameCookedDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
