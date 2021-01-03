using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("onTogglePlayListener")] public CUInt32 OnTogglePlayListener { get; set; }

		public JukeboxBigGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
