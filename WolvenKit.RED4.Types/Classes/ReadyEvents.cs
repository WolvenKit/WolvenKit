using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReadyEvents : WeaponEventsTransition
	{
		private CFloat _timeStamp;

		[Ordinal(3)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}
	}
}
