using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectAction_KillFX : gameEffectAction
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectAction_KillFXAction> Action
		{
			get => GetPropertyValue<CEnum<gameEffectAction_KillFXAction>>();
			set => SetPropertyValue<CEnum<gameEffectAction_KillFXAction>>(value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectAction_KillFX()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
