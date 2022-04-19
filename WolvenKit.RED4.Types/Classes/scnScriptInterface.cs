
namespace WolvenKit.RED4.Types
{
	public partial class scnScriptInterface : IScriptable
	{
		public scnScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
