using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Nano_Wire : CrosshairGameController_Melee
	{
		[Ordinal(0)]  [RED("animEnterADS")] public CHandle<inkanimProxy> AnimEnterADS { get; set; }
		[Ordinal(1)]  [RED("anim_EnterChargedHold")] public CHandle<inkanimProxy> Anim_EnterChargedHold { get; set; }
		[Ordinal(2)]  [RED("anim_EnterEveryOtherAttack")] public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack { get; set; }
		[Ordinal(3)]  [RED("anim_EnterHipFire")] public CHandle<inkanimProxy> Anim_EnterHipFire { get; set; }
		[Ordinal(4)]  [RED("anim_EnterStrongAttack")] public CHandle<inkanimProxy> Anim_EnterStrongAttack { get; set; }
		[Ordinal(5)]  [RED("anim_EnterThrowAttack")] public CHandle<inkanimProxy> Anim_EnterThrowAttack { get; set; }
		[Ordinal(6)]  [RED("anim_HoverEnterEnemy")] public CHandle<inkanimProxy> Anim_HoverEnterEnemy { get; set; }
		[Ordinal(7)]  [RED("anim_HoverExitEnemy")] public CHandle<inkanimProxy> Anim_HoverExitEnemy { get; set; }
		[Ordinal(8)]  [RED("inAimDownSight")] public CBool InAimDownSight { get; set; }
		[Ordinal(9)]  [RED("inChargedHold")] public CBool InChargedHold { get; set; }
		[Ordinal(10)]  [RED("isHoveringOfficer")] public CBool IsHoveringOfficer { get; set; }

		public Crosshair_Melee_Nano_Wire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
