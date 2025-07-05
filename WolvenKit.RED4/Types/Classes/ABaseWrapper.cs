
namespace WolvenKit.RED4.Types
{
	public abstract partial class ABaseWrapper : IScriptable
	{
		public ABaseWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
