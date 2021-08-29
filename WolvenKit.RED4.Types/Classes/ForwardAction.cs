using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForwardAction : redEvent
	{
		private gamePersistentID _requester;
		private CHandle<ScriptableDeviceAction> _actionToForward;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get => GetProperty(ref _actionToForward);
			set => SetProperty(ref _actionToForward, value);
		}
	}
}
