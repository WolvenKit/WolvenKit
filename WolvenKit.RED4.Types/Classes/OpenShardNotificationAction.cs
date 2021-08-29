using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OpenShardNotificationAction : GenericNotificationBaseAction
	{
		private CHandle<gameuiGameSystemUI> _eventDispatcher;

		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public CHandle<gameuiGameSystemUI> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}
	}
}
