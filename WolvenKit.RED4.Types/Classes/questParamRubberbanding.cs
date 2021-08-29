using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questParamRubberbanding : ISerializable
	{
		private CHandle<questUniversalRef> _targetRef;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CBool _stopAndWait;
		private CBool _teleportToCatchUp;
		private CBool _stayInFront;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public CHandle<questUniversalRef> TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(3)] 
		[RED("stopAndWait")] 
		public CBool StopAndWait
		{
			get => GetProperty(ref _stopAndWait);
			set => SetProperty(ref _stopAndWait, value);
		}

		[Ordinal(4)] 
		[RED("teleportToCatchUp")] 
		public CBool TeleportToCatchUp
		{
			get => GetProperty(ref _teleportToCatchUp);
			set => SetProperty(ref _teleportToCatchUp, value);
		}

		[Ordinal(5)] 
		[RED("stayInFront")] 
		public CBool StayInFront
		{
			get => GetProperty(ref _stayInFront);
			set => SetProperty(ref _stayInFront, value);
		}
	}
}
