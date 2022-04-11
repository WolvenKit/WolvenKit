using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatform : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("loopType")] 
		public CEnum<gameMovingPlatformLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<gameMovingPlatformLoopType>>();
			set => SetPropertyValue<CEnum<gameMovingPlatformLoopType>>(value);
		}

		[Ordinal(6)] 
		[RED("supportLegacyUnalignedMarkers")] 
		public CBool SupportLegacyUnalignedMarkers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMovingPlatform()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			SupportLegacyUnalignedMarkers = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
