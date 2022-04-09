
namespace WolvenKit.RED4.Types
{
	public partial class AutoSaveRequest : gameScriptableSystemRequest
	{
		public AutoSaveRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
