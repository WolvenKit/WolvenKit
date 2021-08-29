using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _previousChannel;
		private gamebbScriptID_Int32 _currentChannel;

		[Ordinal(7)] 
		[RED("PreviousChannel")] 
		public gamebbScriptID_Int32 PreviousChannel
		{
			get => GetProperty(ref _previousChannel);
			set => SetProperty(ref _previousChannel, value);
		}

		[Ordinal(8)] 
		[RED("CurrentChannel")] 
		public gamebbScriptID_Int32 CurrentChannel
		{
			get => GetProperty(ref _currentChannel);
			set => SetProperty(ref _currentChannel, value);
		}
	}
}
