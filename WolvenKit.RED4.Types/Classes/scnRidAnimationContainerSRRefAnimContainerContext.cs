using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidAnimationContainerSRRefAnimContainerContext : RedBaseClass
	{
		private scnGenderMask _genderMask;

		[Ordinal(0)] 
		[RED("genderMask")] 
		public scnGenderMask GenderMask
		{
			get => GetProperty(ref _genderMask);
			set => SetProperty(ref _genderMask, value);
		}
	}
}
