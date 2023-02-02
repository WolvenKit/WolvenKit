using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyWindowsParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("windowsType")] 
		public CEnum<worldProxWindowsType> WindowsType
		{
			get => GetPropertyValue<CEnum<worldProxWindowsType>>();
			set => SetPropertyValue<CEnum<worldProxWindowsType>>(value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("distanceAboveProxy")] 
		public CFloat DistanceAboveProxy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("boolean")] 
		public CBool Boolean
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("removeSmallerThan")] 
		public CFloat RemoveSmallerThan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("distantWindowsEmissive")] 
		public CFloat DistantWindowsEmissive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("distantWindowsSize")] 
		public CFloat DistantWindowsSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("distantWindowsSaturation")] 
		public CFloat DistantWindowsSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("distantWindowsTurnedOf")] 
		public CFloat DistantWindowsTurnedOf
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldProxyWindowsParams()
		{
			WindowsType = Enums.worldProxWindowsType.PropagateWindows;
			Distance = 0.400000F;
			DistanceAboveProxy = 0.020000F;
			RemoveSmallerThan = 0.300000F;
			DistantWindowsEmissive = 1.000000F;
			DistantWindowsSize = 3.000000F;
			DistantWindowsSaturation = 0.750000F;
			DistantWindowsTurnedOf = 0.450000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
