
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameController : gameObject
	{

		public gameController()
		{
			PlayerSocket = new();
			Tags = new() { Tags = new() };
			DisplayName = new() { Unk1 = 0, Value = "" };
			DisplayDescription = new() { Unk1 = 0, Value = "" };
			VisibilityCheckDistance = 16000.000000F;
			PrereqListeners = new();
			StatusEffectListeners = new();
			ReceivedDamageHistory = new();
			LastHitInstigatorID = new();
			HitInstigatorCooldownID = new();
		}
	}
}
