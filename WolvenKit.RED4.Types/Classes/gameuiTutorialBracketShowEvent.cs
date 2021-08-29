using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialBracketShowEvent : redEvent
	{
		private gameTutorialBracketData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gameTutorialBracketData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
