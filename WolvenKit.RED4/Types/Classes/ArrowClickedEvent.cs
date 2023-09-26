using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArrowClickedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<Direction> Direction
		{
			get => GetPropertyValue<CEnum<Direction>>();
			set => SetPropertyValue<CEnum<Direction>>(value);
		}

		public ArrowClickedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
