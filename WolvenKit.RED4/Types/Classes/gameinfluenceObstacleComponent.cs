using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceObstacleComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("boundingBoxType")] 
		public CEnum<gameinfluenceEBoundingBoxType> BoundingBoxType
		{
			get => GetPropertyValue<CEnum<gameinfluenceEBoundingBoxType>>();
			set => SetPropertyValue<CEnum<gameinfluenceEBoundingBoxType>>(value);
		}

		[Ordinal(6)] 
		[RED("customBoundingBox")] 
		public Box CustomBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(7)] 
		[RED("obstacleAgent")] 
		public gameinfluenceObstacleAgent ObstacleAgent
		{
			get => GetPropertyValue<gameinfluenceObstacleAgent>();
			set => SetPropertyValue<gameinfluenceObstacleAgent>(value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinfluenceObstacleComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			CustomBoundingBox = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };
			ObstacleAgent = new gameinfluenceObstacleAgent();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
