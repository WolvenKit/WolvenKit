using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioTermsPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("hyperlinkButtonRef1")] 
		public inkWidgetReference HyperlinkButtonRef1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hyperlinkButtonRef2")] 
		public inkWidgetReference HyperlinkButtonRef2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hyperlinkButtonRef3")] 
		public inkWidgetReference HyperlinkButtonRef3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("agreeBtnRef")] 
		public inkWidgetReference AgreeBtnRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("NoThanksBtnRef")] 
		public inkWidgetReference NoThanksBtnRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("toggleSelectBtnRef")] 
		public inkWidgetReference ToggleSelectBtnRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("agreeTxtRef")] 
		public inkTextWidgetReference AgreeTxtRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("questionOne_ContainerRef")] 
		public inkWidgetReference QuestionOne_ContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("questionTwo_ContainerRef")] 
		public inkWidgetReference QuestionTwo_ContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("questionOne_ToggleFillRef")] 
		public inkWidgetReference QuestionOne_ToggleFillRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("questionTwo_ToggleFillRef")] 
		public inkWidgetReference QuestionTwo_ToggleFillRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("consoleWarning")] 
		public inkTextWidgetReference ConsoleWarning
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("ps5Warning")] 
		public inkRichTextBoxWidgetReference Ps5Warning
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<ModioTermsPopupData> Data
		{
			get => GetPropertyValue<CHandle<ModioTermsPopupData>>();
			set => SetPropertyValue<CHandle<ModioTermsPopupData>>(value);
		}

		[Ordinal(16)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(17)] 
		[RED("acceptButtonController")] 
		public CWeakHandle<inkButtonController> AcceptButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(18)] 
		[RED("questionOne_State")] 
		public CBool QuestionOne_State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("questionTwo_State")] 
		public CBool QuestionTwo_State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ModioTermsPopupController()
		{
			HyperlinkButtonRef1 = new inkWidgetReference();
			HyperlinkButtonRef2 = new inkWidgetReference();
			HyperlinkButtonRef3 = new inkWidgetReference();
			AgreeBtnRef = new inkWidgetReference();
			NoThanksBtnRef = new inkWidgetReference();
			ToggleSelectBtnRef = new inkWidgetReference();
			AgreeTxtRef = new inkTextWidgetReference();
			QuestionOne_ContainerRef = new inkWidgetReference();
			QuestionTwo_ContainerRef = new inkWidgetReference();
			QuestionOne_ToggleFillRef = new inkWidgetReference();
			QuestionTwo_ToggleFillRef = new inkWidgetReference();
			ConsoleWarning = new inkTextWidgetReference();
			Ps5Warning = new inkRichTextBoxWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
