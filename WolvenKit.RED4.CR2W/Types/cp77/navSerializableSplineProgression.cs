using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navSerializableSplineProgression : CVariable
	{
		[Ordinal(0)] [RED("sectionIdx")] public CUInt32 SectionIdx { get; set; }
		[Ordinal(1)] [RED("alpha")] public CFloat Alpha { get; set; }

		public navSerializableSplineProgression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
