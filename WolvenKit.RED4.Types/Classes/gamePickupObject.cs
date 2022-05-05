using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePickupObject : gameObject
	{
		[Ordinal(35)] 
		[RED("interactionTag")] 
		public CName InteractionTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamePickupObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
