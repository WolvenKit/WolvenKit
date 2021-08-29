using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyWindowsParams : RedBaseClass
	{
		private CEnum<worldProxWindowsType> _windowsType;
		private CFloat _distance;
		private CFloat _distanceAboveProxy;
		private CBool _boolean;
		private CFloat _removeSmallerThan;
		private CFloat _distantWindowsEmissive;
		private CFloat _distantWindowsSize;
		private CFloat _distantWindowsSaturation;
		private CFloat _distantWindowsTurnedOf;

		[Ordinal(0)] 
		[RED("windowsType")] 
		public CEnum<worldProxWindowsType> WindowsType
		{
			get => GetProperty(ref _windowsType);
			set => SetProperty(ref _windowsType, value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(2)] 
		[RED("distanceAboveProxy")] 
		public CFloat DistanceAboveProxy
		{
			get => GetProperty(ref _distanceAboveProxy);
			set => SetProperty(ref _distanceAboveProxy, value);
		}

		[Ordinal(3)] 
		[RED("boolean")] 
		public CBool Boolean
		{
			get => GetProperty(ref _boolean);
			set => SetProperty(ref _boolean, value);
		}

		[Ordinal(4)] 
		[RED("removeSmallerThan")] 
		public CFloat RemoveSmallerThan
		{
			get => GetProperty(ref _removeSmallerThan);
			set => SetProperty(ref _removeSmallerThan, value);
		}

		[Ordinal(5)] 
		[RED("distantWindowsEmissive")] 
		public CFloat DistantWindowsEmissive
		{
			get => GetProperty(ref _distantWindowsEmissive);
			set => SetProperty(ref _distantWindowsEmissive, value);
		}

		[Ordinal(6)] 
		[RED("distantWindowsSize")] 
		public CFloat DistantWindowsSize
		{
			get => GetProperty(ref _distantWindowsSize);
			set => SetProperty(ref _distantWindowsSize, value);
		}

		[Ordinal(7)] 
		[RED("distantWindowsSaturation")] 
		public CFloat DistantWindowsSaturation
		{
			get => GetProperty(ref _distantWindowsSaturation);
			set => SetProperty(ref _distantWindowsSaturation, value);
		}

		[Ordinal(8)] 
		[RED("distantWindowsTurnedOf")] 
		public CFloat DistantWindowsTurnedOf
		{
			get => GetProperty(ref _distantWindowsTurnedOf);
			set => SetProperty(ref _distantWindowsTurnedOf, value);
		}
	}
}
