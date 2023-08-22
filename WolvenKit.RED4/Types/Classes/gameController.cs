
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameController : gameObject
	{
		public gameController()
		{
			PlayerSocket = new gamePlayerSocket();
			Tags = new redTagList { Tags = new() };
			DisplayName = new() { Unk1 = 0, Value = "" };
			DisplayDescription = new() { Unk1 = 0, Value = "" };
			VisibilityCheckDistance = 16000.000000F;
			PrereqListeners = new();
			StatusEffectListeners = new();
			ReceivedDamageHistory = new();
			LastHitInstigatorID = new entEntityID();
			HitInstigatorCooldownID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
