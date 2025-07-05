using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksTabAttributeInvestHoldFinished : redEvent
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public CEnum<PerkMenuAttribute> Attribute
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		public NewPerksTabAttributeInvestHoldFinished()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
