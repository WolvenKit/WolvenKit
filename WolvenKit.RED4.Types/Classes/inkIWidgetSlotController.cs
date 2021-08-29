using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkIWidgetSlotController : inkWidgetLogicController
	{
		private CName _slotID;
		private inkWidgetLayout _layout;

		[Ordinal(1)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get => GetProperty(ref _layout);
			set => SetProperty(ref _layout, value);
		}
	}
}
