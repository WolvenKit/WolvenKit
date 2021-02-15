using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier2Data : gameSceneTierData
	{
		[Ordinal(2)] [RED("walkType")] public CEnum<Tier2WalkType> WalkType { get; set; }

		public gameSceneTier2Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
