
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiICustomizationStateUpdater : IScriptable
	{
		public gameuiICustomizationStateUpdater()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
