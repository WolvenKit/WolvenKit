using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperEntry : CVariable
	{
		[Ordinal(0)]  [RED("destination")] public entVertexAnimationMapperDestination Destination { get; set; }
		[Ordinal(1)]  [RED("sources", 4)] public CStatic<entVertexAnimationMapperSource> Sources { get; set; }

		public entVertexAnimationMapperEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
