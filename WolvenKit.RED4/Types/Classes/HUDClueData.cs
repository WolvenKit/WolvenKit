using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDClueData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isClue")] 
		public CBool IsClue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HUDClueData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
