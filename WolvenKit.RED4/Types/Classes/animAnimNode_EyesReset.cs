
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_EyesReset : animAnimNode_OnePoseInput
	{
		public animAnimNode_EyesReset()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
