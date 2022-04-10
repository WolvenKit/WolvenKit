
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseLsToMs : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseLsToMs()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
