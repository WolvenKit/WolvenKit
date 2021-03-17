using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Nano_Wire : CrosshairGameController_Melee
	{
		private CHandle<inkanimProxy> _animEnterADS;
		private CBool _inAimDownSight;
		private CBool _isHoveringOfficer;
		private CBool _inChargedHold;
		private CHandle<inkanimProxy> _anim_EnterHipFire;
		private CHandle<inkanimProxy> _anim_HoverEnterEnemy;
		private CHandle<inkanimProxy> _anim_EnterStrongAttack;
		private CHandle<inkanimProxy> _anim_EnterThrowAttack;
		private CHandle<inkanimProxy> _anim_EnterEveryOtherAttack;
		private CHandle<inkanimProxy> _anim_EnterChargedHold;
		private CHandle<inkanimProxy> _anim_HoverExitEnemy;

		[Ordinal(33)] 
		[RED("animEnterADS")] 
		public CHandle<inkanimProxy> AnimEnterADS
		{
			get => GetProperty(ref _animEnterADS);
			set => SetProperty(ref _animEnterADS, value);
		}

		[Ordinal(34)] 
		[RED("inAimDownSight")] 
		public CBool InAimDownSight
		{
			get => GetProperty(ref _inAimDownSight);
			set => SetProperty(ref _inAimDownSight, value);
		}

		[Ordinal(35)] 
		[RED("isHoveringOfficer")] 
		public CBool IsHoveringOfficer
		{
			get => GetProperty(ref _isHoveringOfficer);
			set => SetProperty(ref _isHoveringOfficer, value);
		}

		[Ordinal(36)] 
		[RED("inChargedHold")] 
		public CBool InChargedHold
		{
			get => GetProperty(ref _inChargedHold);
			set => SetProperty(ref _inChargedHold, value);
		}

		[Ordinal(37)] 
		[RED("anim_EnterHipFire")] 
		public CHandle<inkanimProxy> Anim_EnterHipFire
		{
			get => GetProperty(ref _anim_EnterHipFire);
			set => SetProperty(ref _anim_EnterHipFire, value);
		}

		[Ordinal(38)] 
		[RED("anim_HoverEnterEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverEnterEnemy
		{
			get => GetProperty(ref _anim_HoverEnterEnemy);
			set => SetProperty(ref _anim_HoverEnterEnemy, value);
		}

		[Ordinal(39)] 
		[RED("anim_EnterStrongAttack")] 
		public CHandle<inkanimProxy> Anim_EnterStrongAttack
		{
			get => GetProperty(ref _anim_EnterStrongAttack);
			set => SetProperty(ref _anim_EnterStrongAttack, value);
		}

		[Ordinal(40)] 
		[RED("anim_EnterThrowAttack")] 
		public CHandle<inkanimProxy> Anim_EnterThrowAttack
		{
			get => GetProperty(ref _anim_EnterThrowAttack);
			set => SetProperty(ref _anim_EnterThrowAttack, value);
		}

		[Ordinal(41)] 
		[RED("anim_EnterEveryOtherAttack")] 
		public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack
		{
			get => GetProperty(ref _anim_EnterEveryOtherAttack);
			set => SetProperty(ref _anim_EnterEveryOtherAttack, value);
		}

		[Ordinal(42)] 
		[RED("anim_EnterChargedHold")] 
		public CHandle<inkanimProxy> Anim_EnterChargedHold
		{
			get => GetProperty(ref _anim_EnterChargedHold);
			set => SetProperty(ref _anim_EnterChargedHold, value);
		}

		[Ordinal(43)] 
		[RED("anim_HoverExitEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverExitEnemy
		{
			get => GetProperty(ref _anim_HoverExitEnemy);
			set => SetProperty(ref _anim_HoverExitEnemy, value);
		}

		public Crosshair_Melee_Nano_Wire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
