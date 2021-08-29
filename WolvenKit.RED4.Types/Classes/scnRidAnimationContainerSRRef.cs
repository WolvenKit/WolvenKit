using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidAnimationContainerSRRef : RedBaseClass
	{
		private CArray<scnRidAnimationContainerSRRefAnimContainer> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}
	}
}
