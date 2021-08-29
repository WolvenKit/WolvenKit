using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExecutePuppetActionEvent : redEvent
	{
		private TweakDBID _actionID;
		private CHandle<PuppetAction> _action;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<PuppetAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
