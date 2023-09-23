using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksPerkContainerLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("slotIdentifier")] 
		public CEnum<gamedataNewPerkSlotType> SlotIdentifier
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(2)] 
		[RED("perkWidget")] 
		public inkWidgetReference PerkWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("wiresConnections")] 
		public CArray<NewPerksWireConnection> WiresConnections
		{
			get => GetPropertyValue<CArray<NewPerksWireConnection>>();
			set => SetPropertyValue<CArray<NewPerksWireConnection>>(value);
		}

		public NewPerksPerkContainerLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
