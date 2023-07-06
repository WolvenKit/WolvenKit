
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SelectiveJoin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SelectiveJoin()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
