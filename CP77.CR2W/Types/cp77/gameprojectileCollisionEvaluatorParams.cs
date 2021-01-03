using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileCollisionEvaluatorParams : IScriptable
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("isPiercableSurface")] public CBool IsPiercableSurface { get; set; }
		[Ordinal(2)]  [RED("isTechPiercing")] public CBool IsTechPiercing { get; set; }
		[Ordinal(3)]  [RED("numBounces")] public CUInt32 NumBounces { get; set; }
		[Ordinal(4)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(5)]  [RED("projectilePenetration")] public CName ProjectilePenetration { get; set; }
		[Ordinal(6)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public gameprojectileCollisionEvaluatorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
