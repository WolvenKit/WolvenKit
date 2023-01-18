using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveLockRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<EItemOperationType> Operation
		{
			get => GetPropertyValue<CEnum<EItemOperationType>>();
			set => SetPropertyValue<CEnum<EItemOperationType>>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SaveLockRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
