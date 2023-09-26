using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpTestPlatformController : gameObject
	{
		[Ordinal(36)] 
		[RED("platform")] 
		public NodeRef Platform
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(37)] 
		[RED("pointA")] 
		public NodeRef PointA
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(38)] 
		[RED("pointB")] 
		public NodeRef PointB
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(39)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public cpTestPlatformController()
		{
			Speed = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
