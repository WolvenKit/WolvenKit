
namespace WolvenKit.RED4.Types
{
	public partial class CActionScriptProxy : IScriptable
	{
		public CActionScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
