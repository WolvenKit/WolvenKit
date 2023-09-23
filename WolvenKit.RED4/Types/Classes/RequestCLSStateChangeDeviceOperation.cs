using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestCLSStateChangeDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get => GetPropertyValue<CEnum<ECLSForcedState>>();
			set => SetPropertyValue<CEnum<ECLSForcedState>>(value);
		}

		[Ordinal(6)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(8)] 
		[RED("removePreviousRequests")] 
		public CBool RemovePreviousRequests
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RequestCLSStateChangeDeviceOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
