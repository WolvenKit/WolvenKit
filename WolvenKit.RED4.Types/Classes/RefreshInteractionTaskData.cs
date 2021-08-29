using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshInteractionTaskData : gameScriptTaskData
	{
		private CEnum<gamedeviceRequestType> _requestType;
		private CWeakHandle<gameObject> _executor;

		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(1)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}
	}
}
