using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRootTransformAnimatorComponent : entIMoverComponent
	{
		private CArray<gameTransformAnimationDefinition> _animations;

		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}
	}
}
