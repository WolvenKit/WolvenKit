
namespace WolvenKit.RED4.Types
{
	public abstract partial class TweakAISubAction : IScriptable
	{
		public TweakAISubAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
