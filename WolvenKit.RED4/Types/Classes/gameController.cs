
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameController : gameObject
	{
		public gameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
