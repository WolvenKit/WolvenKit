using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questQuestPhaseResource : graphGraphResource
	{
		[Ordinal(0)]  [RED("phasePrefabs")] public CArray<questQuestPrefabEntry> PhasePrefabs { get; set; }

		public questQuestPhaseResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
