using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		[Ordinal(0)]  [RED("progress")] public inkImageWidgetReference Progress { get; set; }

		public KeyboardHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
