using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerStatDetails : CVariable
	{
		[Ordinal(0)]  [RED("baseValue")] public CFloat BaseValue { get; set; }
		[Ordinal(1)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }

		public ScannerStatDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
