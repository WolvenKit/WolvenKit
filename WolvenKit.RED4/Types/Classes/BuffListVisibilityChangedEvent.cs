using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuffListVisibilityChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hasBuffs")] 
		public CBool HasBuffs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BuffListVisibilityChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
