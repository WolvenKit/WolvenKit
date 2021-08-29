using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceObstacle : RedBaseClass
	{
		private CFloat _interval;
		private CName _dynObjectType;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		[Ordinal(1)] 
		[RED("dynObjectType")] 
		public CName DynObjectType
		{
			get => GetProperty(ref _dynObjectType);
			set => SetProperty(ref _dynObjectType, value);
		}
	}
}
