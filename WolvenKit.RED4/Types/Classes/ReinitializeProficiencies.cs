
namespace WolvenKit.RED4.Types
{
	public partial class ReinitializeProficiencies : gamePlayerScriptableSystemRequest
	{
		public ReinitializeProficiencies()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
