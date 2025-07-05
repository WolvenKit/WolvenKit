using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_KillEffect : gameTransformAnimation_Effects
	{
		[Ordinal(0)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameTransformAnimation_KillEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
