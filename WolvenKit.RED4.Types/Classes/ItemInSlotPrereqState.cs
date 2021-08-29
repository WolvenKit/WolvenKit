using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInSlotPrereqState : gamePrereqState
	{
		private CHandle<ItemInSlotCallback> _listener;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<ItemInSlotCallback> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
