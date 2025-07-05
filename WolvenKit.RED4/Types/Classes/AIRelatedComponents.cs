
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIRelatedComponents : gameScriptableComponent
	{
		public AIRelatedComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
