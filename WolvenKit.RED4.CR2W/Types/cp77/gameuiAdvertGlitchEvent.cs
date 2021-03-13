using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertGlitchEvent : redEvent
	{
		[Ordinal(0)] [RED("glitchValue")] public CFloat GlitchValue { get; set; }

		public gameuiAdvertGlitchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
