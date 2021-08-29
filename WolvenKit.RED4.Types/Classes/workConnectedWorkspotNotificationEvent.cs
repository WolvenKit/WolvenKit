using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workConnectedWorkspotNotificationEvent : redEvent
	{
		private CName _evtName;

		[Ordinal(0)] 
		[RED("evtName")] 
		public CName EvtName
		{
			get => GetProperty(ref _evtName);
			set => SetProperty(ref _evtName, value);
		}
	}
}
