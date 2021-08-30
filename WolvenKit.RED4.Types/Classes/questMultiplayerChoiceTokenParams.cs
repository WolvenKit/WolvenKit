using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMultiplayerChoiceTokenParams : RedBaseClass
	{
		private CUInt32 _timeout;
		private CName _compatibleDeviceName;

		[Ordinal(0)] 
		[RED("timeout")] 
		public CUInt32 Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetProperty(ref _compatibleDeviceName);
			set => SetProperty(ref _compatibleDeviceName, value);
		}

		public questMultiplayerChoiceTokenParams()
		{
			_timeout = 15;
		}
	}
}
