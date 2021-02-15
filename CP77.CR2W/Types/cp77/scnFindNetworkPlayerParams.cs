using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnFindNetworkPlayerParams : CVariable
	{
		[Ordinal(0)] [RED("networkId")] public CUInt32 NetworkId { get; set; }

		public scnFindNetworkPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
