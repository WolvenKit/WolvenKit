
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameOnExecutionContext : RedBaseClass
	{
		public gameOnExecutionContext()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
