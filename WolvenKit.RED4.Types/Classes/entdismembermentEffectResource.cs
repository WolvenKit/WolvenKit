using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentEffectResource : ISerializable
	{
		private CName _name;
		private CArray<CName> _appearanceNames;
		private CEnum<physicsRagdollBodyPartE> _bodyPartMask;
		private Transform _offset;
		private CEnum<entdismembermentPlacementE> _placement;
		private CEnum<entdismembermentResourceSetMask> _resourceSets;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private CResourceAsyncReference<worldEffect> _effect;
		private CBool _matchToWoundByName;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("AppearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get => GetProperty(ref _appearanceNames);
			set => SetProperty(ref _appearanceNames, value);
		}

		[Ordinal(2)] 
		[RED("BodyPartMask")] 
		public CEnum<physicsRagdollBodyPartE> BodyPartMask
		{
			get => GetProperty(ref _bodyPartMask);
			set => SetProperty(ref _bodyPartMask, value);
		}

		[Ordinal(3)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(4)] 
		[RED("Placement")] 
		public CEnum<entdismembermentPlacementE> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CEnum<entdismembermentResourceSetMask> ResourceSets
		{
			get => GetProperty(ref _resourceSets);
			set => SetProperty(ref _resourceSets, value);
		}

		[Ordinal(6)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(7)] 
		[RED("Effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(8)] 
		[RED("MatchToWoundByName")] 
		public CBool MatchToWoundByName
		{
			get => GetProperty(ref _matchToWoundByName);
			set => SetProperty(ref _matchToWoundByName, value);
		}

		public entdismembermentEffectResource()
		{
			_placement = new() { Value = Enums.entdismembermentPlacementE.MAIN_MESH };
			_resourceSets = new() { Value = Enums.entdismembermentResourceSetMask.BARE | Enums.entdismembermentResourceSetMask.BARE1 | Enums.entdismembermentResourceSetMask.BARE2 | Enums.entdismembermentResourceSetMask.BARE3 | Enums.entdismembermentResourceSetMask.GARMENT | Enums.entdismembermentResourceSetMask.GARMENT1 | Enums.entdismembermentResourceSetMask.GARMENT2 | Enums.entdismembermentResourceSetMask.GARMENT3 };
			_woundType = new() { Value = Enums.entdismembermentWoundTypeE.COARSE };
		}
	}
}
