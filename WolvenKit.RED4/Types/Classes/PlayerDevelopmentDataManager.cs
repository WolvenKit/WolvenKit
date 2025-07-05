using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerDevelopmentDataManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(2)] 
		[RED("parentGameCtrl")] 
		public CWeakHandle<gameuiWidgetGameController> ParentGameCtrl
		{
			get => GetPropertyValue<CWeakHandle<gameuiWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiWidgetGameController>>(value);
		}

		public PlayerDevelopmentDataManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
