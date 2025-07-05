using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLightListenerComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("intersectionRef")] 
		public NodeRef IntersectionRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldTrafficLightListenerComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
