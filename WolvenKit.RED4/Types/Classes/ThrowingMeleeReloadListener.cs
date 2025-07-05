using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowingMeleeReloadListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("melee")] 
		public CWeakHandle<MeleeProjectile> Melee
		{
			get => GetPropertyValue<CWeakHandle<MeleeProjectile>>();
			set => SetPropertyValue<CWeakHandle<MeleeProjectile>>(value);
		}

		public ThrowingMeleeReloadListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
