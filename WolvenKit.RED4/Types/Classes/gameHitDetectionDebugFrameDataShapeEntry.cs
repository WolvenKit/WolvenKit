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
			AnsformWS = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
