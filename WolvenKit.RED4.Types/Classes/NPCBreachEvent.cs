using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCBreachEvent : redEvent
	{
		private CEnum<gameuiHackingMinigameState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameuiHackingMinigameState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
