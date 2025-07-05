using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClueStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isClue")] 
		public CBool IsClue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ClueStatusNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
