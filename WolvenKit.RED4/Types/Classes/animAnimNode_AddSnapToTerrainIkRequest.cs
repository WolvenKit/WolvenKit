using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("animDeltaZ")] 
		public animFloatLink AnimDeltaZ
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("leftFootRequest")] 
		public animSnapToTerrainIkRequest LeftFootRequest
		{
			get => GetPropertyValue<animSnapToTerrainIkRequest>();
			set => SetPropertyValue<animSnapToTerrainIkRequest>(value);
		}

		[Ordinal(4)] 
		[RED("rightFootRequest")] 
		public animSnapToTerrainIkRequest RightFootRequest
		{
			get => GetPropertyValue<animSnapToTerrainIkRequest>();
			set => SetPropertyValue<animSnapToTerrainIkRequest>(value);
		}

		[Ordinal(5)] 
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
			LeftFootRequest = new animSnapToTerrainIkRequest();
			RightFootRequest = new animSnapToTerrainIkRequest();
			HipsRequest = new animHipsIkRequest();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
