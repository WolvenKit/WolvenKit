using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemWeaponPlaneBlur : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _farPlaneMultiplier;
		private CBool _override;

		[Ordinal(3)] 
		[RED("farPlaneMultiplier")] 
		public effectEffectParameterEvaluatorFloat FarPlaneMultiplier
		{
			get => GetProperty(ref _farPlaneMultiplier);
			set => SetProperty(ref _farPlaneMultiplier, value);
		}

		[Ordinal(4)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}
	}
}
