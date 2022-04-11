using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayPrereqEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<GameTimePrereqState> State
		{
			get => GetPropertyValue<CHandle<GameTimePrereqState>>();
			set => SetPropertyValue<CHandle<GameTimePrereqState>>(value);
		}
	}
}
