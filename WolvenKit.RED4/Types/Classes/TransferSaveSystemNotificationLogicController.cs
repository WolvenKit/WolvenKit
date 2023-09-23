using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransferSaveSystemNotificationLogicController : inkGenericSystemNotificationLogicController
	{
		[Ordinal(9)] 
		[RED("contentBlock")] 
		public inkWidgetReference ContentBlock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("spinnerBlock")] 
		public inkWidgetReference SpinnerBlock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("errorBlock")] 
		public inkWidgetReference ErrorBlock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("saveImageContainer")] 
		public inkWidgetReference SaveImageContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("saveImage")] 
		public inkImageWidgetReference SaveImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("saveImageEmpty")] 
		public inkWidgetReference SaveImageEmpty
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("saveImageSpinner")] 
		public inkWidgetReference SaveImageSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("spinnerText")] 
		public inkTextWidgetReference SpinnerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("errorText")] 
		public inkTextWidgetReference ErrorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("proceedButtonWidget")] 
		public inkWidgetReference ProceedButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("cancelButtonWidget")] 
		public inkWidgetReference CancelButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("systemRequestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(22)] 
		[RED("transferSaveData")] 
		public CWeakHandle<TransferSaveData> TransferSaveData
		{
			get => GetPropertyValue<CWeakHandle<TransferSaveData>>();
			set => SetPropertyValue<CWeakHandle<TransferSaveData>>(value);
		}

		[Ordinal(23)] 
		[RED("transferSaveDataSet")] 
		public CBool TransferSaveDataSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("systemRequestsHandlerSet")] 
		public CBool SystemRequestsHandlerSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("cancelButtonHovered")] 
		public CBool CancelButtonHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("currentState")] 
		public CEnum<TransferSaveState> CurrentState
		{
			get => GetPropertyValue<CEnum<TransferSaveState>>();
			set => SetPropertyValue<CEnum<TransferSaveState>>(value);
		}

		public TransferSaveSystemNotificationLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
