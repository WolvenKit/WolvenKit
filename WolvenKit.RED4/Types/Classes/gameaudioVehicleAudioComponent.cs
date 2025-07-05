
namespace WolvenKit.RED4.Types
{
	public partial class gameaudioVehicleAudioComponent : gameaudioSoundComponentBase
	{
		public gameaudioVehicleAudioComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			ObstructionChangeTime = 0.200000F;
			MaxPlayDistance = 40.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
