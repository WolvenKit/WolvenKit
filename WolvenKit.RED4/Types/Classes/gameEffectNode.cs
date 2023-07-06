
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectNode : IScriptable
	{
		public gameEffectNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
