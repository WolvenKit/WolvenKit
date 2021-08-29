using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedShotData : RedBaseClass
	{
		private netTime _timeStamp;
		private TweakDBID _attackId;
		private CWeakHandle<gameObject> _target;
		private Vector3 _targetLocalOffset;

		[Ordinal(0)] 
		[RED("timeStamp")] 
		public netTime TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(1)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetProperty(ref _attackId);
			set => SetProperty(ref _attackId, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(3)] 
		[RED("targetLocalOffset")] 
		public Vector3 TargetLocalOffset
		{
			get => GetProperty(ref _targetLocalOffset);
			set => SetProperty(ref _targetLocalOffset, value);
		}
	}
}
