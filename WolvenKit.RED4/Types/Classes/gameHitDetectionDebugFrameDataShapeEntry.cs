using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitDetectionDebugFrameDataShapeEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ansformWS")] 
		public WorldTransform AnsformWS
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		public gameHitDetectionDebugFrameDataShapeEntry()
		{
			AnsformWS = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
