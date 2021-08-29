using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		private gameEffectInputParameter_Float _inputMinRayAngleDiff;

		[Ordinal(5)] 
		[RED("inputMinRayAngleDiff")] 
		public gameEffectInputParameter_Float InputMinRayAngleDiff
		{
			get => GetProperty(ref _inputMinRayAngleDiff);
			set => SetProperty(ref _inputMinRayAngleDiff, value);
		}
	}
}
