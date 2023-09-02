
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIInspectListener : IScriptable
	{
		public questIInspectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
