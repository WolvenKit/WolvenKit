
namespace WolvenKit.RED4.Types
{
	public abstract partial class DamageSystemHelper : IScriptable
	{
		public DamageSystemHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
