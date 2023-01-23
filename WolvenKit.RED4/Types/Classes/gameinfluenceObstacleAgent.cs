using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceObstacleAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] 
		[RED("useMeshes")] 
		public CBool UseMeshes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinfluenceObstacleAgent()
		{
			UseMeshes = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
