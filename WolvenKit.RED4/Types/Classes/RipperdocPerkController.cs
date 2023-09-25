using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocPerkController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<RipperdocPerkData> PerkData
		{
			get => GetPropertyValue<CHandle<RipperdocPerkData>>();
			set => SetPropertyValue<CHandle<RipperdocPerkData>>(value);
		}

		[Ordinal(3)] 
		[RED("hoverEvent")] 
		public CHandle<RipperdocPerkHoverEvent> HoverEvent
		{
			get => GetPropertyValue<CHandle<RipperdocPerkHoverEvent>>();
			set => SetPropertyValue<CHandle<RipperdocPerkHoverEvent>>(value);
		}

		public RipperdocPerkController()
		{
			Icon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
