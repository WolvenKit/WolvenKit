using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questQuestPhaseResource : graphGraphResource
	{
		[Ordinal(2)] 
		[RED("phasePrefabs")] 
		public CArray<questQuestPrefabEntry> PhasePrefabs
		{
			get => GetPropertyValue<CArray<questQuestPrefabEntry>>();
			set => SetPropertyValue<CArray<questQuestPrefabEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("inplacePhases")] 
		public CArray<CResourceReference<CResource>> InplacePhases
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		public questQuestPhaseResource()
		{
			PhasePrefabs = new();
			InplacePhases = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
