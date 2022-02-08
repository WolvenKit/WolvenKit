using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPhaseResource : graphGraphResource
	{
		[Ordinal(2)] 
		[RED("phasePrefabs")] 
		public CArray<questQuestPrefabEntry> PhasePrefabs
		{
			get => GetPropertyValue<CArray<questQuestPrefabEntry>>();
			set => SetPropertyValue<CArray<questQuestPrefabEntry>>(value);
		}

		public questQuestPhaseResource()
		{
			PhasePrefabs = new();
		}
	}
}
