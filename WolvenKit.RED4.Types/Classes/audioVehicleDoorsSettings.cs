using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleDoorsSettings : RedBaseClass
	{
		private CName _openEvent;
		private CName _closeEvent;

		[Ordinal(0)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get => GetProperty(ref _openEvent);
			set => SetProperty(ref _openEvent, value);
		}

		[Ordinal(1)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get => GetProperty(ref _closeEvent);
			set => SetProperty(ref _closeEvent, value);
		}
	}
}
