using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SubscribeToModButtonController : GenericModButtonController
	{
		[Ordinal(43)] 
		[RED("isDeactivatedBecauseInPauseMenu")] 
		public CBool IsDeactivatedBecauseInPauseMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SubscribeToModButtonController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
