using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_BreakEffectLoop : gameTransformAnimation_Effects
	{
		[Ordinal(0)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameTransformAnimation_BreakEffectLoop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
