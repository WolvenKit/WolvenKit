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
			get
			{
				if (_footstepsMetadata == null)
				{
					_footstepsMetadata = (CName) CR2WTypeManager.Create("CName", "footstepsMetadata", cr2w, this);
				}
				return _footstepsMetadata;
			}
			set
			{
				if (_footstepsMetadata == value)
				{
					return;
				}
				_footstepsMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ragdollMetadata")] 
		public CName RagdollMetadata
		{
			get
			{
				if (_ragdollMetadata == null)
				{
					_ragdollMetadata = (CName) CR2WTypeManager.Create("CName", "ragdollMetadata", cr2w, this);
				}
				return _ragdollMetadata;
			}
			set
			{
				if (_ragdollMetadata == value)
				{
					return;
				}
				_ragdollMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("physicalMaterial")] 
		public CName PhysicalMaterial
		{
			get
			{
				if (_physicalMaterial == null)
				{
					_physicalMaterial = (CName) CR2WTypeManager.Create("CName", "physicalMaterial", cr2w, this);
				}
				return _physicalMaterial;
			}
			set
			{
				if (_physicalMaterial == value)
				{
					return;
				}
				_physicalMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("obstructionData")] 
		public CName ObstructionData
		{
			get
			{
				if (_obstructionData == null)
				{
					_obstructionData = (CName) CR2WTypeManager.Create("CName", "obstructionData", cr2w, this);
				}
				return _obstructionData;
			}
			set
			{
				if (_obstructionData == value)
				{
					return;
				}
				_obstructionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("reflectionParams")] 
		public CName ReflectionParams
		{
			get
			{
				if (_reflectionParams == null)
				{
					_reflectionParams = (CName) CR2WTypeManager.Create("CName", "reflectionParams", cr2w, this);
				}
				return _reflectionParams;
			}
			set
			{
				if (_reflectionParams == value)
				{
					return;
				}
				_reflectionParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("meleeMaterialName")] 
		public CName MeleeMaterialName
		{
			get
			{
				if (_meleeMaterialName == null)
				{
					_meleeMaterialName = (CName) CR2WTypeManager.Create("CName", "meleeMaterialName", cr2w, this);
				}
				return _meleeMaterialName;
			}
			set
			{
				if (_meleeMaterialName == value)
				{
					return;
				}
				_meleeMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehicleMaterialName")] 
		public CName VehicleMaterialName
		{
			get
			{
				if (_vehicleMaterialName == null)
				{
					_vehicleMaterialName = (CName) CR2WTypeManager.Create("CName", "vehicleMaterialName", cr2w, this);
				}
				return _vehicleMaterialName;
			}
			set
			{
				if (_vehicleMaterialName == value)
				{
					return;
				}
				_vehicleMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("foliageMaterialName")] 
		public CName FoliageMaterialName
		{
			get
			{
				if (_foliageMaterialName == null)
				{
					_foliageMaterialName = (CName) CR2WTypeManager.Create("CName", "foliageMaterialName", cr2w, this);
				}
				return _foliageMaterialName;
			}
			set
			{
				if (_foliageMaterialName == value)
				{
					return;
				}
				_foliageMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("foliagePaletteTag")] 
		public CName FoliagePaletteTag
		{
			get
			{
				if (_foliagePaletteTag == null)
				{
					_foliagePaletteTag = (CName) CR2WTypeManager.Create("CName", "foliagePaletteTag", cr2w, this);
				}
				return _foliagePaletteTag;
			}
			set
			{
				if (_foliagePaletteTag == value)
				{
					return;
				}
				_foliagePaletteTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("meleeMaterialType")] 
		public CEnum<audioMeleeMaterialType> MeleeMaterialType
		{
			get
			{
				if (_meleeMaterialType == null)
				{
					_meleeMaterialType = (CEnum<audioMeleeMaterialType>) CR2WTypeManager.Create("audioMeleeMaterialType", "meleeMaterialType", cr2w, this);
				}
				return _meleeMaterialType;
			}
			set
			{
				if (_meleeMaterialType == value)
				{
					return;
				}
				_meleeMaterialType = value;
				PropertySet(this);
			}
		}

		public audioAudioMaterialMetadataMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
