using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		[Ordinal(5)] 
		[RED("inputMinRayAngleDiff")] 
		public gameEffectInputParameter_Float InputMinRayAngleDiff
		{
			get => GetPropertyValue<gameEffectInputParameter_Float>();
			set => SetPropertyValue<gameEffectInputParameter_Float>(value);
		}

		public gameEffectObjectProvider_PhysicalRayFan()
		{
			InputMinRayAngleDiff = new();
		}
	}
}
