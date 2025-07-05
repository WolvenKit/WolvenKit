
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkMenuInstance : IScriptable
	{
		public inkMenuInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
