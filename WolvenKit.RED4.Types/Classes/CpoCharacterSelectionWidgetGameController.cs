using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CpoCharacterSelectionWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("defaultCharacterTexturePart")] 
		public CString DefaultCharacterTexturePart
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("soloCharacterTexturePart")] 
		public CString SoloCharacterTexturePart
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("horizontalPanelsList")] 
		public CArray<CWeakHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkHorizontalPanelWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkHorizontalPanelWidget>>>(value);
		}

		[Ordinal(5)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CpoCharacterSelectionWidgetGameController()
		{
			HorizontalPanelsList = new();
			Amount = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
