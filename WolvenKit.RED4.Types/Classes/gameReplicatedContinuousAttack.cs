using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedContinuousAttack : RedBaseClass
	{
		private netTime _startTimeStamp;
		private netTime _stopTimeStamp;
		private TweakDBID _attackId;

		[Ordinal(0)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get => GetProperty(ref _startTimeStamp);
			set => SetProperty(ref _startTimeStamp, value);
		}

		[Ordinal(1)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get => GetProperty(ref _stopTimeStamp);
			set => SetProperty(ref _stopTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetProperty(ref _attackId);
			set => SetProperty(ref _attackId, value);
		}
	}
}
