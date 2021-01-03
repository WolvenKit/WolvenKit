using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SNameplateRangesData : CVariable
	{
		[Ordinal(0)]  [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(1)]  [RED("c_DisplayRangeNotAggressive")] public CFloat C_DisplayRangeNotAggressive { get; set; }
		[Ordinal(2)]  [RED("c_MaxDisplayRange")] public CFloat C_MaxDisplayRange { get; set; }
		[Ordinal(3)]  [RED("c_MaxDisplayRangeNotAggressive")] public CFloat C_MaxDisplayRangeNotAggressive { get; set; }

		public SNameplateRangesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
