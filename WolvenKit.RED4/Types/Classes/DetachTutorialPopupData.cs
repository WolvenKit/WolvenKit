
namespace WolvenKit.RED4.Types
{
	public partial class DetachTutorialPopupData : TutorialPopupData
	{
		public DetachTutorialPopupData()
		{
			CloseAtInput = true;
			PauseGame = true;
			IsModal = true;
			Position = Enums.gamePopupPosition.LowerLeft;
			Title = "LocKey#96663";
			Message = "LocKey#96664";
			VideoType = Enums.gameVideoType.Tutorial_1360x768;
			Video = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\movies\tutorials\1360x768\detach.bk2") };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
