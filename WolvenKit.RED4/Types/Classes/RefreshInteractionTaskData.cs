using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshInteractionTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<gamedeviceRequestType>>();
			set => SetPropertyValue<CEnum<gamedeviceRequestType>>(value);
		}

		[Ordinal(1)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public RefreshInteractionTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
