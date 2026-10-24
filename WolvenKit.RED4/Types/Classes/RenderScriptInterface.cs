
namespace WolvenKit.RED4.Types
{
	public partial class RenderScriptInterface : IScriptable
	{
		public RenderScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
