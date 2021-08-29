using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_NPCVehicleAdditionalFeatures : animAnimFeatureMarkUnstable
	{
		private CBool _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
