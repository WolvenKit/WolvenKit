using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		[Ordinal(2)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetPropertyValue<physicsDestructionParams>();
			set => SetPropertyValue<physicsDestructionParams>(value);
		}

		[Ordinal(4)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetPropertyValue<CArray<physicsDestructionLevelData>>();
			set => SetPropertyValue<CArray<physicsDestructionLevelData>>(value);
		}

		public worldFoliagePhysicalDestructionMapping()
		{
			DestructionParams = new physicsDestructionParams();
			DestructionLevelData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
