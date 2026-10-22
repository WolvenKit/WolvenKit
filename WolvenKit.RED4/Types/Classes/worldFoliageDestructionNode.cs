using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageDestructionNode : worldCollisionNode
	{
		[Ordinal(16)] 
		[RED("populationIndex")] 
		public CArray<CUInt32> PopulationIndex
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(17)] 
		[RED("foliageResourceHash")] 
		public CUInt64 FoliageResourceHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(18)] 
		[RED("dataVersion")] 
		public CUInt32 DataVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldFoliageDestructionNode()
		{
			PopulationIndex = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
