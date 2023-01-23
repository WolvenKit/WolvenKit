using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalDestructionComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(9)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetPropertyValue<physicsDestructionParams>();
			set => SetPropertyValue<physicsDestructionParams>(value);
		}

		[Ordinal(12)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetPropertyValue<CArray<physicsDestructionLevelData>>();
			set => SetPropertyValue<CArray<physicsDestructionLevelData>>(value);
		}

		[Ordinal(13)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("systemsToNotifyFlags")] 
		public CUInt16 SystemsToNotifyFlags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public entPhysicalDestructionComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			MeshAppearance = "default";
			DestructionParams = new() { DamageThreshold = 25.000000F, DamageEndurance = 10.000000F, BondEndurance = 20.000000F, AccumulateDamage = true, ImpulseToDamage = 1.000000F, ContactToDamage = 10.000000F, MaxContactImpulseRatio = 1.000000F, ImpulseChildPropagationFactor = 1.000000F, ImpulsePropagationFactor = 0.500000F, ImpulseDiminishingFactor = 0.500000F, DebrisMaxSeparation = 50.000000F, MaxAngularVelocity = -1.000000F, FractureFieldMask = Enums.physicsFractureFieldType.FF_Default };
			DestructionLevelData = new();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
