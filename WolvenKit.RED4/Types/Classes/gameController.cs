
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameController : gameObject
	{
		public gameController()
		{
			PlayerSocket = new gamePlayerSocket();
			Tags = new redTagList { Tags = new() };
			DisplayName = new() { Unk1 = 0, Value = "" };
			DisplayDescription = new() { Unk1 = 0, Value = "" };
			VisibilityCheckDistance = 16000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
