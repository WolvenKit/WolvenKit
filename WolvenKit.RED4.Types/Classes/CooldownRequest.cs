using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CooldownRequest : IScriptable
	{
		private CHandle<BaseScriptableAction> _action;
		private CArray<PSOwnerData> _contactBook;
		private CEnum<RequestType> _requestTriggerType;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("contactBook")] 
		public CArray<PSOwnerData> ContactBook
		{
			get => GetProperty(ref _contactBook);
			set => SetProperty(ref _contactBook, value);
		}

		[Ordinal(2)] 
		[RED("requestTriggerType")] 
		public CEnum<RequestType> RequestTriggerType
		{
			get => GetProperty(ref _requestTriggerType);
			set => SetProperty(ref _requestTriggerType, value);
		}
	}
}
