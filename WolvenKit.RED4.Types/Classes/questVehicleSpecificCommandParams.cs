using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleSpecificCommandParams : ISerializable
	{
		private CBool _pushOtherVehiclesAside;
		private CBool _needDriver;
		private CFloat _secureTimeOut;

		[Ordinal(0)] 
		[RED("pushOtherVehiclesAside")] 
		public CBool PushOtherVehiclesAside
		{
			get => GetProperty(ref _pushOtherVehiclesAside);
			set => SetProperty(ref _pushOtherVehiclesAside, value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}
	}
}
