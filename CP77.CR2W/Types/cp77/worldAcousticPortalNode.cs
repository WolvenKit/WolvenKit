using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAcousticPortalNode : worldNode
	{
		[Ordinal(0)]  [RED("nominalRadius")] public CUInt8 NominalRadius { get; set; }
		[Ordinal(1)]  [RED("radius")] public CUInt8 Radius { get; set; }

		public worldAcousticPortalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
