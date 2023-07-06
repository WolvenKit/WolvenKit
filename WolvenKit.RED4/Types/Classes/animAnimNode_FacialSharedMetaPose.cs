
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FacialSharedMetaPose : animAnimNode_OnePoseInput
	{
		public animAnimNode_FacialSharedMetaPose()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
