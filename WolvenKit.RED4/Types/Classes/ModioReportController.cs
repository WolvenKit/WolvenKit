using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioReportController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("reportTypeBtnRef1")] 
		public inkWidgetReference ReportTypeBtnRef1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("reportTypeBtnRef2")] 
		public inkWidgetReference ReportTypeBtnRef2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("reportTypeBtnRef3")] 
		public inkWidgetReference ReportTypeBtnRef3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("reportTypeBtnRef4")] 
		public inkWidgetReference ReportTypeBtnRef4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("reportTypeBtnRef5")] 
		public inkWidgetReference ReportTypeBtnRef5
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("reportTypeBtnRef6")] 
		public inkWidgetReference ReportTypeBtnRef6
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("reportTypeBtnRef7")] 
		public inkWidgetReference ReportTypeBtnRef7
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("reportPanel1")] 
		public inkWidgetReference ReportPanel1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("reportPanel2")] 
		public inkWidgetReference ReportPanel2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("reportTypeBtnInStep2Ref")] 
		public inkWidgetReference ReportTypeBtnInStep2Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("reportTypeLabelInStep2Ref")] 
		public inkTextWidgetReference ReportTypeLabelInStep2Ref
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("titleMsgRef")] 
		public inkTextWidgetReference TitleMsgRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("hyperlinkButtonRef1")] 
		public inkWidgetReference HyperlinkButtonRef1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("hyperlinkButtonRef2")] 
		public inkWidgetReference HyperlinkButtonRef2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("agreeBtnRef")] 
		public inkWidgetReference AgreeBtnRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("NoThanksBtnRef")] 
		public inkWidgetReference NoThanksBtnRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("detailText")] 
		public inkTextInputWidgetReference DetailText
		{
			get => GetPropertyValue<inkTextInputWidgetReference>();
			set => SetPropertyValue<inkTextInputWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("detailArea")] 
		public inkWidgetReference DetailArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("SelectModLabelRef")] 
		public inkTextWidgetReference SelectModLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("SelectModImg")] 
		public inkImageWidgetReference SelectModImg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("detailTextArea")] 
		public inkWidgetReference DetailTextArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("currentModID")] 
		public CInt64 CurrentModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(24)] 
		[RED("currentReportType")] 
		public CInt8 CurrentReportType
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(25)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(26)] 
		[RED("modMenuController")] 
		public CWeakHandle<inkIWidgetController> ModMenuController
		{
			get => GetPropertyValue<CWeakHandle<inkIWidgetController>>();
			set => SetPropertyValue<CWeakHandle<inkIWidgetController>>(value);
		}

		[Ordinal(27)] 
		[RED("acceptButtonController")] 
		public CWeakHandle<inkButtonController> AcceptButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(28)] 
		[RED("bIsOpenIMGDialog")] 
		public CBool BIsOpenIMGDialog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ModioReportController()
		{
			ReportTypeBtnRef1 = new inkWidgetReference();
			ReportTypeBtnRef2 = new inkWidgetReference();
			ReportTypeBtnRef3 = new inkWidgetReference();
			ReportTypeBtnRef4 = new inkWidgetReference();
			ReportTypeBtnRef5 = new inkWidgetReference();
			ReportTypeBtnRef6 = new inkWidgetReference();
			ReportTypeBtnRef7 = new inkWidgetReference();
			ReportPanel1 = new inkWidgetReference();
			ReportPanel2 = new inkWidgetReference();
			ReportTypeBtnInStep2Ref = new inkWidgetReference();
			ReportTypeLabelInStep2Ref = new inkTextWidgetReference();
			TitleMsgRef = new inkTextWidgetReference();
			HyperlinkButtonRef1 = new inkWidgetReference();
			HyperlinkButtonRef2 = new inkWidgetReference();
			AgreeBtnRef = new inkWidgetReference();
			NoThanksBtnRef = new inkWidgetReference();
			DetailText = new inkTextInputWidgetReference();
			DetailArea = new inkWidgetReference();
			SelectModLabelRef = new inkTextWidgetReference();
			SelectModImg = new inkImageWidgetReference();
			DetailTextArea = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
