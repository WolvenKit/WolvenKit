
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAttack : IScriptable
	{
		public gameIAttack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
