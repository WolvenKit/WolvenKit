using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animIKChainSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ikEndPointOffset")] 
		public Vector3 IkEndPointOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("ikEndRotationOffset")] 
		public Quaternion IkEndRotationOffset
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animIKChainSettings()
		{
			IkEndPointOffset = new();
			IkEndRotationOffset = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
