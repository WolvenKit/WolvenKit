using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceWalkEvents : LocomotionGroundEvents
	{
		private CFloat _storedSpeedValue;

		[Ordinal(3)] 
		[RED("storedSpeedValue")] 
		public CFloat StoredSpeedValue
		{
			get => GetProperty(ref _storedSpeedValue);
			set => SetProperty(ref _storedSpeedValue, value);
		}
	}
}
