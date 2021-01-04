using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackdoorInkGameController : MasterDeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("ConnectedGroup")] public inkWidgetReference ConnectedGroup { get; set; }
		[Ordinal(1)]  [RED("GlitchAnimationName")] public CName GlitchAnimationName { get; set; }
		[Ordinal(2)]  [RED("IdleAnimationName")] public CName IdleAnimationName { get; set; }
		[Ordinal(3)]  [RED("IdleGroup")] public inkWidgetReference IdleGroup { get; set; }
		[Ordinal(4)]  [RED("IntroAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(5)]  [RED("RunningAnimation")] public CHandle<inkanimProxy> RunningAnimation { get; set; }
		[Ordinal(6)]  [RED("onBootModuleListener")] public CUInt32 OnBootModuleListener { get; set; }
		[Ordinal(7)]  [RED("onGlitchingListener")] public CUInt32 OnGlitchingListener { get; set; }
		[Ordinal(8)]  [RED("onIsInDefaultStateListener")] public CUInt32 OnIsInDefaultStateListener { get; set; }
		[Ordinal(9)]  [RED("onShutdownModuleListener")] public CUInt32 OnShutdownModuleListener { get; set; }

		public BackdoorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
