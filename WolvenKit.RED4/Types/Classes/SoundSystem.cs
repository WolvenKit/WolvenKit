
namespace WolvenKit.RED4.Types
{
	public partial class SoundSystem : InteractiveMasterDevice
	{
		public SoundSystem()
		{
			ControllerTypeName = "SoundSystemController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
