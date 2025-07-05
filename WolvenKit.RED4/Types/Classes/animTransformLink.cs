using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animTransformLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_TransformValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_TransformValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_TransformValue>>(value);
		}

		public animTransformLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
