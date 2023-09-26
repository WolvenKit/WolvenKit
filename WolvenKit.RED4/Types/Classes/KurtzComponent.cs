
namespace WolvenKit.RED4.Types
{
	public partial class KurtzComponent : gameScriptableComponent
	{
		public KurtzComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
