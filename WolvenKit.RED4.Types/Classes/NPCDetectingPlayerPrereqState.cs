using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDetectingPlayerPrereqState : gamePrereqState
	{
		private CWeakHandle<gameObject> _owner;
		private CHandle<redCallbackObject> _listenerID;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerID")] 
		public CHandle<redCallbackObject> ListenerID
		{
			get => GetProperty(ref _listenerID);
			set => SetProperty(ref _listenerID, value);
		}
	}
}
