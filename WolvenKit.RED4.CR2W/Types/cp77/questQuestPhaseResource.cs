using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPhaseResource : graphGraphResource
	{
		[Ordinal(2)] [RED("phasePrefabs")] public CArray<questQuestPrefabEntry> PhasePrefabs { get; set; }

		public questQuestPhaseResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
