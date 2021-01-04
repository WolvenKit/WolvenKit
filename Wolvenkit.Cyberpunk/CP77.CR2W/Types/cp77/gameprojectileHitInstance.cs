using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileHitInstance : CVariable
	{
		[Ordinal(0)]  [RED("forward")] public Vector4 Forward { get; set; }
		[Ordinal(1)]  [RED("hitObject")] public wCHandle<entEntity> HitObject { get; set; }
		[Ordinal(2)]  [RED("hitRepresentationResult")] public gameQueryResult HitRepresentationResult { get; set; }
		[Ordinal(3)]  [RED("hitWeakspot")] public wCHandle<gameWeakspotObject> HitWeakspot { get; set; }
		[Ordinal(4)]  [RED("numRicochetBounces")] public CInt32 NumRicochetBounces { get; set; }
		[Ordinal(5)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(6)]  [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(7)]  [RED("projectileSourcePosition")] public Vector4 ProjectileSourcePosition { get; set; }
		[Ordinal(8)]  [RED("traceResult")] public physicsTraceResult TraceResult { get; set; }
		[Ordinal(9)]  [RED("velocity")] public Vector4 Velocity { get; set; }

		public gameprojectileHitInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
