
namespace WolvenKit.RED4.Types
{
	public abstract partial class CActionScriptProxy : IScriptable
	{
		public CActionScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
