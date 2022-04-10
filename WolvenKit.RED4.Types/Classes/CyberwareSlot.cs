using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareSlot : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("IconImageRef")] 
		public inkImageWidgetReference IconImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("SlotEquipArea")] 
		public CEnum<gamedataEquipmentArea> SlotEquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(4)] 
		[RED("NumSlots")] 
		public CInt32 NumSlots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CyberwareSlot()
		{
			IconImageRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
