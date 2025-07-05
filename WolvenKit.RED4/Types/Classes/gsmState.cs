
namespace WolvenKit.RED4.Types
{
	public abstract partial class gsmState : IScriptable
	{
		public gsmState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
