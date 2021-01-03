using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitResult : CVariable
	{
		[Ordinal(0)]  [RED("enterDistanceFromOriginSq")] public CFloat EnterDistanceFromOriginSq { get; set; }
		[Ordinal(1)]  [RED("hitPositionEnter")] public Vector4 HitPositionEnter { get; set; }
		[Ordinal(2)]  [RED("hitPositionExit")] public Vector4 HitPositionExit { get; set; }

		public gameHitResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
