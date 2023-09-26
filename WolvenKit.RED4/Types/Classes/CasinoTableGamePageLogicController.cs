using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CasinoTableGamePageLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("cash")] 
		public inkTextWidgetReference Cash
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bet")] 
		public inkTextWidgetReference Bet
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("marks")] 
		public CArray<BetOnMark> Marks
		{
			get => GetPropertyValue<CArray<BetOnMark>>();
			set => SetPropertyValue<CArray<BetOnMark>>(value);
		}

		public CasinoTableGamePageLogicController()
		{
			Cash = new inkTextWidgetReference();
			Bet = new inkTextWidgetReference();
			Marks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
