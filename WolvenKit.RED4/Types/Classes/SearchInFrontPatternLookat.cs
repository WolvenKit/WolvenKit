
namespace WolvenKit.RED4.Types
{
	public partial class SearchInFrontPatternLookat : AISearchingLookat
	{
		public SearchInFrontPatternLookat()
		{
			LookatTarget = new Vector4();
			CurrentLookatTarget = new Vector4();
			CurrentTarget = new Vector4();
			LastTarget = new Vector4();
			SideHorizontal = 1;
			SideVertical = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
