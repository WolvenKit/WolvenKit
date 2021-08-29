using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimapDataNode : worldNode
	{
		private CResourceAsyncReference<minimapEncodedShapes> _encodedShapesRef;
		private Box _localBounds;
		private CBool _allInteriorShapes;

		[Ordinal(4)] 
		[RED("encodedShapesRef")] 
		public CResourceAsyncReference<minimapEncodedShapes> EncodedShapesRef
		{
			get => GetProperty(ref _encodedShapesRef);
			set => SetProperty(ref _encodedShapesRef, value);
		}

		[Ordinal(5)] 
		[RED("localBounds")] 
		public Box LocalBounds
		{
			get => GetProperty(ref _localBounds);
			set => SetProperty(ref _localBounds, value);
		}

		[Ordinal(6)] 
		[RED("allInteriorShapes")] 
		public CBool AllInteriorShapes
		{
			get => GetProperty(ref _allInteriorShapes);
			set => SetProperty(ref _allInteriorShapes, value);
		}
	}
}
