using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WoundedTriggeredPrereqState : gamePrereqState
	{
		private CWeakHandle<gameObject> _owner;
		private CHandle<redCallbackObject> _listenerInt;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerInt")] 
		public CHandle<redCallbackObject> ListenerInt
		{
			get => GetProperty(ref _listenerInt);
			set => SetProperty(ref _listenerInt, value);
		}
	}
}
