
namespace WolvenKit.RED4.Types
{
	public partial class UpdateComponent : gameScriptableComponent
	{
		public UpdateComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
