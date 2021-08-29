using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayPrereqEvent : redEvent
	{
		private CHandle<GameTimePrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<GameTimePrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
