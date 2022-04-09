
namespace WolvenKit.RED4.Types
{
	public partial class redCallbackObject : IScriptable
	{
		public redCallbackObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
