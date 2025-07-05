
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEffect : IScriptable
	{
		public gameIEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
