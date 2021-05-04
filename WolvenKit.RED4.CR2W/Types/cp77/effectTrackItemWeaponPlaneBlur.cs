using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemWeaponPlaneBlur : effectTrackItem
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

		public effectTrackItemWeaponPlaneBlur(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
