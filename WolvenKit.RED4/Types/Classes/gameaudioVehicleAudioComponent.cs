
namespace WolvenKit.RED4.Types
{
	public partial class gameaudioVehicleAudioComponent : gameaudioSoundComponentBase
	{
		public gameaudioVehicleAudioComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			ObstructionChangeTime = 0.200000F;
			MaxPlayDistance = 40.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
