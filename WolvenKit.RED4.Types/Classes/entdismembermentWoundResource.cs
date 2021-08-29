using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentWoundResource : ISerializable
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
		private CArray<CResourceAsyncReference<CResource>> _censoredCookedPaths;
		private CBool _censorshipValid;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(2)] 
		[RED("BodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(3)] 
		[RED("CullObject")] 
		public entdismembermentCullObject CullObject
		{
			get => GetProperty(ref _cullObject);
			set => SetProperty(ref _cullObject, value);
		}

		[Ordinal(4)] 
		[RED("GarmentMorphStrength")] 
		public CFloat GarmentMorphStrength
		{
			get => GetProperty(ref _garmentMorphStrength);
			set => SetProperty(ref _garmentMorphStrength, value);
		}

		[Ordinal(5)] 
		[RED("UseProceduralCut")] 
		public CBool UseProceduralCut
		{
			get => GetProperty(ref _useProceduralCut);
			set => SetProperty(ref _useProceduralCut, value);
		}

		[Ordinal(6)] 
		[RED("UseSingleMeshForRagdoll")] 
		public CBool UseSingleMeshForRagdoll
		{
			get => GetProperty(ref _useSingleMeshForRagdoll);
			set => SetProperty(ref _useSingleMeshForRagdoll, value);
		}

		[Ordinal(7)] 
		[RED("IsCritical")] 
		public CBool IsCritical
		{
			get => GetProperty(ref _isCritical);
			set => SetProperty(ref _isCritical, value);
		}

		[Ordinal(8)] 
		[RED("Resources")] 
		public CArray<entdismembermentWoundMeshes> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}

		[Ordinal(9)] 
		[RED("Decals")] 
		public CArray<entdismembermentWoundDecal> Decals
		{
			get => GetProperty(ref _decals);
			set => SetProperty(ref _decals, value);
		}

		[Ordinal(10)] 
		[RED("CensoredPaths")] 
		public CArray<CUInt64> CensoredPaths
		{
			get => GetProperty(ref _censoredPaths);
			set => SetProperty(ref _censoredPaths, value);
		}

		[Ordinal(11)] 
		[RED("CensoredCookedPaths")] 
		public CArray<CResourceAsyncReference<CResource>> CensoredCookedPaths
		{
			get => GetProperty(ref _censoredCookedPaths);
			set => SetProperty(ref _censoredCookedPaths, value);
		}

		[Ordinal(12)] 
		[RED("CensorshipValid")] 
		public CBool CensorshipValid
		{
			get => GetProperty(ref _censorshipValid);
			set => SetProperty(ref _censorshipValid, value);
		}
	}
}
