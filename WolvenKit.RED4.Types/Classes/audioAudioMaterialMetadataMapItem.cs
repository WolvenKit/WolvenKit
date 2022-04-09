using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioMaterialMetadataMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("footstepsMetadata")] 
		public CName FootstepsMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ragdollMetadata")] 
		public CName RagdollMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("physicalMaterial")] 
		public CName PhysicalMaterial
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("obstructionData")] 
		public CName ObstructionData
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("reflectionParams")] 
		public CName ReflectionParams
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("meleeMaterialName")] 
		public CName MeleeMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("vehicleMaterialName")] 
		public CName VehicleMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("foliageMaterialName")] 
		public CName FoliageMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("foliagePaletteTag")] 
		public CName FoliagePaletteTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("meleeMaterialType")] 
		public CEnum<audioMeleeMaterialType> MeleeMaterialType
		{
			get => GetPropertyValue<CEnum<audioMeleeMaterialType>>();
			set => SetPropertyValue<CEnum<audioMeleeMaterialType>>(value);
		}

		public audioAudioMaterialMetadataMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
