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
			get
			{
				if (_animEnterADS == null)
				{
					_animEnterADS = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animEnterADS", cr2w, this);
				}
				return _animEnterADS;
			}
			set
			{
				if (_animEnterADS == value)
				{
					return;
				}
				_animEnterADS = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("inAimDownSight")] 
		public CBool InAimDownSight
		{
			get
			{
				if (_inAimDownSight == null)
				{
					_inAimDownSight = (CBool) CR2WTypeManager.Create("Bool", "inAimDownSight", cr2w, this);
				}
				return _inAimDownSight;
			}
			set
			{
				if (_inAimDownSight == value)
				{
					return;
				}
				_inAimDownSight = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isHoveringOfficer")] 
		public CBool IsHoveringOfficer
		{
			get
			{
				if (_isHoveringOfficer == null)
				{
					_isHoveringOfficer = (CBool) CR2WTypeManager.Create("Bool", "isHoveringOfficer", cr2w, this);
				}
				return _isHoveringOfficer;
			}
			set
			{
				if (_isHoveringOfficer == value)
				{
					return;
				}
				_isHoveringOfficer = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("inChargedHold")] 
		public CBool InChargedHold
		{
			get
			{
				if (_inChargedHold == null)
				{
					_inChargedHold = (CBool) CR2WTypeManager.Create("Bool", "inChargedHold", cr2w, this);
				}
				return _inChargedHold;
			}
			set
			{
				if (_inChargedHold == value)
				{
					return;
				}
				_inChargedHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("anim_EnterHipFire")] 
		public CHandle<inkanimProxy> Anim_EnterHipFire
		{
			get
			{
				if (_anim_EnterHipFire == null)
				{
					_anim_EnterHipFire = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_EnterHipFire", cr2w, this);
				}
				return _anim_EnterHipFire;
			}
			set
			{
				if (_anim_EnterHipFire == value)
				{
					return;
				}
				_anim_EnterHipFire = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("anim_HoverEnterEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverEnterEnemy
		{
			get
			{
				if (_anim_HoverEnterEnemy == null)
				{
					_anim_HoverEnterEnemy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_HoverEnterEnemy", cr2w, this);
				}
				return _anim_HoverEnterEnemy;
			}
			set
			{
				if (_anim_HoverEnterEnemy == value)
				{
					return;
				}
				_anim_HoverEnterEnemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("anim_EnterStrongAttack")] 
		public CHandle<inkanimProxy> Anim_EnterStrongAttack
		{
			get
			{
				if (_anim_EnterStrongAttack == null)
				{
					_anim_EnterStrongAttack = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_EnterStrongAttack", cr2w, this);
				}
				return _anim_EnterStrongAttack;
			}
			set
			{
				if (_anim_EnterStrongAttack == value)
				{
					return;
				}
				_anim_EnterStrongAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("anim_EnterThrowAttack")] 
		public CHandle<inkanimProxy> Anim_EnterThrowAttack
		{
			get
			{
				if (_anim_EnterThrowAttack == null)
				{
					_anim_EnterThrowAttack = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_EnterThrowAttack", cr2w, this);
				}
				return _anim_EnterThrowAttack;
			}
			set
			{
				if (_anim_EnterThrowAttack == value)
				{
					return;
				}
				_anim_EnterThrowAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("anim_EnterEveryOtherAttack")] 
		public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack
		{
			get
			{
				if (_anim_EnterEveryOtherAttack == null)
				{
					_anim_EnterEveryOtherAttack = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_EnterEveryOtherAttack", cr2w, this);
				}
				return _anim_EnterEveryOtherAttack;
			}
			set
			{
				if (_anim_EnterEveryOtherAttack == value)
				{
					return;
				}
				_anim_EnterEveryOtherAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("anim_EnterChargedHold")] 
		public CHandle<inkanimProxy> Anim_EnterChargedHold
		{
			get
			{
				if (_anim_EnterChargedHold == null)
				{
					_anim_EnterChargedHold = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_EnterChargedHold", cr2w, this);
				}
				return _anim_EnterChargedHold;
			}
			set
			{
				if (_anim_EnterChargedHold == value)
				{
					return;
				}
				_anim_EnterChargedHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("anim_HoverExitEnemy")] 
		public CHandle<inkanimProxy> Anim_HoverExitEnemy
		{
			get
			{
				if (_anim_HoverExitEnemy == null)
				{
					_anim_HoverExitEnemy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_HoverExitEnemy", cr2w, this);
				}
				return _anim_HoverExitEnemy;
			}
			set
			{
				if (_anim_HoverExitEnemy == value)
				{
					return;
				}
				_anim_HoverExitEnemy = value;
				PropertySet(this);
			}
		}

		public Crosshair_Melee_Nano_Wire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
