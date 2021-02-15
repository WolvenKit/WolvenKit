using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameGrenadeThrowQueryParams : CVariable
	{
		[Ordinal(0)] [RED("requester")] public wCHandle<gameObject> Requester { get; set; }
		[Ordinal(1)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)] [RED("targetPositionProvider")] public CHandle<entIPositionProvider> TargetPositionProvider { get; set; }
		[Ordinal(3)] [RED("minRadius")] public CFloat MinRadius { get; set; }
		[Ordinal(4)] [RED("maxRadius")] public CFloat MaxRadius { get; set; }
		[Ordinal(5)] [RED("friendlyAvoidanceRadius")] public CFloat FriendlyAvoidanceRadius { get; set; }
		[Ordinal(6)] [RED("throwAngleDegrees")] public CFloat ThrowAngleDegrees { get; set; }
		[Ordinal(7)] [RED("gravitySimulation")] public CFloat GravitySimulation { get; set; }
		[Ordinal(8)] [RED("minTargetAngleDegrees")] public CFloat MinTargetAngleDegrees { get; set; }
		[Ordinal(9)] [RED("maxTargetAngleDegrees")] public CFloat MaxTargetAngleDegrees { get; set; }

		public gameGrenadeThrowQueryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
