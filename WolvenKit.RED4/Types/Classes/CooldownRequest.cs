using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CooldownRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get => GetPropertyValue<CHandle<BaseScriptableAction>>();
			set => SetPropertyValue<CHandle<BaseScriptableAction>>(value);
		}

		[Ordinal(1)] 
		[RED("contactBook")] 
		public CArray<PSOwnerData> ContactBook
		{
			get => GetPropertyValue<CArray<PSOwnerData>>();
			set => SetPropertyValue<CArray<PSOwnerData>>(value);
		}

		[Ordinal(2)] 
		[RED("requestTriggerType")] 
		public CEnum<RequestType> RequestTriggerType
		{
			get => GetPropertyValue<CEnum<RequestType>>();
			set => SetPropertyValue<CEnum<RequestType>>(value);
		}

		public CooldownRequest()
		{
			ContactBook = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
