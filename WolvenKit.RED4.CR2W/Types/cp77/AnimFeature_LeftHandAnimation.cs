using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandAnimation : animAnimFeature
	{
		private CBool _lockLeftHandAnimation;

		[Ordinal(0)] 
		[RED("lockLeftHandAnimation")] 
		public CBool LockLeftHandAnimation
		{
			get => GetProperty(ref _lockLeftHandAnimation);
			set => SetProperty(ref _lockLeftHandAnimation, value);
		}

		public AnimFeature_LeftHandAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
