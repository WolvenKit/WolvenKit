using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperEntry : CVariable
	{
		[Ordinal(0)]  [RED("sources", 4)] public CStatic<entVertexAnimationMapperSource> Sources { get; set; }
		[Ordinal(1)]  [RED("destination")] public entVertexAnimationMapperDestination Destination { get; set; }

		public entVertexAnimationMapperEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
