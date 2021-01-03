using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class navSerializableSplineProgression : CVariable
	{
		[Ordinal(0)]  [RED("alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("sectionIdx")] public CUInt32 SectionIdx { get; set; }

		public navSerializableSplineProgression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
