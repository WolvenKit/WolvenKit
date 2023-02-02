using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealQuickhackMenu : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("shouldOpenWheel")] 
		public CBool ShouldOpenWheel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealQuickhackMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
