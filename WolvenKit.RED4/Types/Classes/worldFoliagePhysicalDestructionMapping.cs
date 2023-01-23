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
			DestructionParams = new() { DamageThreshold = 25.000000F, DamageEndurance = 10.000000F, BondEndurance = 20.000000F, AccumulateDamage = true, ImpulseToDamage = 1.000000F, ContactToDamage = 10.000000F, MaxContactImpulseRatio = 1.000000F, ImpulseChildPropagationFactor = 1.000000F, ImpulsePropagationFactor = 0.500000F, ImpulseDiminishingFactor = 0.500000F, DebrisMaxSeparation = 50.000000F, MaxAngularVelocity = -1.000000F, FractureFieldMask = Enums.physicsFractureFieldType.FF_Default };
			DestructionLevelData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
