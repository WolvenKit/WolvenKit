using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundResource : ISerializable
	{
		private CName _name;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private CEnum<physicsRagdollBodyPartE> _bodyPart;
		private entdismembermentCullObject _cullObject;
		private CFloat _garmentMorphStrength;
		private CBool _useProceduralCut;
		private CBool _useSingleMeshForRagdoll;
		private CBool _isCritical;
		private CArray<entdismembermentWoundMeshes> _resources;
		private CArray<entdismembermentWoundDecal> _decals;
		private CArray<CUInt64> _censoredPaths;
		private CArray<raRef<CResource>> _censoredCookedPaths;
		private CBool _censorshipValid;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "Name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<entdismembermentWoundTypeE>) CR2WTypeManager.Create("entdismembermentWoundTypeE", "WoundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "BodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CullObject")] 
		public entdismembermentCullObject CullObject
		{
			get
			{
				if (_cullObject == null)
				{
					_cullObject = (entdismembermentCullObject) CR2WTypeManager.Create("entdismembermentCullObject", "CullObject", cr2w, this);
				}
				return _cullObject;
			}
			set
			{
				if (_cullObject == value)
				{
					return;
				}
				_cullObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("GarmentMorphStrength")] 
		public CFloat GarmentMorphStrength
		{
			get
			{
				if (_garmentMorphStrength == null)
				{
					_garmentMorphStrength = (CFloat) CR2WTypeManager.Create("Float", "GarmentMorphStrength", cr2w, this);
				}
				return _garmentMorphStrength;
			}
			set
			{
				if (_garmentMorphStrength == value)
				{
					return;
				}
				_garmentMorphStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("UseProceduralCut")] 
		public CBool UseProceduralCut
		{
			get
			{
				if (_useProceduralCut == null)
				{
					_useProceduralCut = (CBool) CR2WTypeManager.Create("Bool", "UseProceduralCut", cr2w, this);
				}
				return _useProceduralCut;
			}
			set
			{
				if (_useProceduralCut == value)
				{
					return;
				}
				_useProceduralCut = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("UseSingleMeshForRagdoll")] 
		public CBool UseSingleMeshForRagdoll
		{
			get
			{
				if (_useSingleMeshForRagdoll == null)
				{
					_useSingleMeshForRagdoll = (CBool) CR2WTypeManager.Create("Bool", "UseSingleMeshForRagdoll", cr2w, this);
				}
				return _useSingleMeshForRagdoll;
			}
			set
			{
				if (_useSingleMeshForRagdoll == value)
				{
					return;
				}
				_useSingleMeshForRagdoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsCritical")] 
		public CBool IsCritical
		{
			get
			{
				if (_isCritical == null)
				{
					_isCritical = (CBool) CR2WTypeManager.Create("Bool", "IsCritical", cr2w, this);
				}
				return _isCritical;
			}
			set
			{
				if (_isCritical == value)
				{
					return;
				}
				_isCritical = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Resources")] 
		public CArray<entdismembermentWoundMeshes> Resources
		{
			get
			{
				if (_resources == null)
				{
					_resources = (CArray<entdismembermentWoundMeshes>) CR2WTypeManager.Create("array:entdismembermentWoundMeshes", "Resources", cr2w, this);
				}
				return _resources;
			}
			set
			{
				if (_resources == value)
				{
					return;
				}
				_resources = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Decals")] 
		public CArray<entdismembermentWoundDecal> Decals
		{
			get
			{
				if (_decals == null)
				{
					_decals = (CArray<entdismembermentWoundDecal>) CR2WTypeManager.Create("array:entdismembermentWoundDecal", "Decals", cr2w, this);
				}
				return _decals;
			}
			set
			{
				if (_decals == value)
				{
					return;
				}
				_decals = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("CensoredPaths")] 
		public CArray<CUInt64> CensoredPaths
		{
			get
			{
				if (_censoredPaths == null)
				{
					_censoredPaths = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "CensoredPaths", cr2w, this);
				}
				return _censoredPaths;
			}
			set
			{
				if (_censoredPaths == value)
				{
					return;
				}
				_censoredPaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("CensoredCookedPaths")] 
		public CArray<raRef<CResource>> CensoredCookedPaths
		{
			get
			{
				if (_censoredCookedPaths == null)
				{
					_censoredCookedPaths = (CArray<raRef<CResource>>) CR2WTypeManager.Create("array:raRef:CResource", "CensoredCookedPaths", cr2w, this);
				}
				return _censoredCookedPaths;
			}
			set
			{
				if (_censoredCookedPaths == value)
				{
					return;
				}
				_censoredCookedPaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("CensorshipValid")] 
		public CBool CensorshipValid
		{
			get
			{
				if (_censorshipValid == null)
				{
					_censorshipValid = (CBool) CR2WTypeManager.Create("Bool", "CensorshipValid", cr2w, this);
				}
				return _censorshipValid;
			}
			set
			{
				if (_censorshipValid == value)
				{
					return;
				}
				_censorshipValid = value;
				PropertySet(this);
			}
		}

		public entdismembermentWoundResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
