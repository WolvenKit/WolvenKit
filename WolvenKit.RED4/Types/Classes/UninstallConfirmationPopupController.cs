using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UninstallConfirmationPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("cancelButton")] 
		public inkWidgetReference CancelButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("checkboxButton")] 
		public inkWidgetReference CheckboxButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("checkboxFill")] 
		public inkWidgetReference CheckboxFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("notificationText")] 
		public inkTextWidgetReference NotificationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("checkboxText")] 
		public inkTextWidgetReference CheckboxText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("bDontShowAgain")] 
		public CBool BDontShowAgain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("modMenuRef")] 
		public CWeakHandle<BrowserModsMenuGameController> ModMenuRef
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<ModioConfirmUninstallData> Data
		{
			get => GetPropertyValue<CHandle<ModioConfirmUninstallData>>();
			set => SetPropertyValue<CHandle<ModioConfirmUninstallData>>(value);
		}

		[Ordinal(11)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("closeAnim")] 
		public CHandle<inkanimProxy> CloseAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public UninstallConfirmationPopupController()
		{
			ConfirmButton = new inkWidgetReference();
			CancelButton = new inkWidgetReference();
			CheckboxButton = new inkWidgetReference();
			CheckboxFill = new inkWidgetReference();
			NotificationText = new inkTextWidgetReference();
			CheckboxText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
