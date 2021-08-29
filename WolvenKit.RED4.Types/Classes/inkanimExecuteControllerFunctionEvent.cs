using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimExecuteControllerFunctionEvent : inkanimEvent
	{
		private CName _controllerType;
		private CName _eventName;
		private CString _params;

		[Ordinal(1)] 
		[RED("controllerType")] 
		public CName ControllerType
		{
			get => GetProperty(ref _controllerType);
			set => SetProperty(ref _controllerType, value);
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CString Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
