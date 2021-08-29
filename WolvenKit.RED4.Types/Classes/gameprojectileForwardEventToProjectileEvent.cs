using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileForwardEventToProjectileEvent : redEvent
	{
		private CHandle<redEvent> _eventToForward;

		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<redEvent> EventToForward
		{
			get => GetProperty(ref _eventToForward);
			set => SetProperty(ref _eventToForward, value);
		}
	}
}
