
namespace WolvenKit.RED4.Types
{
	public partial class ActionsSequencer : InteractiveMasterDevice
	{
		public ActionsSequencer()
		{
			ControllerTypeName = "ActionsSequencerController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
