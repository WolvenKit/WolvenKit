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
			AnsformWS = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
