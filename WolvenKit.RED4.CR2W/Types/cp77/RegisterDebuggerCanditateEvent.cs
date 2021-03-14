using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterDebuggerCanditateEvent : redEvent
	{
		private wCHandle<Device> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public wCHandle<Device> Device
		{
			get
			{
				if (_device == null)
				{
					_device = (wCHandle<Device>) CR2WTypeManager.Create("whandle:Device", "device", cr2w, this);
				}
				return _device;
			}
			set
			{
				if (_device == value)
				{
					return;
				}
				_device = value;
				PropertySet(this);
			}
		}

		public RegisterDebuggerCanditateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
