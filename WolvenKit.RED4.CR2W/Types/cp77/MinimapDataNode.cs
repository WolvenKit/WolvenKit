using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapDataNode : worldNode
	{
		private raRef<minimapEncodedShapes> _encodedShapesRef;
		private Box _localBounds;
		private CBool _allInteriorShapes;

		[Ordinal(4)] 
		[RED("encodedShapesRef")] 
		public raRef<minimapEncodedShapes> EncodedShapesRef
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

		public MinimapDataNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
