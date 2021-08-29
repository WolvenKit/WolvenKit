using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageDestructionNode : worldCollisionNode
	{
		private CArray<CUInt32> _populationIndex;
		private CUInt64 _foliageResourceHash;
		private CUInt32 _dataVersion;

		[Ordinal(18)] 
		[RED("populationIndex")] 
		public CArray<CUInt32> PopulationIndex
		{
			get => GetProperty(ref _populationIndex);
			set => SetProperty(ref _populationIndex, value);
		}

		[Ordinal(19)] 
		[RED("foliageResourceHash")] 
		public CUInt64 FoliageResourceHash
		{
			get => GetProperty(ref _foliageResourceHash);
			set => SetProperty(ref _foliageResourceHash, value);
		}

		[Ordinal(20)] 
		[RED("dataVersion")] 
		public CUInt32 DataVersion
		{
			get => GetProperty(ref _dataVersion);
			set => SetProperty(ref _dataVersion, value);
		}
	}
}
