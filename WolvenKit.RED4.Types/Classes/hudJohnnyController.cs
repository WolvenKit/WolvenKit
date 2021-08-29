using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudJohnnyController : gameuiHUDGameController
	{
		private inkTextWidgetReference _tourHeader;
		private inkTextWidgetReference _leftDates;
		private inkTextWidgetReference _rightDates;
		private inkWidgetReference _cancelled;
		private ScriptGameInstance _gameInstance;

		[Ordinal(9)] 
		[RED("tourHeader")] 
		public inkTextWidgetReference TourHeader
		{
			get => GetProperty(ref _tourHeader);
			set => SetProperty(ref _tourHeader, value);
		}

		[Ordinal(10)] 
		[RED("leftDates")] 
		public inkTextWidgetReference LeftDates
		{
			get => GetProperty(ref _leftDates);
			set => SetProperty(ref _leftDates, value);
		}

		[Ordinal(11)] 
		[RED("rightDates")] 
		public inkTextWidgetReference RightDates
		{
			get => GetProperty(ref _rightDates);
			set => SetProperty(ref _rightDates, value);
		}

		[Ordinal(12)] 
		[RED("cancelled")] 
		public inkWidgetReference Cancelled
		{
			get => GetProperty(ref _cancelled);
			set => SetProperty(ref _cancelled, value);
		}

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}
	}
}
