using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnMonowireWindowToSpreadQuickhackCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("MonoWireApplyQuickhackEffector")] 
		public CHandle<MonoWireQuickHackApplyEffector> MonoWireApplyQuickhackEffector
		{
			get => GetPropertyValue<CHandle<MonoWireQuickHackApplyEffector>>();
			set => SetPropertyValue<CHandle<MonoWireQuickHackApplyEffector>>(value);
		}

		[Ordinal(1)] 
		[RED("PlayerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public OnMonowireWindowToSpreadQuickhackCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
