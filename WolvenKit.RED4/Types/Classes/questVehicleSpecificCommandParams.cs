using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleSpecificCommandParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("pushOtherVehiclesAside")] 
		public CBool PushOtherVehiclesAside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questVehicleSpecificCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
