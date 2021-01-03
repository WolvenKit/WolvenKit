using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDesiredSlotsCountInfo : CVariable
	{
		[Ordinal(0)]  [RED("nCoeff")] public CFloat NCoeff { get; set; }
		[Ordinal(1)]  [RED("siredSlotsCount")] public CFloat SiredSlotsCount { get; set; }

		public worldDesiredSlotsCountInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
