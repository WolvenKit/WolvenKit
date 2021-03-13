using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointTerminalInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("sellAction")] public inkWidgetReference SellAction { get; set; }
		[Ordinal(17)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public DropPointTerminalInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
