
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDamageSystemListener : IScriptable
	{
		public gameIDamageSystemListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
