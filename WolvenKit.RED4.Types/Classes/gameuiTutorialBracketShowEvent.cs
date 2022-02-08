using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Data = new() { Offset = new(), Size = new() };
		}
	}
}
