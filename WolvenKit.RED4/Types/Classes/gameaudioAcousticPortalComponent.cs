using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioAcousticPortalComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("radius")] 
		public CUInt8 Radius
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("nominalRadius")] 
		public CUInt8 NominalRadius
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("initialyOpen")] 
		public CBool InitialyOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameaudioAcousticPortalComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			InitialyOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
