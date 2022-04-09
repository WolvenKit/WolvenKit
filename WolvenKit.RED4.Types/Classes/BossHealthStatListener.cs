using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BossHealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<BossHealthBarGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<BossHealthBarGameController>>();
			set => SetPropertyValue<CWeakHandle<BossHealthBarGameController>>(value);
		}

		public BossHealthStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
