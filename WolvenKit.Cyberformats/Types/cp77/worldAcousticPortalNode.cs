using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticPortalNode : worldNode
	{
		[Ordinal(4)] [RED("radius")] public CUInt8 Radius { get; set; }
		[Ordinal(5)] [RED("nominalRadius")] public CUInt8 NominalRadius { get; set; }

		public worldAcousticPortalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
