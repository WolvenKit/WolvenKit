using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameShapeData : CVariable
	{
		[Ordinal(0)]  [RED("hitShapeName")] public CName HitShapeName { get; set; }
		[Ordinal(1)]  [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(2)]  [RED("result")] public gameHitResult Result { get; set; }
		[Ordinal(3)]  [RED("userData")] public CHandle<gameHitShapeUserData> UserData { get; set; }

		public gameShapeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
