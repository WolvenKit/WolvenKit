using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickWheelStartUIStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("WheelItems")] 
		public CArray<QuickSlotCommand> WheelItems
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("dpadSlot")] 
		public CEnum<EDPadSlot> DpadSlot
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}

		public QuickWheelStartUIStructure()
		{
			WheelItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
