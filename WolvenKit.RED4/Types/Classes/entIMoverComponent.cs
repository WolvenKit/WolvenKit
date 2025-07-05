
namespace WolvenKit.RED4.Types
{
	public abstract partial class entIMoverComponent : entIComponent
	{
		public entIMoverComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
