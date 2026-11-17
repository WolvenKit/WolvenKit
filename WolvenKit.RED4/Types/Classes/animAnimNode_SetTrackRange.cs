using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("oldMin")] 
		public CFloat OldMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("oldMax")] 
		public CFloat OldMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("minLink")] 
		public animFloatLink MinLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(7)] 
		[RED("maxLink")] 
		public animFloatLink MaxLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(8)] 
		[RED("oldMinLink")] 
		public animFloatLink OldMinLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(9)] 
		[RED("oldMaxLink")] 
		public animFloatLink OldMaxLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(10)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(11)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_SetTrackRange()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			MinLink = new animFloatLink();
			MaxLink = new animFloatLink();
			OldMinLink = new animFloatLink();
			OldMaxLink = new animFloatLink();
			Track = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
