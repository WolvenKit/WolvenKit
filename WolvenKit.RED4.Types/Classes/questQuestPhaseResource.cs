using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPhaseResource : graphGraphResource
	{
		private CArray<questQuestPrefabEntry> _phasePrefabs;

		[Ordinal(2)] 
		[RED("phasePrefabs")] 
		public CArray<questQuestPrefabEntry> PhasePrefabs
		{
			get => GetProperty(ref _phasePrefabs);
			set => SetProperty(ref _phasePrefabs, value);
		}
	}
}
