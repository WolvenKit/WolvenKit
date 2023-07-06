
namespace WolvenKit.RED4.Types
{
	public abstract partial class questAICommandParams : scnAICommandFactory
	{
		public questAICommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
