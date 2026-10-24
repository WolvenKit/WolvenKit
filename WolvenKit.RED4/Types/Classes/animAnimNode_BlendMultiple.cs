using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendMultiple : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("inputValues")] 
		public CArray<CFloat> InputValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("sortedInputValues")] 
		public CArray<CFloat> SortedInputValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("minWeight")] 
		public CFloat MinWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxWeight")] 
		public CFloat MaxWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("radialBlending")] 
		public CBool RadialBlending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(8)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetPropertyValue<CHandle<animIMotionTableProvider>>();
			set => SetPropertyValue<CHandle<animIMotionTableProvider>>(value);
		}

		[Ordinal(9)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(10)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get => GetPropertyValue<CArray<animPoseLink>>();
			set => SetPropertyValue<CArray<animPoseLink>>(value);
		}

		public animAnimNode_BlendMultiple()
		{
			Id = uint.MaxValue;
			InputValues = new();
			SortedInputValues = new();
			MaxWeight = 1.000000F;
			WeightNode = new animFloatLink();
			InputNodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
