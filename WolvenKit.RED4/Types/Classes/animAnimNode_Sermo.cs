
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Sermo : animAnimNode_OnePoseInput
	{
		public animAnimNode_Sermo()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
