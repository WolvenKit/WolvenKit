using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerSpatialAwareness : animAnimFeature
	{
		private Vector4 _leftClosestVector;
		private Vector4 _rightClosestVector;
		private Vector4 _upHitPosition;
		private CFloat _forwardDistance;

		[Ordinal(0)] 
		[RED("leftClosestVector")] 
		public Vector4 LeftClosestVector
		{
			get => GetProperty(ref _leftClosestVector);
			set => SetProperty(ref _leftClosestVector, value);
		}

		[Ordinal(1)] 
		[RED("rightClosestVector")] 
		public Vector4 RightClosestVector
		{
			get => GetProperty(ref _rightClosestVector);
			set => SetProperty(ref _rightClosestVector, value);
		}

		[Ordinal(2)] 
		[RED("upHitPosition")] 
		public Vector4 UpHitPosition
		{
			get => GetProperty(ref _upHitPosition);
			set => SetProperty(ref _upHitPosition, value);
		}

		[Ordinal(3)] 
		[RED("forwardDistance")] 
		public CFloat ForwardDistance
		{
			get => GetProperty(ref _forwardDistance);
			set => SetProperty(ref _forwardDistance, value);
		}

		public animAnimFeature_PlayerSpatialAwareness(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
