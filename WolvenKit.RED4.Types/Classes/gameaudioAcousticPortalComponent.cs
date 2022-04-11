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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			InitialyOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
