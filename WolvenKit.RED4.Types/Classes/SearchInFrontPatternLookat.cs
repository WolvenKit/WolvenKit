
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SearchInFrontPatternLookat : AISearchingLookat
	{

		public SearchInFrontPatternLookat()
		{
			LookatTarget = new();
			CurrentLookatTarget = new();
			CurrentTarget = new();
			LastTarget = new();
			SideHorizontal = 1;
			SideVertical = 1;
		}
	}
}
