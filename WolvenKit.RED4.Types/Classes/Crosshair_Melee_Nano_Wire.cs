using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Melee_Nano_Wire : CrosshairGameController_Melee
	{
		[Ordinal(32)] 
		[RED("animEnterADS")] 
		public CHandle<inkanimProxy> AnimEnterADS
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(33)] 
		[RED("inAimDownSight")] 
		public CBool InAimDownSight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isHoveringOfficer")] 
		public CBool IsHoveringOfficer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("inChargedHold")] 
		public CBool InChargedHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("anim_EnterHipFire")] 
		public CHandle<inkanimProxy> Anim_EnterHipFire
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(37)] 
		[RED("anim_HoverEnterEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverEnterEnemy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("anim_EnterStrongAttack")] 
		public CHandle<inkanimProxy> Anim_EnterStrongAttack
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("anim_EnterThrowAttack")] 
		public CHandle<inkanimProxy> Anim_EnterThrowAttack
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("anim_EnterEveryOtherAttack")] 
		public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("anim_EnterChargedHold")] 
		public CHandle<inkanimProxy> Anim_EnterChargedHold
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("anim_HoverExitEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverExitEnemy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public Crosshair_Melee_Nano_Wire()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
