
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_EyesReset : animAnimNode_OnePoseInput
	{
		public animAnimNode_EyesReset()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
