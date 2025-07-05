using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedItemsPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("chargesToCheck")] 
		public CEnum<EChargesAmount> ChargesToCheck
		{
			get => GetPropertyValue<CEnum<EChargesAmount>>();
			set => SetPropertyValue<CEnum<EChargesAmount>>(value);
		}

		[Ordinal(1)] 
		[RED("typeOfItem")] 
		public CEnum<EChargesItem> TypeOfItem
		{
			get => GetPropertyValue<CEnum<EChargesItem>>();
			set => SetPropertyValue<CEnum<EChargesItem>>(value);
		}

		public ChargedItemsPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
