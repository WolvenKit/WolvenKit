using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("oldMin")] 
		public CFloat OldMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("oldMax")] 
		public CFloat OldMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("minLink")] 
		public animFloatLink MinLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("maxLink")] 
		public animFloatLink MaxLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(18)] 
		[RED("oldMinLink")] 
		public animFloatLink OldMinLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(19)] 
		[RED("oldMaxLink")] 
		public animFloatLink OldMaxLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(20)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(21)] 
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
