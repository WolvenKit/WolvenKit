
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseCorrection : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseCorrection()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
