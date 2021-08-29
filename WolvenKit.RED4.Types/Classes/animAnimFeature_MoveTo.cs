using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_MoveTo : animAnimFeature
	{
		private Vector4 _initialFwdVector;
		private Vector4 _targetPositionWs;
		private Vector4 _targetDirectionWs;
		private CFloat _timeToMove;

		[Ordinal(0)] 
		[RED("initialFwdVector")] 
		public Vector4 InitialFwdVector
		{
			get => GetProperty(ref _initialFwdVector);
			set => SetProperty(ref _initialFwdVector, value);
		}

		[Ordinal(1)] 
		[RED("targetPositionWs")] 
		public Vector4 TargetPositionWs
		{
			get => GetProperty(ref _targetPositionWs);
			set => SetProperty(ref _targetPositionWs, value);
		}

		[Ordinal(2)] 
		[RED("targetDirectionWs")] 
		public Vector4 TargetDirectionWs
		{
			get => GetProperty(ref _targetDirectionWs);
			set => SetProperty(ref _targetDirectionWs, value);
		}

		[Ordinal(3)] 
		[RED("timeToMove")] 
		public CFloat TimeToMove
		{
			get => GetProperty(ref _timeToMove);
			set => SetProperty(ref _timeToMove, value);
		}
	}
}
