
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkipConsoleBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SkipConsoleBegin()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
