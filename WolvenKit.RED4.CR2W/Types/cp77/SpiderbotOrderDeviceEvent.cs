using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpiderbotOrderDeviceEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private wCHandle<gameObject> _overrideMovementTarget;

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
		[RED("overrideMovementTarget")] 
		public wCHandle<gameObject> OverrideMovementTarget
		{
			get
			{
				if (_overrideMovementTarget == null)
				{
					_overrideMovementTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "overrideMovementTarget", cr2w, this);
				}
				return _overrideMovementTarget;
			}
			set
			{
				if (_overrideMovementTarget == value)
				{
					return;
				}
				_overrideMovementTarget = value;
				PropertySet(this);
			}
		}

		public SpiderbotOrderDeviceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
