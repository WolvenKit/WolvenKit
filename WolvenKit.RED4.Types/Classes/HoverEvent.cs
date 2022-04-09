using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hooverOn")] 
		public CBool HooverOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HoverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
