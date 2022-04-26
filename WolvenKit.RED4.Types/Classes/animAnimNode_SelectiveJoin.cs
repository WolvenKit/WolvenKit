
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SelectiveJoin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SelectiveJoin()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
