using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDeathDirectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<gameeventsDeathDirection> Direction
		{
			get => GetPropertyValue<CEnum<gameeventsDeathDirection>>();
			set => SetPropertyValue<CEnum<gameeventsDeathDirection>>(value);
		}

		public gameeventsDeathDirectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
