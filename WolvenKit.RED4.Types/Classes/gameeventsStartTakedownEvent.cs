using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsStartTakedownEvent : redEvent
	{
		private CWeakHandle<gameObject> _target;
		private CFloat _slideTime;
		private CName _actionName;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("slideTime")] 
		public CFloat SlideTime
		{
			get => GetProperty(ref _slideTime);
			set => SetProperty(ref _slideTime, value);
		}

		[Ordinal(2)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public gameeventsStartTakedownEvent()
		{
			_slideTime = -1.000000F;
		}
	}
}
