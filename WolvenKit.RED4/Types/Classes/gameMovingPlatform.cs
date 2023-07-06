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
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			SupportLegacyUnalignedMarkers = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
