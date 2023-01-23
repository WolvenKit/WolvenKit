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
			Id = 4294967295;
			InputLink = new();
			AnimDeltaZ = new();
			LeftFootRequest = new() { FootTransformIndex = new(), PoleVectorRefTransformIndex = new(), EnableFootLockFloatTrack = new() };
			RightFootRequest = new() { FootTransformIndex = new(), PoleVectorRefTransformIndex = new(), EnableFootLockFloatTrack = new() };
			HipsRequest = new() { HipsTransformIndex = new(), LeftFootTransformIndex = new(), RightFootTransformIndex = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
