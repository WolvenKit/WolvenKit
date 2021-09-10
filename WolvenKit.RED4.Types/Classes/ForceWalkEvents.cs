using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceWalkEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("storedSpeedValue")] 
		public CFloat StoredSpeedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
