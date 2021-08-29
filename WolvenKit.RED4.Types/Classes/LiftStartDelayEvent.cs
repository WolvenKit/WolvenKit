using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftStartDelayEvent : redEvent
	{
		private CInt32 _targetFloor;

		[Ordinal(0)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetProperty(ref _targetFloor);
			set => SetProperty(ref _targetFloor, value);
		}
	}
}
