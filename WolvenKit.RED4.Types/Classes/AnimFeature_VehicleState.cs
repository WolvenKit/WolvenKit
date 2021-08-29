using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_VehicleState : animAnimFeatureMarkUnstable
	{
		private CBool _tppEnabled;

		[Ordinal(0)] 
		[RED("tppEnabled")] 
		public CBool TppEnabled
		{
			get => GetProperty(ref _tppEnabled);
			set => SetProperty(ref _tppEnabled, value);
		}
	}
}
