using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestDeviceWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		private CArray<gamePersistentID> _requesters;

		[Ordinal(2)] 
		[RED("requesters")] 
		public CArray<gamePersistentID> Requesters
		{
			get => GetProperty(ref _requesters);
			set => SetProperty(ref _requesters, value);
		}
	}
}
