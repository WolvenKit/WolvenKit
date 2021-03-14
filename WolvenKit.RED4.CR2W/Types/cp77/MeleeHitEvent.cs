using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeHitEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _target;
		private CBool _isStrongAttack;
		private CBool _hitBlocked;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get
			{
				if (_isStrongAttack == null)
				{
					_isStrongAttack = (CBool) CR2WTypeManager.Create("Bool", "isStrongAttack", cr2w, this);
				}
				return _isStrongAttack;
			}
			set
			{
				if (_isStrongAttack == value)
				{
					return;
				}
				_isStrongAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitBlocked")] 
		public CBool HitBlocked
		{
			get
			{
				if (_hitBlocked == null)
				{
					_hitBlocked = (CBool) CR2WTypeManager.Create("Bool", "hitBlocked", cr2w, this);
				}
				return _hitBlocked;
			}
			set
			{
				if (_hitBlocked == value)
				{
					return;
				}
				_hitBlocked = value;
				PropertySet(this);
			}
		}

		public MeleeHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
