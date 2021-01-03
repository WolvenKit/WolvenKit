using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCurveStatModifierData : gameStatModifierData
	{
		[Ordinal(0)]  [RED("columnName")] public CName ColumnName { get; set; }
		[Ordinal(1)]  [RED("curveName")] public CName CurveName { get; set; }
		[Ordinal(2)]  [RED("curveStat")] public CEnum<gamedataStatType> CurveStat { get; set; }

		public gameCurveStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
