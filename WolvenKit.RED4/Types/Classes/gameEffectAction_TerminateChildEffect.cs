using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectAction_TerminateChildEffect : gameEffectAction
	{
		[Ordinal(0)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectAction_TerminateChildEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
