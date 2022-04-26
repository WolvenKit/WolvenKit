using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSnapToTerrainIkRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("footTransformIndex")] 
		public animTransformIndex FootTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("poleVectorRefTransformIndex")] 
		public animTransformIndex PoleVectorRefTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("enableFootLockFloatTrack")] 
		public animNamedTrackIndex EnableFootLockFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animSnapToTerrainIkRequest()
		{
			FootTransformIndex = new();
			PoleVectorRefTransformIndex = new();
			EnableFootLockFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
