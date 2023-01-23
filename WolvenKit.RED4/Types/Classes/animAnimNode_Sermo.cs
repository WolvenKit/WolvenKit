
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Sermo : animAnimNode_OnePoseInput
	{
		public animAnimNode_Sermo()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
