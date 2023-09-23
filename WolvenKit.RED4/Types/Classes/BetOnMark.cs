using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BetOnMark : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("betOn")] 
		public CEnum<CasinoTableBet> BetOn
		{
			get => GetPropertyValue<CEnum<CasinoTableBet>>();
			set => SetPropertyValue<CEnum<CasinoTableBet>>(value);
		}

		[Ordinal(1)] 
		[RED("mark")] 
		public inkWidgetReference Mark
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public BetOnMark()
		{
			Mark = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
