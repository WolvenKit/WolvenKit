using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPhaseResource : graphGraphResource
	{
		private CArray<questQuestPrefabEntry> _phasePrefabs;

		[Ordinal(2)] 
		[RED("phasePrefabs")] 
		public CArray<questQuestPrefabEntry> PhasePrefabs
		{
			get => GetProperty(ref _phasePrefabs);
			set => SetProperty(ref _phasePrefabs, value);
		}

		public questQuestPhaseResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
