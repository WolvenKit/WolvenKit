using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimatorComponent : entIPlacedComponent
	{
		private CArray<gameTransformAnimationDefinition> _animations;

		[Ordinal(5)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}
	}
}
