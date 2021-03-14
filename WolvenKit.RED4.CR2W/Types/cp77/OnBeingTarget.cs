using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnBeingTarget : redEvent
	{
		private wCHandle<gameObject> _objectThatTargets;
		private CBool _noLongerTarget;

		[Ordinal(0)] 
		[RED("objectThatTargets")] 
		public wCHandle<gameObject> ObjectThatTargets
		{
			get
			{
				if (_objectThatTargets == null)
				{
					_objectThatTargets = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "objectThatTargets", cr2w, this);
				}
				return _objectThatTargets;
			}
			set
			{
				if (_objectThatTargets == value)
				{
					return;
				}
				_objectThatTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("noLongerTarget")] 
		public CBool NoLongerTarget
		{
			get
			{
				if (_noLongerTarget == null)
				{
					_noLongerTarget = (CBool) CR2WTypeManager.Create("Bool", "noLongerTarget", cr2w, this);
				}
				return _noLongerTarget;
			}
			set
			{
				if (_noLongerTarget == value)
				{
					return;
				}
				_noLongerTarget = value;
				PropertySet(this);
			}
		}

		public OnBeingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
