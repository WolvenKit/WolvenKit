using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_WeaponScopeData : animAnimFeature
	{
		private CFloat _ironsightAngleWithScope;
		private CBool _hasScope;

		[Ordinal(0)] 
		[RED("ironsightAngleWithScope")] 
		public CFloat IronsightAngleWithScope
		{
			get => GetProperty(ref _ironsightAngleWithScope);
			set => SetProperty(ref _ironsightAngleWithScope, value);
		}

		[Ordinal(1)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetProperty(ref _hasScope);
			set => SetProperty(ref _hasScope, value);
		}
	}
}
