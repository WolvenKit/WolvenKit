using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_MoveOnSpline : gameTransformAnimationTrackItemImpl
	{
		private NodeRef _splineNode;
		private CFloat _from;
		private CFloat _to;
		private CEnum<gameTransformAnimation_MoveOnSplineRotationMode> _rotationMode;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("splineNode")] 
		public NodeRef SplineNode
		{
			get => GetProperty(ref _splineNode);
			set => SetProperty(ref _splineNode, value);
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(2)] 
		[RED("to")] 
		public CFloat To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}

		[Ordinal(3)] 
		[RED("rotationMode")] 
		public CEnum<gameTransformAnimation_MoveOnSplineRotationMode> RotationMode
		{
			get => GetProperty(ref _rotationMode);
			set => SetProperty(ref _rotationMode, value);
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		public gameTransformAnimation_MoveOnSpline(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
