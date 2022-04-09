using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnscreenplayOptionUsage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playerGenderMask")] 
		public scnGenderMask PlayerGenderMask
		{
			get => GetPropertyValue<scnGenderMask>();
			set => SetPropertyValue<scnGenderMask>(value);
		}

		public scnscreenplayOptionUsage()
		{
			PlayerGenderMask = new() { Mask = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
