using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeStateEvent : redEvent
	{
		private CEnum<vehicleEState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
