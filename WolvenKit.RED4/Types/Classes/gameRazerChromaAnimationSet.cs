using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRazerChromaAnimationSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<gameRazerChromaAnimation> Animations
		{
			get => GetPropertyValue<CArray<gameRazerChromaAnimation>>();
			set => SetPropertyValue<CArray<gameRazerChromaAnimation>>(value);
		}

		public gameRazerChromaAnimationSet()
		{
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
