using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsStateMapStructure : CVariable
	{
		[Ordinal(0)] [RED("keys")] public CArray<gameStatsObjectID> Keys { get; set; }
		[Ordinal(1)] [RED("values")] public CArray<gameSavedStatsData> Values { get; set; }

		public gameStatsStateMapStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
