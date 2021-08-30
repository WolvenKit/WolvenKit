using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorWaitingMountCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _requestArgument;
		private CName _callbackName;

		[Ordinal(1)] 
		[RED("requestArgument")] 
		public CHandle<AIArgumentMapping> RequestArgument
		{
			get => GetProperty(ref _requestArgument);
			set => SetProperty(ref _requestArgument, value);
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		public AIbehaviorWaitingMountCommandConditionDefinition()
		{
			_callbackName = "OnMountRequest";
		}
	}
}
