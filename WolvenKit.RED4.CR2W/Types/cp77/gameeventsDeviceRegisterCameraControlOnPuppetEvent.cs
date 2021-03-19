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
			get => GetProperty(ref _component);
			set => SetProperty(ref _component, value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		public gameeventsDeviceRegisterCameraControlOnPuppetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
