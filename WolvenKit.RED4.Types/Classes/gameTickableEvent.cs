using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTickableEvent : redEvent
	{
		private CEnum<gameTickableEventState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameTickableEventState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
