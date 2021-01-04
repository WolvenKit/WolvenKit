using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetGlitchOnUIEvent : redEvent
	{
		[Ordinal(0)]  [RED("intensity")] public CFloat Intensity { get; set; }

		public SetGlitchOnUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
