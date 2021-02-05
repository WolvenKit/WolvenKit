using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Nano_Wire : CrosshairGameController_Melee
	{
		[Ordinal(31)]  [RED("animEnterADS")] public CHandle<inkanimProxy> AnimEnterADS { get; set; }
		[Ordinal(32)]  [RED("inAimDownSight")] public CBool InAimDownSight { get; set; }
		[Ordinal(33)]  [RED("isHoveringOfficer")] public CBool IsHoveringOfficer { get; set; }
		[Ordinal(34)]  [RED("inChargedHold")] public CBool InChargedHold { get; set; }
		[Ordinal(35)]  [RED("anim_EnterHipFire")] public CHandle<inkanimProxy> Anim_EnterHipFire { get; set; }
		[Ordinal(36)]  [RED("anim_HoverEnterEnemy")] public CHandle<inkanimProxy> Anim_HoverEnterEnemy { get; set; }
		[Ordinal(37)]  [RED("anim_EnterStrongAttack")] public CHandle<inkanimProxy> Anim_EnterStrongAttack { get; set; }
		[Ordinal(38)]  [RED("anim_EnterThrowAttack")] public CHandle<inkanimProxy> Anim_EnterThrowAttack { get; set; }
		[Ordinal(39)]  [RED("anim_EnterEveryOtherAttack")] public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack { get; set; }
		[Ordinal(40)]  [RED("anim_EnterChargedHold")] public CHandle<inkanimProxy> Anim_EnterChargedHold { get; set; }
		[Ordinal(41)]  [RED("anim_HoverExitEnemy")] public CHandle<inkanimProxy> Anim_HoverExitEnemy { get; set; }

		public Crosshair_Melee_Nano_Wire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
