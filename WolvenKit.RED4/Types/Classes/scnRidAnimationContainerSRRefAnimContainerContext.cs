using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidAnimationContainerSRRefAnimContainerContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("genderMask")] 
		public scnGenderMask GenderMask
		{
			get => GetPropertyValue<scnGenderMask>();
			set => SetPropertyValue<scnGenderMask>(value);
		}

		public scnRidAnimationContainerSRRefAnimContainerContext()
		{
			GenderMask = new() { Mask = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
