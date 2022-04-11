using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_LeftHandAnimation : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("lockLeftHandAnimation")] 
		public CBool LockLeftHandAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
