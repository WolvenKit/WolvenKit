using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_DamageInputReceiver : IScriptable
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public DEBUG_DamageInputReceiver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
