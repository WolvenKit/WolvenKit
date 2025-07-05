using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		[Ordinal(6)] 
		[RED("inputMinRayAngleDiff")] 
		public gameEffectInputParameter_Float InputMinRayAngleDiff
		{
			get => GetPropertyValue<gameEffectInputParameter_Float>();
			set => SetPropertyValue<gameEffectInputParameter_Float>(value);
		}

		public gameEffectObjectProvider_PhysicalRayFan()
		{
			InputMinRayAngleDiff = new gameEffectInputParameter_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
