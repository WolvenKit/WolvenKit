
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIWeapon : IScriptable
	{
		public AIWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
