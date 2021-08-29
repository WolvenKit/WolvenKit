using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		private CHandle<redEvent> _eventToExecute;

		[Ordinal(1)] 
		[RED("eventToExecute")] 
		public CHandle<redEvent> EventToExecute
		{
			get => GetProperty(ref _eventToExecute);
			set => SetProperty(ref _eventToExecute, value);
		}
	}
}
