using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnFindNetworkPlayerParams : CVariable
	{
		[Ordinal(0)]  [RED("networkId")] public CUInt32 NetworkId { get; set; }

		public scnFindNetworkPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
