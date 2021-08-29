using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamesmartGunUITargetParameters : RedBaseClass
	{
		private Vector2 _pos;
		private CEnum<gamesmartGunTargetState> _state;
		private CFloat _distance;
		private CFloat _accuracy;
		private CBool _isLocked;
		private CFloat _timeLocking;
		private CFloat _timeUnlocking;
		private CFloat _timeOccluded;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamesmartGunTargetState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(3)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetProperty(ref _accuracy);
			set => SetProperty(ref _accuracy, value);
		}

		[Ordinal(4)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(5)] 
		[RED("timeLocking")] 
		public CFloat TimeLocking
		{
			get => GetProperty(ref _timeLocking);
			set => SetProperty(ref _timeLocking, value);
		}

		[Ordinal(6)] 
		[RED("timeUnlocking")] 
		public CFloat TimeUnlocking
		{
			get => GetProperty(ref _timeUnlocking);
			set => SetProperty(ref _timeUnlocking, value);
		}

		[Ordinal(7)] 
		[RED("timeOccluded")] 
		public CFloat TimeOccluded
		{
			get => GetProperty(ref _timeOccluded);
			set => SetProperty(ref _timeOccluded, value);
		}

		[Ordinal(8)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}
	}
}
