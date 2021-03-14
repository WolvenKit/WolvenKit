using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowEvent : redEvent
	{
		private wCHandle<gameObject> _followObject;

		[Ordinal(0)] 
		[RED("followObject")] 
		public wCHandle<gameObject> FollowObject
		{
			get
			{
				if (_followObject == null)
				{
					_followObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "followObject", cr2w, this);
				}
				return _followObject;
			}
			set
			{
				if (_followObject == value)
				{
					return;
				}
				_followObject = value;
				PropertySet(this);
			}
		}

		public gameprojectileFollowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
