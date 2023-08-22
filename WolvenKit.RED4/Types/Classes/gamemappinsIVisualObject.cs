
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamemappinsIVisualObject : IScriptable
	{
		public gamemappinsIVisualObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
