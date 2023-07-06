using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimapDataNode : worldNode
	{
		[Ordinal(4)] 
		[RED("encodedShapesRef")] 
		public CResourceAsyncReference<minimapEncodedShapes> EncodedShapesRef
		{
			get => GetPropertyValue<CResourceAsyncReference<minimapEncodedShapes>>();
			set => SetPropertyValue<CResourceAsyncReference<minimapEncodedShapes>>(value);
		}

		[Ordinal(5)] 
		[RED("localBounds")] 
		public Box LocalBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(6)] 
		[RED("allInteriorShapes")] 
		public CBool AllInteriorShapes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MinimapDataNode()
		{
			LocalBounds = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
