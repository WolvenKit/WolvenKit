using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTickableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameTickableEventState> State
		{
			get => GetPropertyValue<CEnum<gameTickableEventState>>();
			set => SetPropertyValue<CEnum<gameTickableEventState>>(value);
		}
	}
}
