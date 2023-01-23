using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animVectorLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_VectorValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_VectorValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_VectorValue>>(value);
		}

		public animVectorLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
