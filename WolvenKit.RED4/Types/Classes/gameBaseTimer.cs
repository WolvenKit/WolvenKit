
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameBaseTimer : IScriptable
	{
		public gameBaseTimer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
