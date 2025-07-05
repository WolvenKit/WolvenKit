using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePingComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("associatedPingType")] 
		public CEnum<gamedataPingType> AssociatedPingType
		{
			get => GetPropertyValue<CEnum<gamedataPingType>>();
			set => SetPropertyValue<CEnum<gamedataPingType>>(value);
		}

		public gamePingComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			AssociatedPingType = Enums.gamedataPingType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
