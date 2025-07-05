
namespace WolvenKit.RED4.Types
{
	public partial class InvisibleSceneStash : Device
	{
		public InvisibleSceneStash()
		{
			ControllerTypeName = "InvisibleSceneStashController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
