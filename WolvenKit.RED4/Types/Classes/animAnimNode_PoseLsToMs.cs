
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseLsToMs : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseLsToMs()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
