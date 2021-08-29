using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleDriveToPointEvent : redEvent
	{
		private Vector3 _targetPos;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;

		[Ordinal(0)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get => GetProperty(ref _targetPos);
			set => SetProperty(ref _targetPos, value);
		}

		[Ordinal(1)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(2)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}
	}
}
