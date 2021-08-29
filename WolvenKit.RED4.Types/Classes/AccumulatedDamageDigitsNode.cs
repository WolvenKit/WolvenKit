using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccumulatedDamageDigitsNode : RedBaseClass
	{
		private CBool _used;
		private entEntityID _entityID;
		private CWeakHandle<AccumulatedDamageDigitLogicController> _controller;
		private CBool _isDamageOverTime;

		[Ordinal(0)] 
		[RED("used")] 
		public CBool Used
		{
			get => GetProperty(ref _used);
			set => SetProperty(ref _used, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("controller")] 
		public CWeakHandle<AccumulatedDamageDigitLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(3)] 
		[RED("isDamageOverTime")] 
		public CBool IsDamageOverTime
		{
			get => GetProperty(ref _isDamageOverTime);
			set => SetProperty(ref _isDamageOverTime, value);
		}
	}
}
