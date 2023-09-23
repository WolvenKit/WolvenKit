using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InnerBunkerCoreScreenGameController : BaseInnerBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("systems", 6)] 
		public CArrayFixedSize<inkWidgetReference> Systems
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("statuses", 6)] 
		public CArrayFixedSize<CEnum<InnerBunkerCoreStatus>> Statuses
		{
			get => GetPropertyValue<CArrayFixedSize<CEnum<InnerBunkerCoreStatus>>>();
			set => SetPropertyValue<CArrayFixedSize<CEnum<InnerBunkerCoreStatus>>>(value);
		}

		[Ordinal(4)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("processingPanel")] 
		public inkWidgetReference ProcessingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("failurePopup")] 
		public inkWidgetReference FailurePopup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("successPopup")] 
		public inkWidgetReference SuccessPopup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("systemCheckTimeOffline")] 
		public CFloat SystemCheckTimeOffline
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("systemCheckTimeUnresponsive")] 
		public CFloat SystemCheckTimeUnresponsive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("showResultTime")] 
		public CFloat ShowResultTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("systemsCheckAnimName")] 
		public CName SystemsCheckAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("coreStatusNormalAnimName")] 
		public CName CoreStatusNormalAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("coreStatusMalfunctionAnimName")] 
		public CName CoreStatusMalfunctionAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("coreStatusShutdownAnimName")] 
		public CName CoreStatusShutdownAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("coreStatusShutingDownAnimName")] 
		public CName CoreStatusShutingDownAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("failurePopupAnimName")] 
		public CName FailurePopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("stage")] 
		public CEnum<InnerBunkerCoreStage> Stage
		{
			get => GetPropertyValue<CEnum<InnerBunkerCoreStage>>();
			set => SetPropertyValue<CEnum<InnerBunkerCoreStage>>(value);
		}

		[Ordinal(19)] 
		[RED("sysIndex")] 
		public CInt32 SysIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("systemsCheckAnimProxy")] 
		public CHandle<inkanimProxy> SystemsCheckAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("resultPopupAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("coreStatusAnimProxy")] 
		public CHandle<inkanimProxy> CoreStatusAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public InnerBunkerCoreScreenGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
