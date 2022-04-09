
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FacialSharedMetaPose : animAnimNode_OnePoseInput
	{
		public animAnimNode_FacialSharedMetaPose()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
