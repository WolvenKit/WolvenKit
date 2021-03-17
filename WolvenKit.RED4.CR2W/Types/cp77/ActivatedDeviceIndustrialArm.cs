using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceIndustrialArm : ActivatedDeviceTrap
	{
		private CEnum<EIndustrialArmAnimations> _loopAnimation;

		[Ordinal(95)] 
		[RED("loopAnimation")] 
		public CEnum<EIndustrialArmAnimations> LoopAnimation
		{
			get => GetProperty(ref _loopAnimation);
			set => SetProperty(ref _loopAnimation, value);
		}

		public ActivatedDeviceIndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
