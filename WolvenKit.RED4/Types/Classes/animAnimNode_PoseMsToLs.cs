
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseMsToLs : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseMsToLs()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
