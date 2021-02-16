using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkScreenProjection : IScriptable
	{
		[Ordinal(0)] [RED("distanceToCamera")] public CFloat DistanceToCamera { get; set; }
		[Ordinal(1)] [RED("previousPosition")] public Vector2 PreviousPosition { get; set; }
		[Ordinal(2)] [RED("currentPosition")] public Vector2 CurrentPosition { get; set; }
		[Ordinal(3)] [RED("uvPosition")] public Vector2 UvPosition { get; set; }

		public inkScreenProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
