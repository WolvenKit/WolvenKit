using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveConsumableDelayedEvent : redEvent
	{
		private CHandle<ConsumeAction> _consumeAction;

		[Ordinal(0)] 
		[RED("consumeAction")] 
		public CHandle<ConsumeAction> ConsumeAction
		{
			get => GetProperty(ref _consumeAction);
			set => SetProperty(ref _consumeAction, value);
		}
	}
}
