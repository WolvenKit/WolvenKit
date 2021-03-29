using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitch : InteractiveMasterDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CFloat _animationSpeed;

		[Ordinal(96)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(97)] 
		[RED("animationSpeed")] 
		public CFloat AnimationSpeed
		{
			get => GetProperty(ref _animationSpeed);
			set => SetProperty(ref _animationSpeed, value);
		}

		public SimpleSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
