using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseSensorObjectComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get => GetPropertyValue<CHandle<senseSensorObject>>();
			set => SetPropertyValue<CHandle<senseSensorObject>>(value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public senseSensorObjectComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
