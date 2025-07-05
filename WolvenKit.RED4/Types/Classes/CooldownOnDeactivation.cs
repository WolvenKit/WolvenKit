
namespace WolvenKit.RED4.Types
{
	public partial class CooldownOnDeactivation : AICooldown
	{
		public CooldownOnDeactivation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
