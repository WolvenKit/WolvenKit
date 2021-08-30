using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCommonEntitySettings : RedBaseClass
	{
		private CName _onAttachEvent;
		private CName _onDetachEvent;
		private CBool _stopAllSoundsOnDetach;

		[Ordinal(0)] 
		[RED("onAttachEvent")] 
		public CName OnAttachEvent
		{
			get => GetProperty(ref _onAttachEvent);
			set => SetProperty(ref _onAttachEvent, value);
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get => GetProperty(ref _onDetachEvent);
			set => SetProperty(ref _onDetachEvent, value);
		}

		[Ordinal(2)] 
		[RED("stopAllSoundsOnDetach")] 
		public CBool StopAllSoundsOnDetach
		{
			get => GetProperty(ref _stopAllSoundsOnDetach);
			set => SetProperty(ref _stopAllSoundsOnDetach, value);
		}

		public audioCommonEntitySettings()
		{
			_stopAllSoundsOnDetach = true;
		}
	}
}
