using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectByChanceEffector : gameEffector
	{
		private wCHandle<gameObject> _target;
		private CString _applicationTarget;
		private TweakDBID _record;
		private CBool _removeWithEffector;
		private CFloat _chance;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get
			{
				if (_applicationTarget == null)
				{
					_applicationTarget = (CString) CR2WTypeManager.Create("String", "applicationTarget", cr2w, this);
				}
				return _applicationTarget;
			}
			set
			{
				if (_applicationTarget == value)
				{
					return;
				}
				_applicationTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get
			{
				if (_removeWithEffector == null)
				{
					_removeWithEffector = (CBool) CR2WTypeManager.Create("Bool", "removeWithEffector", cr2w, this);
				}
				return _removeWithEffector;
			}
			set
			{
				if (_removeWithEffector == value)
				{
					return;
				}
				_removeWithEffector = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get
			{
				if (_chance == null)
				{
					_chance = (CFloat) CR2WTypeManager.Create("Float", "chance", cr2w, this);
				}
				return _chance;
			}
			set
			{
				if (_chance == value)
				{
					return;
				}
				_chance = value;
				PropertySet(this);
			}
		}

		public ApplyStatusEffectByChanceEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
