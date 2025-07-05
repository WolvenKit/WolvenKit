
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DisableLunaticMode : animAnimNode_OnePoseInput
	{
		public animAnimNode_DisableLunaticMode()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
