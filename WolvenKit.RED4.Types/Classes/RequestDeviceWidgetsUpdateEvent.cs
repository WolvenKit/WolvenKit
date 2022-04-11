using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestDeviceWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] 
		[RED("requesters")] 
		public CArray<gamePersistentID> Requesters
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		public RequestDeviceWidgetsUpdateEvent()
		{
			Requesters = new();
		}
	}
}
