using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class tarotCardLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public TarotCardData Data
		{
			get => GetPropertyValue<TarotCardData>();
			set => SetPropertyValue<TarotCardData>(value);
		}

		public tarotCardLogicController()
		{
			Image = new();
			Highlight = new();
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
