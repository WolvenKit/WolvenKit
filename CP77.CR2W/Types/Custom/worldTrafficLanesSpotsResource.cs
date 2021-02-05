using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanesSpotsResource : resStreamedResource
	{

        [Ordinal(1000)] [REDBuffer] public CUInt32 Unk1 { get; set; }

        public worldTrafficLanesSpotsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

    }
}
