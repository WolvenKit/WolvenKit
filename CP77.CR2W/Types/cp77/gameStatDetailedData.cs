using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStatDetailedData : CVariable
	{
		[Ordinal(0)]  [RED("boolStatType")] public CBool BoolStatType { get; set; }
		[Ordinal(1)]  [RED("limitMax")] public CFloat LimitMax { get; set; }
		[Ordinal(2)]  [RED("limitMin")] public CFloat LimitMin { get; set; }
		[Ordinal(3)]  [RED("modifiers")] public CArray<gameStatModifierDetailedData> Modifiers { get; set; }
		[Ordinal(4)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(5)]  [RED("value")] public CFloat Value { get; set; }

		public gameStatDetailedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
