using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceRegisterCameraControlOnPuppetEvent : redEvent
	{
		private CHandle<gameDeviceCameraControlComponent> _component;
		private CBool _register;

		[Ordinal(0)] 
		[RED("component")] 
		public CHandle<gameDeviceCameraControlComponent> Component
		{
			get
			{
				if (_component == null)
				{
					_component = (CHandle<gameDeviceCameraControlComponent>) CR2WTypeManager.Create("handle:gameDeviceCameraControlComponent", "component", cr2w, this);
				}
				return _component;
			}
			set
			{
				if (_component == value)
				{
					return;
				}
				_component = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CBool) CR2WTypeManager.Create("Bool", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		public gameeventsDeviceRegisterCameraControlOnPuppetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
