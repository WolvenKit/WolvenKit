using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QHackWheelItemChangedEvent : redEvent
	{
		private CHandle<QuickhackData> _commandData;
		private CBool _currentEmpty;

		[Ordinal(0)] 
		[RED("commandData")] 
		public CHandle<QuickhackData> CommandData
		{
			get => GetProperty(ref _commandData);
			set => SetProperty(ref _commandData, value);
		}

		[Ordinal(1)] 
		[RED("currentEmpty")] 
		public CBool CurrentEmpty
		{
			get => GetProperty(ref _currentEmpty);
			set => SetProperty(ref _currentEmpty, value);
		}
	}
}
