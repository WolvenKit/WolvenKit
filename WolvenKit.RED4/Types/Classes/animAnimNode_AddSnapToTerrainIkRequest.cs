using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(13)] 
		[RED("animDeltaZ")] 
		public animFloatLink AnimDeltaZ
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("leftFootRequest")] 
		public animSnapToTerrainIkRequest LeftFootRequest
		{
			get => GetPropertyValue<animSnapToTerrainIkRequest>();
			set => SetPropertyValue<animSnapToTerrainIkRequest>(value);
		}

		[Ordinal(15)] 
		[RED("rightFootRequest")] 
		public animSnapToTerrainIkRequest RightFootRequest
		{
			get => GetPropertyValue<animSnapToTerrainIkRequest>();
			set => SetPropertyValue<animSnapToTerrainIkRequest>(value);
		}

		[Ordinal(16)] 
		[RED("hipsRequest")] 
		public animHipsIkRequest HipsRequest
		{
			get => GetPropertyValue<animHipsIkRequest>();
			set => SetPropertyValue<animHipsIkRequest>(value);
		}

		public animAnimNode_AddSnapToTerrainIkRequest()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			AnimDeltaZ = new animFloatLink();
			LeftFootRequest = new animSnapToTerrainIkRequest { FootTransformIndex = new animTransformIndex(), PoleVectorRefTransformIndex = new animTransformIndex(), EnableFootLockFloatTrack = new animNamedTrackIndex() };
			RightFootRequest = new animSnapToTerrainIkRequest { FootTransformIndex = new animTransformIndex(), PoleVectorRefTransformIndex = new animTransformIndex(), EnableFootLockFloatTrack = new animNamedTrackIndex() };
			HipsRequest = new animHipsIkRequest { HipsTransformIndex = new animTransformIndex(), LeftFootTransformIndex = new animTransformIndex(), RightFootTransformIndex = new animTransformIndex() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
