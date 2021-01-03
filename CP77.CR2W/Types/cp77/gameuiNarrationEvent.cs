using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrationEvent : CVariable
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("durationSec")] public CFloat DurationSec { get; set; }
		[Ordinal(2)]  [RED("text")] public CString Text { get; set; }

		public gameuiNarrationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
