
namespace WolvenKit.RED4.Types
{
	public partial class ABaseWrapper : IScriptable
	{
		public ABaseWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
