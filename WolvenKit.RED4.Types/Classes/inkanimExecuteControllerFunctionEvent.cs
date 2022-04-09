using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimExecuteControllerFunctionEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("controllerType")] 
		public CName ControllerType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CString Params
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkanimExecuteControllerFunctionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
