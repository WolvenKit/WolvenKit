
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkipConsoleBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SkipConsoleBegin()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
