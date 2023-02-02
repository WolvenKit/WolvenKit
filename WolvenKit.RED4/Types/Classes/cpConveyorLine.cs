using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpConveyorLine : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CName Template
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("physicsValidRanges")] 
		public CArray<Vector2> PhysicsValidRanges
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public cpConveyorLine()
		{
			PhysicsValidRanges = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
