using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class drillMachineEvent : redEvent
	{
		private wCHandle<gameObject> _newTargetDevice;
		private CBool _newIsActive;

		[Ordinal(0)] 
		[RED("newTargetDevice")] 
		public wCHandle<gameObject> NewTargetDevice
		{
			get
			{
				if (_newTargetDevice == null)
				{
					_newTargetDevice = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "newTargetDevice", cr2w, this);
				}
				return _newTargetDevice;
			}
			set
			{
				if (_newTargetDevice == value)
				{
					return;
				}
				_newTargetDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newIsActive")] 
		public CBool NewIsActive
		{
			get
			{
				if (_newIsActive == null)
				{
					_newIsActive = (CBool) CR2WTypeManager.Create("Bool", "newIsActive", cr2w, this);
				}
				return _newIsActive;
			}
			set
			{
				if (_newIsActive == value)
				{
					return;
				}
				_newIsActive = value;
				PropertySet(this);
			}
		}

		public drillMachineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
