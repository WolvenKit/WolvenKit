
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseMsToLs : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseMsToLs()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
