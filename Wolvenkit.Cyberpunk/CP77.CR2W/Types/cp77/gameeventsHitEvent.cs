using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsHitEvent : redEvent
	{
		[Ordinal(0)]  [RED("attackComputed")] public CHandle<gameAttackComputed> AttackComputed { get; set; }
		[Ordinal(1)]  [RED("attackData")] public CHandle<gamedamageAttackData> AttackData { get; set; }
		[Ordinal(2)]  [RED("attackPentration")] public CFloat AttackPentration { get; set; }
		[Ordinal(3)]  [RED("hasPiercedTechSurface")] public CBool HasPiercedTechSurface { get; set; }
		[Ordinal(4)]  [RED("hitColliderTag")] public CName HitColliderTag { get; set; }
		[Ordinal(5)]  [RED("hitComponent")] public wCHandle<entIPlacedComponent> HitComponent { get; set; }
		[Ordinal(6)]  [RED("hitDirection")] public Vector4 HitDirection { get; set; }
		[Ordinal(7)]  [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(8)]  [RED("hitRepresentationResult")] public gameQueryResult HitRepresentationResult { get; set; }
		[Ordinal(9)]  [RED("projectionPipeline")] public CBool ProjectionPipeline { get; set; }
		[Ordinal(10)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(11)]  [RED("wasAliveBeforeHit")] public CBool WasAliveBeforeHit { get; set; }

		public gameeventsHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
