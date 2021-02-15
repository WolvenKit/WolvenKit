using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameShapeData : CVariable
	{
		[Ordinal(0)] [RED("result")] public gameHitResult Result { get; set; }
		[Ordinal(1)] [RED("userData")] public CHandle<gameHitShapeUserData> UserData { get; set; }
		[Ordinal(2)] [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(3)] [RED("hitShapeName")] public CName HitShapeName { get; set; }

		public gameShapeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
