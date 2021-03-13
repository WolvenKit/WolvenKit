using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier2Data : gameSceneTierData
	{
		[Ordinal(2)] [RED("walkType")] public CEnum<Tier2WalkType> WalkType { get; set; }

		public gameSceneTier2Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
