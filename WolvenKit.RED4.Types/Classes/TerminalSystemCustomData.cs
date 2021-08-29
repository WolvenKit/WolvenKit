using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminalSystemCustomData : WidgetCustomData
	{
		private CInt32 _connectedDevices;

		[Ordinal(0)] 
		[RED("connectedDevices")] 
		public CInt32 ConnectedDevices
		{
			get => GetProperty(ref _connectedDevices);
			set => SetProperty(ref _connectedDevices, value);
		}
	}
}
