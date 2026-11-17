using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocConfirmationPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<GlamdocConfirmationPopupCloseData> Data
		{
			get => GetPropertyValue<CHandle<GlamdocConfirmationPopupCloseData>>();
			set => SetPropertyValue<CHandle<GlamdocConfirmationPopupCloseData>>(value);
		}

		[Ordinal(6)] 
		[RED("closeData")] 
		public CHandle<GlamdocConfirmationPopupCloseData> CloseData
		{
			get => GetPropertyValue<CHandle<GlamdocConfirmationPopupCloseData>>();
			set => SetPropertyValue<CHandle<GlamdocConfirmationPopupCloseData>>(value);
		}

		public GlamdocConfirmationPopup()
		{
			Root = new inkWidgetReference();
			ButtonOk = new inkWidgetReference();
			ButtonCancel = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
