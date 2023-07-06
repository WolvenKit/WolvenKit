
namespace WolvenKit.RED4.Types
{
	public abstract partial class entEntitySpawnToken : IScriptable
	{
		public entEntitySpawnToken()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
