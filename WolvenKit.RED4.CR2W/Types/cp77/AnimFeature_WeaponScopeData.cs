using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponScopeData : animAnimFeature
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

		public AnimFeature_WeaponScopeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
