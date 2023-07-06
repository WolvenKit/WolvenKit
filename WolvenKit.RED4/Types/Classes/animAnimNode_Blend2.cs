using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Blend2 : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("minInputValue")] 
		public CFloat MinInputValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("maxInputValue")] 
		public CFloat MaxInputValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(15)] 
		[RED("firstInputNode")] 
		public animPoseLink FirstInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(16)] 
		[RED("secondInputNode")] 
		public animPoseLink SecondInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(17)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_Blend2()
		{
			Id = uint.MaxValue;
			MaxInputValue = 1.000000F;
			FirstInputNode = new animPoseLink();
			SecondInputNode = new animPoseLink();
			WeightNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
