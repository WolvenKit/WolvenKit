using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatsSystemSave : ISerializable
	{
		private CArray<gameStatsSeedKey> _statsObjectsData;
		private CArray<gameStatModifierSave> _statModifiersData;

		[Ordinal(0)] 
		[RED("statsObjectsData")] 
		public CArray<gameStatsSeedKey> StatsObjectsData
		{
			get => GetProperty(ref _statsObjectsData);
			set => SetProperty(ref _statsObjectsData, value);
		}

		[Ordinal(1)] 
		[RED("statModifiersData")] 
		public CArray<gameStatModifierSave> StatModifiersData
		{
			get => GetProperty(ref _statModifiersData);
			set => SetProperty(ref _statModifiersData, value);
		}
	}
}
