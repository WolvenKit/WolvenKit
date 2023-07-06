
namespace WolvenKit.RED4.Types
{
	public abstract partial class entIVelocityProvider : IScriptable
	{
		public entIVelocityProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
