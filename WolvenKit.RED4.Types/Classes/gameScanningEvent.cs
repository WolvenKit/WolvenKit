using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningEvent : redEvent
	{
		private CEnum<gameScanningState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameScanningState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public gameScanningEvent()
		{
			_state = new() { Value = Enums.gameScanningState.Stopped };
		}
	}
}
