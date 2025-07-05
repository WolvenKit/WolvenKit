
namespace WolvenKit.RED4.Types
{
	public abstract partial class TweakAIActionRecord : IScriptable
	{
		public TweakAIActionRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
