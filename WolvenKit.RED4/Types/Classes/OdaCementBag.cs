using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OdaCementBag : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("onCooldown")] 
		public CBool OnCooldown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OdaCementBag()
		{
			ControllerTypeName = "OdaCementBagController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
