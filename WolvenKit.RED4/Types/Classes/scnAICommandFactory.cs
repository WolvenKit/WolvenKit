
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnAICommandFactory : IScriptable
	{
		public scnAICommandFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
