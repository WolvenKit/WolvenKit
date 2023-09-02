
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameStatModifierBase : RedBaseClass
	{
		public gameStatModifierBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
