using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReverbCrossoverParams : CVariable
	{
		[Ordinal(0)] [RED("dist")] public CFloat Dist { get; set; }
		[Ordinal(1)] [RED("fade")] public CFloat Fade { get; set; }

		public audioReverbCrossoverParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
