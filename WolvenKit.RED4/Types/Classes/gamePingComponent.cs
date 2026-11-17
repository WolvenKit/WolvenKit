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
			LocalTransform = new WorldTransform();
			AssociatedPingType = Enums.gamedataPingType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
