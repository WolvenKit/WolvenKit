
namespace WolvenKit.RED4.Types
{
	public abstract partial class mpPlayer : gamePlayer
	{
		public mpPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
