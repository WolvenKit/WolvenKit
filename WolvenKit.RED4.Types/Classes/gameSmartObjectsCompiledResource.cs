using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectsCompiledResource : resStreamedResource
	{
		private CHandle<gameSmartObjectAnimationDatabase> _animationDatabase;
		private CHandle<gameCompiledNodes> _compiledNodesData;
		private CHandle<gameSmartObjectTransformDictionary> _transformDictionary;
		private CHandle<gameSmartObjectPropertyDictionary> _propertyDictionary;
		private CHandle<gameSmartObjectTransformSequenceDictionary> _transformSequenceDictionary;
		private CHandle<gameSmartObjectMembership> _soMembership;
		private Box _localBoundingBox;

		[Ordinal(1)] 
		[RED("animationDatabase")] 
		public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase
		{
			get => GetProperty(ref _animationDatabase);
			set => SetProperty(ref _animationDatabase, value);
		}

		[Ordinal(2)] 
		[RED("compiledNodesData")] 
		public CHandle<gameCompiledNodes> CompiledNodesData
		{
			get => GetProperty(ref _compiledNodesData);
			set => SetProperty(ref _compiledNodesData, value);
		}

		[Ordinal(3)] 
		[RED("transformDictionary")] 
		public CHandle<gameSmartObjectTransformDictionary> TransformDictionary
		{
			get => GetProperty(ref _transformDictionary);
			set => SetProperty(ref _transformDictionary, value);
		}

		[Ordinal(4)] 
		[RED("propertyDictionary")] 
		public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary
		{
			get => GetProperty(ref _propertyDictionary);
			set => SetProperty(ref _propertyDictionary, value);
		}

		[Ordinal(5)] 
		[RED("transformSequenceDictionary")] 
		public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary
		{
			get => GetProperty(ref _transformSequenceDictionary);
			set => SetProperty(ref _transformSequenceDictionary, value);
		}

		[Ordinal(6)] 
		[RED("soMembership")] 
		public CHandle<gameSmartObjectMembership> SoMembership
		{
			get => GetProperty(ref _soMembership);
			set => SetProperty(ref _soMembership, value);
		}

		[Ordinal(7)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get => GetProperty(ref _localBoundingBox);
			set => SetProperty(ref _localBoundingBox, value);
		}
	}
}
