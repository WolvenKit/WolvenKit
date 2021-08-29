using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOVotingDevice : CPOMissionDevice
	{
		private CName _deviceName;

		[Ordinal(45)] 
		[RED("deviceName")] 
		public CName DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}
	}
}
