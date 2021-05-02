using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioMaterialMetadataMapItem : audioAudioMetadata
	{
		private CName _footstepsMetadata;
		private CName _ragdollMetadata;
		private CName _physicalMaterial;
		private CName _obstructionData;
		private CName _reflectionParams;
		private CName _meleeMaterialName;
		private CName _vehicleMaterialName;
		private CName _foliageMaterialName;
		private CName _foliagePaletteTag;
		private CEnum<audioMeleeMaterialType> _meleeMaterialType;

		[Ordinal(1)] 
		[RED("footstepsMetadata")] 
		public CName FootstepsMetadata
		{
			get => GetProperty(ref _footstepsMetadata);
			set => SetProperty(ref _footstepsMetadata, value);
		}

		[Ordinal(2)] 
		[RED("ragdollMetadata")] 
		public CName RagdollMetadata
		{
			get => GetProperty(ref _ragdollMetadata);
			set => SetProperty(ref _ragdollMetadata, value);
		}

		[Ordinal(3)] 
		[RED("physicalMaterial")] 
		public CName PhysicalMaterial
		{
			get => GetProperty(ref _physicalMaterial);
			set => SetProperty(ref _physicalMaterial, value);
		}

		[Ordinal(4)] 
		[RED("obstructionData")] 
		public CName ObstructionData
		{
			get => GetProperty(ref _obstructionData);
			set => SetProperty(ref _obstructionData, value);
		}

		[Ordinal(5)] 
		[RED("reflectionParams")] 
		public CName ReflectionParams
		{
			get => GetProperty(ref _reflectionParams);
			set => SetProperty(ref _reflectionParams, value);
		}

		[Ordinal(6)] 
		[RED("meleeMaterialName")] 
		public CName MeleeMaterialName
		{
			get => GetProperty(ref _meleeMaterialName);
			set => SetProperty(ref _meleeMaterialName, value);
		}

		[Ordinal(7)] 
		[RED("vehicleMaterialName")] 
		public CName VehicleMaterialName
		{
			get => GetProperty(ref _vehicleMaterialName);
			set => SetProperty(ref _vehicleMaterialName, value);
		}

		[Ordinal(8)] 
		[RED("foliageMaterialName")] 
		public CName FoliageMaterialName
		{
			get => GetProperty(ref _foliageMaterialName);
			set => SetProperty(ref _foliageMaterialName, value);
		}

		[Ordinal(9)] 
		[RED("foliagePaletteTag")] 
		public CName FoliagePaletteTag
		{
			get => GetProperty(ref _foliagePaletteTag);
			set => SetProperty(ref _foliagePaletteTag, value);
		}

		[Ordinal(10)] 
		[RED("meleeMaterialType")] 
		public CEnum<audioMeleeMaterialType> MeleeMaterialType
		{
			get => GetProperty(ref _meleeMaterialType);
			set => SetProperty(ref _meleeMaterialType, value);
		}

		public audioAudioMaterialMetadataMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
