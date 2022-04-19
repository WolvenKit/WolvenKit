
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FPPCamera : animAnimNode_OnePoseInput
	{
		public animAnimNode_FPPCamera()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
