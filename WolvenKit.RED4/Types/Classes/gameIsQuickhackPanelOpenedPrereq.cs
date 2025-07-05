using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameIsQuickhackPanelOpenedPrereq : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameIsQuickhackPanelOpenedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
