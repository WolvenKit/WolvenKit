using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceRegisterCameraControlOnPuppetEvent : redEvent
	{
		[Ordinal(0)] [RED("component")] public CHandle<gameDeviceCameraControlComponent> Component { get; set; }
		[Ordinal(1)] [RED("register")] public CBool Register { get; set; }

		public gameeventsDeviceRegisterCameraControlOnPuppetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
