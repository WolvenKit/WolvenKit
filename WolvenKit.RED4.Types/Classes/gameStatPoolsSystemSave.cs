using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatPoolsSystemSave : ISerializable
	{
		private CArray<gameStatsObjectID> _mapping;
		private CArray<gameStatPoolData> _statPools;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<gameStatsObjectID> Mapping
		{
			get => GetProperty(ref _mapping);
			set => SetProperty(ref _mapping, value);
		}

		[Ordinal(1)] 
		[RED("statPools")] 
		public CArray<gameStatPoolData> StatPools
		{
			get => GetProperty(ref _statPools);
			set => SetProperty(ref _statPools, value);
		}
	}
}
