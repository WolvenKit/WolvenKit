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
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("localBounds")] 
		public Box LocalBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(7)] 
		[RED("allInteriorShapes")] 
		public CBool AllInteriorShapes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MinimapDataNode()
		{
			StreamingDistance = 975.000000F;
			LocalBounds = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
