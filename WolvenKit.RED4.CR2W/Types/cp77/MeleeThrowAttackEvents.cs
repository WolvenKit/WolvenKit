using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _projectileThrown;
		private wCHandle<gameObject> _targetObject;

		[Ordinal(8)] 
		[RED("projectileThrown")] 
		public CBool ProjectileThrown
		{
			get
			{
				if (_projectileThrown == null)
				{
					_projectileThrown = (CBool) CR2WTypeManager.Create("Bool", "projectileThrown", cr2w, this);
				}
				return _projectileThrown;
			}
			set
			{
				if (_projectileThrown == value)
				{
					return;
				}
				_projectileThrown = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		public MeleeThrowAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
