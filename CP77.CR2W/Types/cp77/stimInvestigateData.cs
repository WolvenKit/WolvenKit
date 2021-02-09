using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class stimInvestigateData : CVariable
	{
		[Ordinal(0)]  [RED("investigationSpots")] public CArray<Vector4> InvestigationSpots { get; set; }
		[Ordinal(1)]  [RED("investigateController")] public CBool InvestigateController { get; set; }
		[Ordinal(2)]  [RED("controllerEntity")] public wCHandle<entEntity> ControllerEntity { get; set; }
		[Ordinal(3)]  [RED("mainDeviceEntity")] public wCHandle<entEntity> MainDeviceEntity { get; set; }
		[Ordinal(4)]  [RED("distrationPoint")] public Vector4 DistrationPoint { get; set; }
		[Ordinal(5)]  [RED("attackInstigator")] public wCHandle<entEntity> AttackInstigator { get; set; }
		[Ordinal(6)]  [RED("attackInstigatorPosition")] public Vector4 AttackInstigatorPosition { get; set; }
		[Ordinal(7)]  [RED("revealsInstigatorPosition")] public CBool RevealsInstigatorPosition { get; set; }
		[Ordinal(8)]  [RED("illegalAction")] public CBool IllegalAction { get; set; }
		[Ordinal(9)]  [RED("fearPhase")] public CInt32 FearPhase { get; set; }
		[Ordinal(10)]  [RED("skipReactionDelay")] public CBool SkipReactionDelay { get; set; }
		[Ordinal(11)]  [RED("skipInitialAnimation")] public CBool SkipInitialAnimation { get; set; }

		public stimInvestigateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
