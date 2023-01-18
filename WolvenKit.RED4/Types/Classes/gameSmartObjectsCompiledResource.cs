using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectsCompiledResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("animationDatabase")] 
		public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase
		{
			get => GetPropertyValue<CHandle<gameSmartObjectAnimationDatabase>>();
			set => SetPropertyValue<CHandle<gameSmartObjectAnimationDatabase>>(value);
		}

		[Ordinal(2)] 
		[RED("compiledNodesData")] 
		public CHandle<gameCompiledNodes> CompiledNodesData
		{
			get => GetPropertyValue<CHandle<gameCompiledNodes>>();
			set => SetPropertyValue<CHandle<gameCompiledNodes>>(value);
		}

		[Ordinal(3)] 
		[RED("transformDictionary")] 
		public CHandle<gameSmartObjectTransformDictionary> TransformDictionary
		{
			get => GetPropertyValue<CHandle<gameSmartObjectTransformDictionary>>();
			set => SetPropertyValue<CHandle<gameSmartObjectTransformDictionary>>(value);
		}

		[Ordinal(4)] 
		[RED("propertyDictionary")] 
		public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary
		{
			get => GetPropertyValue<CHandle<gameSmartObjectPropertyDictionary>>();
			set => SetPropertyValue<CHandle<gameSmartObjectPropertyDictionary>>(value);
		}

		[Ordinal(5)] 
		[RED("transformSequenceDictionary")] 
		public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary
		{
			get => GetPropertyValue<CHandle<gameSmartObjectTransformSequenceDictionary>>();
			set => SetPropertyValue<CHandle<gameSmartObjectTransformSequenceDictionary>>(value);
		}

		[Ordinal(6)] 
		[RED("soMembership")] 
		public CHandle<gameSmartObjectMembership> SoMembership
		{
			get => GetPropertyValue<CHandle<gameSmartObjectMembership>>();
			set => SetPropertyValue<CHandle<gameSmartObjectMembership>>(value);
		}

		[Ordinal(7)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public gameSmartObjectsCompiledResource()
		{
			LocalBoundingBox = new() { Min = new(), Max = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
