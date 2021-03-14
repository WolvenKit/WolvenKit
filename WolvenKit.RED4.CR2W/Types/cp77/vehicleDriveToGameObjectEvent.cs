using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToGameObjectEvent : redEvent
	{
		private wCHandle<gameObject> _targetObjToReach;

		[Ordinal(0)] 
		[RED("targetObjToReach")] 
		public wCHandle<gameObject> TargetObjToReach
		{
			get
			{
				if (_targetObjToReach == null)
				{
					_targetObjToReach = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObjToReach", cr2w, this);
				}
				return _targetObjToReach;
			}
			set
			{
				if (_targetObjToReach == value)
				{
					return;
				}
				_targetObjToReach = value;
				PropertySet(this);
			}
		}

		public vehicleDriveToGameObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
