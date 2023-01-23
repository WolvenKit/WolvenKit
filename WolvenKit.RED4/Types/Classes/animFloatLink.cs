using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFloatLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_FloatValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_FloatValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_FloatValue>>(value);
		}

		public animFloatLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
