
namespace WolvenKit.RED4.Types
{
	public abstract partial class redICommandlet : RedBaseClass
	{
		public redICommandlet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
