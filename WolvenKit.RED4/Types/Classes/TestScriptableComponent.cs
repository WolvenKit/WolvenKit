
namespace WolvenKit.RED4.Types
{
	public partial class TestScriptableComponent : gameScriptableComponent
	{
		public TestScriptableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
