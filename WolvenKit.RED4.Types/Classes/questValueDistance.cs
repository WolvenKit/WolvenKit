using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questValueDistance : questIDistance
	{
		private CFloat _distanceValue;

		[Ordinal(0)] 
		[RED("distanceValue")] 
		public CFloat DistanceValue
		{
			get => GetProperty(ref _distanceValue);
			set => SetProperty(ref _distanceValue, value);
		}
	}
}
