using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolsSystemSave : ISerializable
	{
		[Ordinal(0)] [RED("mapping")] public CArray<gameStatsObjectID> Mapping { get; set; }
		[Ordinal(1)] [RED("statPools")] public CArray<gameStatPoolData> StatPools { get; set; }

		public gameStatPoolsSystemSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
