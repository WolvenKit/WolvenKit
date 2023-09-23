using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivateC4 : ActionBool
	{
		[Ordinal(38)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public ActivateC4()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
