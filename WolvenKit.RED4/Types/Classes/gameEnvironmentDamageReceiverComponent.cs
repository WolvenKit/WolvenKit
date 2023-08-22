using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEnvironmentDamageReceiverComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<gameEnvironmentDamageReceiverShape>> Shapes
		{
			get => GetPropertyValue<CArray<CHandle<gameEnvironmentDamageReceiverShape>>>();
			set => SetPropertyValue<CArray<CHandle<gameEnvironmentDamageReceiverShape>>>(value);
		}

		public gameEnvironmentDamageReceiverComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Shapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
