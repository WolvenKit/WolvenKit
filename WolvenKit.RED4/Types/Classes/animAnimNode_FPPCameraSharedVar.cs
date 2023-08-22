
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FPPCameraSharedVar : animAnimNode_FloatValue
	{
		public animAnimNode_FPPCameraSharedVar()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
