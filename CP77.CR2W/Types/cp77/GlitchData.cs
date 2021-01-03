using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GlitchData : CVariable
	{
		[Ordinal(0)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<EGlitchState> State { get; set; }

		public GlitchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
