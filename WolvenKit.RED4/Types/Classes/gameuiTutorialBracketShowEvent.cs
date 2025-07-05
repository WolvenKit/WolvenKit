using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialBracketShowEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public gameTutorialBracketData Data
		{
			get => GetPropertyValue<gameTutorialBracketData>();
			set => SetPropertyValue<gameTutorialBracketData>(value);
		}

		public gameuiTutorialBracketShowEvent()
		{
			Data = new gameTutorialBracketData { Offset = new Vector2(), Size = new Vector2() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
